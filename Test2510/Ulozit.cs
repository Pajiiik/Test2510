using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.DirectoryServices.ActiveDirectory;

namespace Test2510
{
    public partial class Ulozit : NovaHra
    {
        public Ulozit()
        {
            InitializeComponent();
        }
        public Ulozit(string jmeno)
        {
            try
            {

                this.Visible = false;
                using (StreamWriter sw = new StreamWriter("saves.txt", true))
                { 
                sw.WriteLine(jmeno + "   " + DateTime.Now.ToString() + "# \n");
                sw.Close();
                }

            }
            catch
            {

                MessageBox.Show("Něco se nepovedlo :(");

            }

            MessageBox.Show("Byla vytvořenanová hra");

        }
        private void Ulozit_Load(object sender, EventArgs e)
        {

        }
    }
}
