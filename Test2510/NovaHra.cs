using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2510
{
    public partial class NovaHra : Form
    {
        public NovaHra()
        {
            InitializeComponent();
        }
        public string jmeno;
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                jmeno = textBox1.Text;
                Ulozit ulozit = new Ulozit(jmeno);
                ulozit.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Zadejte jméno prosím");
            }
        }
    }
}
