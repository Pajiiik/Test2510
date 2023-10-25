using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2510
{
    public partial class Nacist : Form
    {
        public Nacist()
        {
            InitializeComponent();
        }

        public Nacist(string text)
        {
            try
            {
                label1.Text = text;
            }
            catch
            {
                MessageBox.Show("Chyba");
            }
        }
        private void Nacist_Load(object sender, EventArgs e)
        {

        }
    }
}
