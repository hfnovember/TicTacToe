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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void chooseXButton_Click(object sender, EventArgs e)
        {
            Program.human.setSymbol("X");
            Program.computer.setSymbol("O");
            this.Hide();
            switchForm();
        }

        private void chooseOButton_Click(object sender, EventArgs e)
        {
            Program.computer.setSymbol("X");
            Program.human.setSymbol("O");
            this.Hide();
            switchForm();
        }

        private void switchForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form4)
                {
                    frm.Show();
                    return;
                }//end if
            }//end foreach

            Form4 f2 = new Form4();
            f2.Show();
        }//end startButton_Click()

        private void exitButtonForm2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
