using System.Net;
using System.Net.Sockets;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress;
            int port;

            if (!int.TryParse(tbPortNumber.Text, out port))
                port = 23000;

            if(!IPAddress.TryParse(tbIPAddress.Text, out ipAddress))
            {
                MessageBox.Show("Invalid IP Address!");
                return;
            }

            listener = new TcpListener(ipAddress, port);
            listener.Start();
        }
    }
}
