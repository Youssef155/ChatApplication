using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    public partial class ServerForm : Form
    {
        TcpListener listener;
        TcpClient tcpClient;
        byte[] buffer;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress;
            int port;

            if (!int.TryParse(tbPortNumber.Text, out port))
                port = 23000;

            if (!IPAddress.TryParse(tbIPAddress.Text, out ipAddress))
            {
                MessageBox.Show("Invalid IP Address!");
                return;
            }

            listener = new TcpListener(ipAddress, port);
            listener.Start();

            listener.BeginAcceptTcpClient(onCompleteAcceptTcpClient, listener);
        }

        private void onCompleteAcceptTcpClient(IAsyncResult iar)
        {
            TcpListener tcp = (TcpListener)iar.AsyncState;
            try
            {
                tcpClient = tcp.EndAcceptTcpClient(iar);
                printLine("Client connected...");
                buffer = new byte[512];
                tcpClient.GetStream().BeginRead(buffer, 0, buffer.Length, onCompleteReadFromTcpClientStream, tcpClient);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onCompleteReadFromTcpClientStream(IAsyncResult iar)
        {
            TcpClient client;
            int readByteCount = 0;
            string strRecv;

            try
            {
                client = (TcpClient)iar.AsyncState;
                readByteCount = client.GetStream().EndRead(iar);

                if (readByteCount == 0)
                {
                    MessageBox.Show("Client disconnected");
                    return;
                }

                strRecv = Encoding.ASCII.GetString(buffer, 0, readByteCount);
                printLine(strRecv);

                buffer = new byte[512];
                client.GetStream().BeginRead(buffer, 0, buffer.Length, onCompleteReadFromTcpClientStream, client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void printLine(string strLine)
        {
            tbConsoleOutput.Invoke(new Action<string>(doInvoke), strLine);
        }

        public void doInvoke(string strLine)
        {
            tbConsoleOutput.Text = strLine + Environment.NewLine + tbConsoleOutput.Text;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] tx = new byte[512];

            if (string.IsNullOrEmpty(tbMsg.Text)) return;

            try
            {
                if (tcpClient != null)
                {
                    if (tcpClient.Client.Connected)
                    {
                        tx = Encoding.ASCII.GetBytes(tbMsg.Text);
                        tcpClient.GetStream().BeginWrite(tx, 0, tx.Length, onCompleteWriteToClientStream, tcpClient);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void onCompleteWriteToClientStream(IAsyncResult iar)
        {
            try
            {
                TcpClient client = iar.AsyncState as TcpClient;
                client.GetStream().EndWrite(iar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
