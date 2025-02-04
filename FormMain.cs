using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using System.Globalization;


namespace WindowsFormsACC
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPack_Click(object sender, EventArgs e)
        {
            byte[] src = ASCIIEncoding.UTF8.GetBytes(richTextBoxSRC_P.Text.ToCharArray());
            byte[] cod = ACC.Compress(src);

            for (int i = 0; i < cod.Length; i++)
            {
                richTextBoxRES_P.Text += string.Format("{0:X2}", cod[i]);
            }

            textBoxSIZESRC_P.Text = src.Length.ToString(); 
            labelSIZCOD_P.Text = cod.Length.ToString();
        }

        private void buttonUnPack_Click(object sender, EventArgs e)
        {
            int lenCode=richTextBoxCOD_U.Text.Length/2;
            byte[] cod = new byte[lenCode];

            for (int i = 0; i < lenCode; i++)
            {
                string t=richTextBoxCOD_U.Text[2 * i].ToString() + richTextBoxCOD_U.Text[2 * i + 1].ToString();
                cod[i] = (byte)int.Parse(t, NumberStyles.HexNumber);
            }

            int lenSrc=int.Parse(textBoxSIZE_U.Text);
            byte[] src = ACC.DeCompress(cod, lenSrc);
            richTextBoxRES_U.Text = ASCIIEncoding.UTF8.GetString(src);
        }
    }
}
