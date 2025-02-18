using System.Net;
using System.Net.Sockets;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        TcpClient tcpClient;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ipa;
            int port;

            try
            {
                if (string.IsNullOrEmpty(tbServerIP.Text) || string.IsNullOrEmpty(tbServerPortNo.Text)) return;

                if (!IPAddress.TryParse(tbServerIP.Text, out ipa))
                {
                    MessageBox.Show("Please Enter a valid IP address.");
                    return;
                }

                if (!int.TryParse(tbServerPortNo.Text, out port))
                    port = 23000;

                tcpClient = new();
                tcpClient.BeginConnect(ipa, port, onCompleteConnect, tcpClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);    
            }
        }

        private void onCompleteConnect(IAsyncResult iar)
        {
            TcpClient client;

            try
            {
                client = iar.AsyncState as TcpClient;
                client.EndConnect(iar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
