using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymulatorRS232
{
    public partial class NadajnikForm : Form
    {

        private bool[][] lancuch;
        OdbiornikForm odbiornik = new OdbiornikForm();


        public NadajnikForm()
        {
            InitializeComponent();
            
            odbiornik.Show();
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            lancuch = ObslugaTekstu.lancuchNaSlowaBinarne(ASCIITextBox.Text); 
            binaryTextBox.Text = ObslugaTekstu.numberToText(lancuch);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            odbiornik.lancuch = lancuch;
            odbiornik.binaryTextBox.Text = ObslugaTekstu.numberToText(odbiornik.lancuch);
        }

        private void ASCIITextBox_TextChanged(object sender, EventArgs e)
        {
            if(ASCIITextBox.Text.Equals("")) ConvertButton.Enabled = false;
            else ConvertButton.Enabled = true;
        }

        private void binaryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (binaryTextBox.Text.Equals("")) SendButton.Enabled = false;
            else SendButton.Enabled = true;
        }
    }
}
