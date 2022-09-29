using SuperSimpleTcp;
using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server = new SimpleTcpServer("127.0.0.1:9000");

        private void Form1_Load(object sender, EventArgs e)
        {
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
            server.Start();
            server.Send("[ClientIp:Port]", "Hello, world!");
        }

        void ClientConnected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"[{e.IpPort}] client connected");
        }

        void ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"[{e.IpPort}] client disconnected: {e.Reason}");
        }

        void DataReceived(object sender, DataReceivedEventArgs e)
        {
            string mesaj = $"[{e.IpPort}]: {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}";
            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = textBox1.Text + "\n" + mesaj;
            }));
        }

    }
}
