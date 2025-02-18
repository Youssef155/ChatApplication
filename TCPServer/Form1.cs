using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient tcpClient;
        byte[] buffer;

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

        private void onCompleteReadFromTcpClientStream(IAsyncResult ar)
        {
            TcpClient client;
            int readByteCount = 0;
            string strRecv;

            try
            {
                client = (TcpClient)ar.AsyncState;
                readByteCount = client.GetStream().EndRead(ar);

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
    }
}
