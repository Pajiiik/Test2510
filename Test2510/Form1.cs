using System.DirectoryServices.ActiveDirectory;

namespace Test2510
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ukoncit uk = new Ukoncit();
            uk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaHra nh = new NovaHra();
            nh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = 0;
            string veta= "";
            using (StreamReader sr = new StreamReader("saves.txt"))
            {
                string text = sr.ReadToEnd();
                for (int i = 0; i < (text.Length - 1); i++)
                {
                    veta = veta + text[i];
                    if (text[i] == '#')
                    {
                    Nacist nacist = new Nacist(veta);
                    nacist.Show();
                    }
                }
            }

        }
    }
}