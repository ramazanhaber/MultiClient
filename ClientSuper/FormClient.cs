using SuperSimpleTcp;
using System;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            string text = $"*** Server {e.IpPort} connected";

            Console.WriteLine(text);
            this.Invoke(new MethodInvoker(() =>
            {
                txtCevap.Text = txtCevap.Text + System.Environment.NewLine + text;
            }));
        }

         void Disconnected(object sender, ConnectionEventArgs e)
        {
            string text = $"*** Server {e.IpPort} disconnected";

            Console.WriteLine(text);
            this.Invoke(new MethodInvoker(() =>
            {
                txtCevap.Text = txtCevap.Text + System.Environment.NewLine + text;
            }));
        }

         void DataReceived(object sender, DataReceivedEventArgs e)
        {
            string text = $"[{e.IpPort}] {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)} **";
            Console.WriteLine(text);
            this.Invoke(new MethodInvoker(() =>
            {
                txtCevap.Text = txtCevap.Text + System.Environment.NewLine + text;
            }));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Connect();
            client.Send(textBox1.Text);
        }
    }
}
