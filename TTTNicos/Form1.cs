using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTTNicos
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }//end Form1()

        private void startButton_Click(object sender, EventArgs e) {
            this.Hide();
            foreach (Form frm in Application.OpenForms) {
                if (frm is Form2) {
                    frm.Show();
                    return;
                }//end if
            }//end foreach

            Form2 f2 = new Form2();
            f2.Show();
        }//end startButton_Click()

        private void exitButtonForm1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }//end Form1
}//end TTTNicos
