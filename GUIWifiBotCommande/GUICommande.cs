using System;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace GUIWifiBotCommande
{
    public partial class GUICommande : Form
    {
        /*struct SensorData
        {
            int BatVoltage;
            int IRTopLeft;
            int IRTopRight;
            int IRBotLeft;
            int IRBotRight;
            
            public int GetBatVoltage() { return BatVoltage; }
            public int GetIRTopLeft() { return IRTopLeft; }
            public int GetIRTopRight() { return IRTopRight; }
            public int GetIRBotLeft() { return IRBotLeft; }
            public int GetIRBotRight() { return IRBotRight; }

            public void SetBatVoltage(int Bat) { BatVoltage = Bat; }
            public void SetIRTopLeft(int ir) { IRTopLeft = ir; }
            public void SetIRTopRight(int ir) { IRTopRight = ir; }
            public void SetIRBotLeft(int ir) { IRBotLeft = ir; }
            public void SetIRBotRight(int ir) { IRBotRight = ir; }

        };

        SensorData* DataSensor;*/
        int BatVoltage = 0;
        int IRTopLeft = 0;
        int IRTopRight = 0;
        int IRBotLeft = 0;
        int IRBotRight = 0;

        private string IpAddress;
        private int Port;
        bool SockTrue = false;
        TcpClient SockTcp = new TcpClient();
        NetworkStream stream;
        Thread SocketChecker;
        Thread SocketReader;
        Thread IRSensorReader;
        byte[] Trame = {0xff, 0x07, 0x00, 0x0, 0x00, 0x0,0xF0,0x00,0x00};

        public GUICommande()
        {
            Port = 0;
            IpAddress = "";
            InitializeComponent();
            progressBarLeft.Maximum = 255;
            progressBarRight.Maximum = 255;
            numericUpDownLeft.Maximum = 255;
            numericUpDownRight.Maximum = 255;
            toolStripStatusLabel1.Text = "Disconnected";
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            progressBarRight.Value = (int)numericUpDownRight.Value;
            Trame[5] = byte.Parse(numericUpDownLeft.Value.ToString());
            byte[] buffer = BitConverter.GetBytes(CRC16(Trame, 0, 6));
            Trame[7] = buffer[0];
            Trame[8] = buffer[1];
            stream.Write(Trame,0,9);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBarLeft.Value = (int)numericUpDownLeft.Value;
            Trame[3] = byte.Parse(numericUpDownLeft.Value.ToString());
            byte[] buffer = BitConverter.GetBytes(CRC16(Trame, 0, 6));
            Trame[7] = buffer[0];
            Trame[8] = buffer[1];
            stream.Write(Trame,0,9);
            SocketReader = new Thread(new ThreadStart(Thread_SockReader));
            SocketReader.Start();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection View = new Connection(this);
            View.ShowDialog();
            if (SockTrue)
            {
                try
                {
                    SockTcp.Connect(IpAddress, Port);
                    stream = SockTcp.GetStream();
                    toolStripStatusLabel1.ForeColor = Color.Green;
                    toolStripStatusLabel1.Text = "Connected";

                    SocketChecker = new Thread(new ThreadStart(Thread_SockCheker));
                    SocketChecker.Start();
                    IRSensorReader = new Thread(new ThreadStart(Thread_IRSensorReader));
                    IRSensorReader.Start();
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

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SockTcp.Connected)
            {
                SocketChecker.Abort();
                toolStripStatusLabel1.Text = "Disconnected";
                SocketReader.Abort();
                IRSensorReader.Abort();
                SockTcp.Close();
                stream.Close();
            }
            this.Close();
        }
        public void SetIpAddressPort(string TIpAddress, int TPort)
        {
            SockTrue = true;
            IpAddress = TIpAddress;
            Port = TPort;
        }
        private void Thread_SockCheker()
        {
            if (!SockTcp.Connected)
            {
                toolStripStatusLabel1.Text = "Disconnected";
                MessageBox.Show("Connexion Perdu " ,"Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SocketReader.Abort();
                IRSensorReader.Abort();
                SockTcp.Close();
                stream.Close();
            }
        }
        private UInt16 CRC16(byte[] Trame, byte Begin, byte Size)
        {
            UInt16 Crc = 0xFFFF;
            UInt16 Polynome = 0xA001;
            UInt16 CptOctet = 0;
            UInt16 CptBit = 0;
            UInt16 Parity = 0;
            Crc = 0xFFFF;
            Polynome = 0xA001;
            for ( CptOctet= Begin ; CptOctet < (Begin+Size) ; CptOctet++)
            {
                Crc ^= Trame[CptOctet];
                for ( CptBit = 0; CptBit <= 7 ; CptBit++)
                {
                    Parity= Crc;
                    Crc >>= 1;
                    if ((Parity%2) == 1) 
                        Crc ^= Polynome;
                }
            }
            return (Crc); 
        }
        private void Thread_SockReader()
        {
            byte[] sbuf = new byte[30];
            stream.Read(sbuf, 0, 21);
            BatVoltage = sbuf[2];
            IRTopLeft = sbuf[3];
            IRBotLeft = sbuf[4];
            IRTopRight = sbuf[11];
            IRBotRight = sbuf[12];
        }
        private void Thread_IRSensorReader()
        {
            progBarIRBotLeft.Value = IRBotLeft;
            progBarIRTopLeft.Value = IRTopLeft;
            progBarIRBotRight.Value = IRBotRight;
            progBarIRTopRight.Value = IRTopRight;
        }
    }
}
