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
            Main.SetIpAddressPort(textBoxIpAdress.Text, int.Parse(textBoxPort.Text));
            this.Close();
        }
    }
}
