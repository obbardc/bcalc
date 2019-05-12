using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace BCalc
{
    /// <summary>
    /// BCalc
    /// Kerry D. Wong, 2010
    /// http://www.kerrywong.com
    /// </summary>
    public partial class BitSettingControl : UserControl
    {
        public Int32 DecNumber
        {
            get {
                Int32 num = 0;
                Int32.TryParse(TxtDec.Text, out num);

                return num; 
            }
            set { 
                TxtDec.Text = value.ToString();
                TxtDec_Leave(null, null);
            }
        }

        public BitSettingControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            TxtDec.Text = "0";
            TxtDec_Leave(this, null);
        }

        private void TxtDec_Leave(object sender, EventArgs e)
        {
            Int32 v = 0;
            Int32.TryParse(TxtDec.Text, out v);

            TxtHex.Text = Convert.ToString(v, 16).ToUpper();
            TxtBin.Text = Convert.ToString(v, 2).ToUpper();
            UpdateCheckBoxes(TxtBin.Text);
        }

        private void TxtHex_Leave(object sender, EventArgs e)
        {
            Int32 v = 0;

            Int32.TryParse(TxtHex.Text, System.Globalization.NumberStyles.HexNumber, null, out v);

            TxtDec.Text = v.ToString();
            TxtBin.Text = Convert.ToString(v, 2).ToUpper();
            UpdateCheckBoxes(TxtBin.Text);
        }

        private void TxtBin_Leave(object sender, EventArgs e)
        {
            Int32 v = 0;

            try
            {
                v = Convert.ToInt32(TxtBin.Text, 2);
            }
            catch { }

            TxtDec.Text = v.ToString();
            TxtHex.Text = Convert.ToString(v, 16).ToUpper();
            UpdateCheckBoxes(TxtBin.Text);
        }

        private void CB_CheckedChanged(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int bit;

            bit = CB31.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB30.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB29.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB28.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB27.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB26.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB25.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB24.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB23.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB22.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB21.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB20.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB19.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB18.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB17.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB16.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB15.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB14.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB13.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB12.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB11.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB10.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB9.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB8.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB7.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB6.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB5.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB4.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB3.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB2.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB1.Checked ? 1 : 0; sb.Append(bit.ToString());
            bit = CB0.Checked ? 1 : 0; sb.Append(bit.ToString());

            Int32 v = 0;

            try
            {
                v = Convert.ToInt32(sb.ToString(), 2);
            }
            catch { }

            TxtDec.Text = v.ToString();
            TxtHex.Text = Convert.ToString(v, 16).ToUpper();
            TxtBin.Text = Convert.ToString(v, 2).ToUpper();
        }

        private void UpdateCheckBoxes(string binIn)
        {
            StringBuilder sb = new StringBuilder();
            string bin = string.Empty;

            for (int i = binIn.Length - 1; i >= 0; i--)
            {
                sb.Append(binIn[i]);
            }

            bin = sb.ToString();

            if (bin.Length >= 32) CB31.Checked = bin[31] == '1'; else CB31.Checked = false;
            if (bin.Length >= 31) CB30.Checked = bin[30] == '1'; else CB30.Checked = false;
            if (bin.Length >= 30) CB29.Checked = bin[29] == '1'; else CB29.Checked = false;
            if (bin.Length >= 29) CB28.Checked = bin[28] == '1'; else CB28.Checked = false;
            if (bin.Length >= 28) CB27.Checked = bin[27] == '1'; else CB27.Checked = false;
            if (bin.Length >= 27) CB26.Checked = bin[26] == '1'; else CB26.Checked = false;
            if (bin.Length >= 26) CB25.Checked = bin[25] == '1'; else CB25.Checked = false;
            if (bin.Length >= 25) CB24.Checked = bin[24] == '1'; else CB24.Checked = false;
            if (bin.Length >= 24) CB23.Checked = bin[23] == '1'; else CB23.Checked = false;
            if (bin.Length >= 23) CB22.Checked = bin[22] == '1'; else CB22.Checked = false;
            if (bin.Length >= 22) CB21.Checked = bin[21] == '1'; else CB21.Checked = false;
            if (bin.Length >= 21) CB20.Checked = bin[20] == '1'; else CB20.Checked = false;
            if (bin.Length >= 20) CB19.Checked = bin[19] == '1'; else CB19.Checked = false;
            if (bin.Length >= 19) CB18.Checked = bin[18] == '1'; else CB18.Checked = false;
            if (bin.Length >= 18) CB17.Checked = bin[17] == '1'; else CB17.Checked = false;
            if (bin.Length >= 17) CB16.Checked = bin[16] == '1'; else CB16.Checked = false;
            if (bin.Length >= 16) CB15.Checked = bin[15] == '1'; else CB15.Checked = false;
            if (bin.Length >= 15) CB14.Checked = bin[14] == '1'; else CB14.Checked = false;
            if (bin.Length >= 14) CB13.Checked = bin[13] == '1'; else CB13.Checked = false;
            if (bin.Length >= 13) CB12.Checked = bin[12] == '1'; else CB12.Checked = false;
            if (bin.Length >= 12) CB11.Checked = bin[11] == '1'; else CB11.Checked = false;
            if (bin.Length >= 11) CB10.Checked = bin[10] == '1'; else CB10.Checked = false;
            if (bin.Length >= 10) CB9.Checked = bin[9] == '1'; else CB9.Checked = false;
            if (bin.Length >= 9) CB8.Checked = bin[8] == '1'; else CB8.Checked = false;
            if (bin.Length >= 8) CB7.Checked = bin[7] == '1'; else CB7.Checked = false;
            if (bin.Length >= 7) CB6.Checked = bin[6] == '1'; else CB6.Checked = false;
            if (bin.Length >= 6) CB5.Checked = bin[5] == '1'; else CB5.Checked = false;
            if (bin.Length >= 5) CB4.Checked = bin[4] == '1'; else CB4.Checked = false;
            if (bin.Length >= 4) CB3.Checked = bin[3] == '1'; else CB3.Checked = false;
            if (bin.Length >= 3) CB2.Checked = bin[2] == '1'; else CB2.Checked = false;
            if (bin.Length >= 2) CB1.Checked = bin[1] == '1'; else CB1.Checked = false;
            if (bin.Length >= 1) CB0.Checked = bin[0] == '1'; else CB0.Checked = false;
        }

        private void BtnShiftLeft_Click(object sender, EventArgs e)
        {
            Int32 n = 0;

            Int32.TryParse(TxtDec.Text, out n);
            n = n << 1;

            TxtDec.Text = n.ToString();
            TxtHex.Text = Convert.ToString(n, 16).ToUpper();
            TxtBin.Text = Convert.ToString(n, 2).ToUpper();
            UpdateCheckBoxes(TxtBin.Text);
        }

        private void BtnShiftRight_Click(object sender, EventArgs e)
        {
            Int32 n = 0;

            Int32.TryParse(TxtDec.Text, out n);
            n = n >> 1;

            TxtDec.Text = n.ToString();
            TxtHex.Text = Convert.ToString(n, 16).ToUpper();
            TxtBin.Text = Convert.ToString(n, 2).ToUpper();
            UpdateCheckBoxes(TxtBin.Text);
        }

        private void BtnNot_Click(object sender, EventArgs e)
        {
            Int32 n = 0;

            Int32.TryParse(TxtDec.Text, out n);
            n = ~n;

            TxtDec.Text = n.ToString();
            TxtHex.Text = Convert.ToString(n, 16).ToUpper();
            TxtBin.Text = Convert.ToString(n, 2).ToUpper();
            UpdateCheckBoxes(TxtBin.Text);
        }
    }
}
