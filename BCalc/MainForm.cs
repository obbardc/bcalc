using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BCalc
{
    /// <summary>
    /// BCalc
    /// Kerry D. Wong, 2010
    /// http://www.kerrywong.com
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Int32 num1 = BitSettingControl1.DecNumber;
            Int32 num2 = BitSettingControl2.DecNumber;
            Int32 num3 = 0;

            if (RdoAnd.Checked) 
            {
                num3 = num1 & num2;
            }
            else if (RdoOr.Checked)
            {
                num3 = num1 | num2;
            }
            else if (RdoXor.Checked)
            {
                num3 = num1 ^ num2;
            }
            else if (RdoPlus.Checked)
            {
                num3 = num1 + num2;
            }
            else if (RdoMinus.Checked)
            {
                num3 = num1 - num2;
            }
            else if (RdoMult.Checked)
            {
                num3 = num1 * num2;
            }
            else if (RdoDiv.Checked)
            {
                num3 = num1 / num2;
            }

            BitSettingControl3.DecNumber = num3;
        }

        private void FileExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditClearAllMenuItem_Click(object sender, EventArgs e)
        {
            BitSettingControl1.Clear();
            BitSettingControl2.Clear();
            BitSettingControl3.Clear();
        }

        private void HelpAboutMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxForm frm = new AboutBoxForm();
            frm.ShowDialog(this);
        }


    }
}