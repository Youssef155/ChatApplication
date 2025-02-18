using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPClient
{
    public partial class ClientForm : Form
    {
        TcpClient tcpClient;
        byte[] buffer;

        public ClientForm()
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
                btnConnect.Enabled = false;
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
                buffer = new byte[512];
                client.GetStream().BeginRead(buffer, 0, buffer.Length, onCompleteReadFromServerStream, client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onCompleteReadFromServerStream(IAsyncResult iar)
        {
            TcpClient client;
            string strRecived;
            int bytesRecivedFromServer = 0;

            try
            {
                client = iar.AsyncState as TcpClient;
                bytesRecivedFromServer = client.GetStream().EndRead(iar);

                if(bytesRecivedFromServer == 0)
                {
                    MessageBox.Show("Connection is broken!");
                    return;
                }

                strRecived = Encoding.ASCII.GetString(buffer, 0, bytesRecivedFromServer);

                printLine(strRecived);

                buffer = new byte[512];
                client.GetStream().BeginRead(buffer, 0, buffer.Length, onCompleteReadFromServerStream, client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printLine(string strRecived)
        {
            tbConsoleOutput.Invoke(new Action<string>(doInvke),  strRecived);
        }

        private void doInvke(string obj)
        {
            tbConsoleOutput.Text = obj + Environment.NewLine;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] data;

            if(string.IsNullOrEmpty(tbMsg.Text)) return;

            try
            {
                data = Encoding.ASCII.GetBytes(tbMsg.Text);

                if (tcpClient != null)
                {
                    if(tcpClient.Client.Connected)
                    {
                        tcpClient.GetStream().BeginWrite(data, 0, data.Length, onCompleteWriteToServer, tcpClient);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onCompleteWriteToServer(IAsyncResult iar)
        {
            TcpClient client;

            try
            {
                client = iar.AsyncState as TcpClient;
                client.GetStream().EndWrite(iar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
