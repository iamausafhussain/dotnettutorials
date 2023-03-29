using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingConcept
{
    public partial class Form1 : Form
    {
        private int CountChar()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("D:\\Data.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
                Thread.Sleep(8000);
            }
            return count;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountChar);
            task.Start();
            label1.Text = "Processing File. Please Wait";
            int count = await task; //CountChar();
            label1.Text = count.ToString() + " Characters in file";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
