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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            Program.isHard = false;
            this.Hide();
            switchForm();
        }

        private void switchForm()
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form3)
                {
                    frm.Show();
                    return;
                }//end if
            }//end foreach

            Form3 f2 = new Form3();
            f2.Show();
        }//end startButton_Click()

        private void hardButton_Click(object sender, EventArgs e)
        {
            Program.isHard = true;
            this.Hide();
            switchForm();
        }
    }
}
