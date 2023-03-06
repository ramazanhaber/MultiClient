using SuperSimpleTcp;
using System;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }

        SimpleTcpServer server = new SimpleTcpServer("127.0.0.1:9000");


        private void FormServer_Load(object sender, EventArgs e)
        {
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
            server.Events.DataReceived += DataReceived;
            server.Start();
            server.Send("[ClientIp:Port]", "Hello, world!");
        }

        void ClientConnected(object sender, ConnectionEventArgs e)
        {
            string mesaj = $"[{e.IpPort}] client connected";
            Console.WriteLine(mesaj);

            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = textBox1.Text + System.Environment.NewLine + mesaj;
            }));
        }

        void ClientDisconnected(object sender, ConnectionEventArgs e)
        {
            string mesaj = $"[{e.IpPort}] client disconnected: {e.Reason}";
            Console.WriteLine(mesaj);

            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = textBox1.Text + System.Environment.NewLine + mesaj;
            }));

        }

        void DataReceived(object sender, DataReceivedEventArgs e)
        {
            string mesaj = $"[{e.IpPort}]: {Encoding.UTF8.GetString(e.Data.Array, 0, e.Data.Count)}";
            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = textBox1.Text + System.Environment.NewLine + mesaj;

                server.Send(e.IpPort, "serverdan cevap döndü Başarılı");
            }));
        }

        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            string gidicekMesaj=txtGidicekMesaj.Text;
            string gidicekIpPort=txtGidicekIpPort.Text;
            server.Send(gidicekIpPort, gidicekMesaj);

        }
    }
}
