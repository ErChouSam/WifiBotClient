using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace GUIWifiBotCommande
{
    public partial class GUICommande : Form
    {
        struct SensorData
        {
            public int BatteryCapacity;	// Capacité des batteries
            public int IRFrontLeft;		// Valeur du capteur infrarouge avant babord
            public int IRFrontRight;	// Valeur du capteur infrarouge avant tribord
            public int IRBackLeft;		// Valeur du capteur infrarouge arrière babord
            public int IRBackRight;		// Valeur du capteur infrarouge arrière tribord
        };
        SensorData mySensorData;
        


        private string IpAddress;					// IP du wifibot
        private int Port;							// Port du wifibot

        bool SockTrue = false;						// Test de connection (True = connecté au Wifibot)

        TcpClient SockTcp = new TcpClient();		// ???
        NetworkStream stream;						// Flux de données

        Thread SocketChecker;						// Vérifie que le socket soit connecté
        Thread SocketReader;						// Lit ce que le socket renvoie

        byte[] Frame = { 0xff, 0x07, 0x0f, 0x00, 0x11, 0x00, 0x40, 0x00, 0x00 };	// La trame à envoyer au Wifibot permettant de le contrôler
        byte[] TestFrame = { 0xff, 0x07, 0x32, 0x00, 0x32, 0x00, 0xE0, 0x34, 0x98 };
        /**
         * Constructeur par défaut.
         */
        public GUICommande()
        {
            // Initialise les valeurs par défauts
            Port = 0;
            IpAddress = "";
            InitializeComponent();
            progressBarLeft.Maximum = 255;
            progressBarRight.Maximum = 255;
            numericUpDownLeft.Maximum = 255;
            numericUpDownRight.Maximum = 255;
            toolStripStatusLabel1.Text = "Disconnected";
        }

        /**
         * Met à jour dans l'interface les barres de vitesse dans l'interface.
         */
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Met à jour la barre de vitesse des roues babord
            progressBarLeft.Value = (int)numericUpDownLeft.Value;
            Frame[2] = byte.Parse(numericUpDownLeft.Value.ToString());

            // Met à jour la barre de vitesse des roues tribord
            progressBarRight.Value = (int)numericUpDownRight.Value;
            Frame[4] = byte.Parse(numericUpDownRight.Value.ToString());

            // Vérifie l'intégrité des données (CRC)
            byte[] buffer = BitConverter.GetBytes(CRC16(Frame, 1, 6));
            Frame[7] = buffer[0];
            Frame[8] = buffer[1];
            SendFrameToWifibot();
        }

        /**
         * Met à jour dans l'interface les barres de vitesse dans l'interface.
         */
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Met à jour la barre de vitesse gauche
            progressBarLeft.Value = (int)numericUpDownLeft.Value;
            Frame[2] = byte.Parse(numericUpDownLeft.Value.ToString());

            // Met à jour la barre de vitesse droite
            progressBarRight.Value = (int)numericUpDownRight.Value;
            Frame[4] = byte.Parse(numericUpDownRight.Value.ToString());

            // Vérifie l'intégrité des données (CRC 16bit)
            byte[] buffer = BitConverter.GetBytes(CRC16(Frame, 1, 6));
            Frame[7] = buffer[0];
            Frame[8] = buffer[1];
            SendFrameToWifibot();
        }

        /**
         * Connecte le client au Wifibot et met à jour l'indicateur "connected" dans l'interface (en bas de la fenêtre).
         */
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection View = new Connection(this);

            View.ShowDialog();

            if (SockTrue)	// Si la connection est établie alors ...
            {
                try
                {
                    SockTcp.Connect(IpAddress, Port);
                    stream = SockTcp.GetStream();

                    // Met à jour dans l'interface le statut de la connexion (en bas de la fenêtre)
                    toolStripStatusLabel1.ForeColor = Color.Green;
                    toolStripStatusLabel1.Text = "Connected";
                    SocketChecker = new Thread(new ThreadStart(Thread_SockChecker));
                    SocketChecker.Start();
                }
                catch (ArgumentNullException f)
                {
                    MessageBox.Show("Connexion impossible " + "ArgumentNullException: {0}" + f, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SocketException f)
                {
                    MessageBox.Show("Connexion impossible " + "SocketException: {0}" + f, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**
         * Met à jour dans l'interface le statut de la connexion comme déconnecté (en bas de la fenêtre).
         */
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SockTcp.Connected)
            {
                // Met à jour dans l'interface le statut de la connexion comme déconnecté (en bas de la fenêtre)
                SocketChecker.Abort();
                toolStripStatusLabel1.Text = "Disconnected";
                SocketReader.Abort();
                SockTcp.Close();
                stream.Close();
            }
            this.Close();
        }

        /**
         * Modifie l'attribut contennant l'adresse ip du wifibot. 
         */
        public void SetIpAddressPort(string TIpAddress, int TPort)
        {
            SockTrue = true;
            IpAddress = TIpAddress;
            Port = TPort;
        }

        /**
         * 
         */
        private void Thread_SockChecker()
        {
            if (!SockTcp.Connected)
            {
                // Met à jour dans l'interface le statut de la connexion comme déconnecté (en bas de la fenêtre)
                toolStripStatusLabel1.Text = "Disconnected";
                MessageBox.Show("Connexion Perdu ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SocketReader.Abort();
                stream.Close();
                SockTcp.Close();
            }
        }

        /**
         * Vérifie l'intégrité des donnée contennue dans la trame.
         */
        private UInt16 CRC16(byte[] Frame, byte Begin, byte Size)
        {
            UInt16 Crc = 0xFFFF;
            UInt16 Polynome = 0xA001;
            UInt16 CptOctet = 0;
            UInt16 CptBit = 0;
            UInt16 Parity = 0;
            Crc = 0xFFFF;
            Polynome = 0xA001;
            for (CptOctet = Begin; CptOctet < (Begin + Size); CptOctet++)
            {
                Crc ^= Frame[CptOctet];
                for (CptBit = 0; CptBit <= 7; CptBit++)
                {
                    Parity = Crc;
                    Crc >>= 1;
                    if ((Parity % 2) == 1)
                        Crc ^= Polynome;
                }
            }
            return (Crc);
        }

        /**
         * Lit les donnée transitant dans le socket.
         */
        private void Thread_SockReader()
        {
            // Création sur la pile d'un buffer où on y insère les valeurs reçues depuis la Frame envoyé par le wifibot
            byte[] sbuf = new byte[30];
            stream.Read(sbuf, 0, 21);

            // Insertion des valeurs du buffer dans la structure mySensorData
            mySensorData.BatteryCapacity = sbuf[2];
            mySensorData.IRFrontLeft = sbuf[3];
            mySensorData.IRBackLeft = sbuf[4];
            mySensorData.IRFrontRight = sbuf[11];
            mySensorData.IRBackRight = sbuf[12];

            // Traitement des données de niveau de batterie
            double buffer = mySensorData.BatteryCapacity;
            buffer = (buffer / 255) * 100;			// Transforme la valeur double en pourcentage
            buffer = Math.Round(buffer, 1);		// Arrondie la valeur en pourcentage au dixième près

            // Met à jour dans l'interface des barres de progression
            BatteryValue.Text = buffer.ToString() + " %";
            progBarIRBackLeft.Value = mySensorData.IRBackLeft;
            progBarIRFrontLeft.Value = mySensorData.IRFrontLeft;
            progBarIRBackRight.Value = mySensorData.IRBackRight;
            progBarIRFrontRight.Value = mySensorData.IRFrontRight;
            progressBarBatteryLevel.Value = mySensorData.BatteryCapacity;
        }

        /**
         * Envoie la trame au wifibot afin de le controller.
         */
        private void SendFrameToWifibot()
        {
            // Vérifie l'entrée de l'utilisateur dans l'interface (bouton radio) et met à jour la trame
            if (LeftForward.Checked)
            {
                if (RightForward.Checked)
                    Frame[6] = 0xF1;
                else
                    Frame[6] = 0xE1;
            }
            else if (!LeftForward.Checked)
            {
                if (RightForward.Checked)
                    Frame[6] = 0xB1;
                else
                    Frame[6] = 0xA1;
            }

            // Ecrit la nouvelle trame dans le flux de donnée
            stream.Write(Frame, 0, 9);
            SocketReader = new Thread(new ThreadStart(Thread_SockReader));
            SocketReader.Start();
        }

        private void cameraViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://192.168.1.106:8080");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hex = BitConverter.ToString(Frame);
            textBox1.Text = hex ;
        }
    }
}
