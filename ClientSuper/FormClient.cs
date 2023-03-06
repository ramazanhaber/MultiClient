using SuperSimpleTcp;
using System;
using System.Text;
using System.Windows.Forms;

namespace ClientSuper
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        SimpleTcpClient client = new SimpleTcpClient("127.0.0.1:9000");
        private void FormClient_Load(object sender, EventArgs e)
        {
            client.Events.Connected += Connected;
            client.Events.Disconnected += Disconnected;
            client.Events.DataReceived += DataReceived;
        }

         void Connected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"*** Server {e.IpPort} connected");
        }

         void Disconnected(object sender, ConnectionEventArgs e)
        {
            Console.WriteLine($"*** Server {e.IpPort} disconnected");
        }

         void DataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine($"[{e.IpPort}] {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)} **");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Connect();
            client.Send(textBox1.Text);
        }
    }
}
