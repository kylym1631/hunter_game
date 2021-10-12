using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coders_Project_2
{
    public partial class labelDescr : Form
    {

        public labelDescr()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            if (textBoxName.Text != "")
            {
                this.Hide();
                Hunter f2 = new Hunter(userName);
                f2.ShowDialog();
                this.Close();
            }

        }
        
        public void textBoxName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labelDescr_Load(object sender, EventArgs e)
        {

        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue== (char)Keys.Enter)
            {
                buttonPlay.PerformClick();
            }
        }
    }
   
}
