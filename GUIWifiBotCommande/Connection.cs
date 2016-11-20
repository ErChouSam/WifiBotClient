using System;
using System.Windows.Forms;
using System.Net.Sockets;

namespace GUIWifiBotCommande
{
    public partial class Connection : Form
    {
        GUICommande Main;
        public Connection(GUICommande CGuiCommande)
        {
            InitializeComponent();
            Main = CGuiCommande;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //TcpClient SockTCP = new TcpClient(textBoxIpAdress.Text, int.Parse(textBoxPort.Text));
              //  SockTCP.Close();
                Main.SetIpAddressPort(textBoxIpAdress.Text, int.Parse(textBoxPort.Text));
                this.Close();
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
}
