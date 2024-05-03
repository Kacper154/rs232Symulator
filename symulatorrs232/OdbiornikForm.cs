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

namespace SymulatorRS232
{
    public partial class OdbiornikForm : Form
    {
        public bool[][] lancuch;
        public string[] zakazaneSlowa;

        public OdbiornikForm()
        {
            InitializeComponent();
        }

        private void OdbiornikForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            string buff = ObslugaTekstu.slowaBinarneNaLancuch(lancuch);


            if (censorCheckBox.Checked) buff = ObslugaTekstu.cenzuruj(buff, zakazaneSlowa);
            
                ASCIITextBox.Text = buff;
        }

        private void binaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (binaryTextBox.Text.Equals(""))
            {
                ConvertButton.Enabled = false;
                censorCheckBox.Enabled = false;
            }
            else
            {
                ConvertButton.Enabled = true;
                censorCheckBox.Enabled = true;
            }


        }

        private void ASCIITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void censorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (censorCheckBox.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    StreamReader f1 = new StreamReader(openFileDialog1.FileName);
                    int liczbaLinii = ObslugaTekstu.policzLiczbeLinii(f1);
                    f1.Close();
                    //dwa stream readery bo inaczej pobierał kolejne linie zamiast od nowa
                    StreamReader f2 = new StreamReader(openFileDialog1.FileName);
                    zakazaneSlowa = ObslugaTekstu.plikDoTablicy(f2, liczbaLinii);
                    f2.Close();
                }
            }
        }
    }
}
