using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

using Enigma;

namespace EnigmaGUI
{
    public partial class frmMain : Form
    {
        private EnigmaMachine machine;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            machine = new EnigmaMachine((uint)nudSlow.Value, (uint)nudMedium.Value, (uint)nudFast.Value);
        }

        private int lastLength = 0;
        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            string text = txtInput.Text;
            string selection = "";
            bool append = false;
            if (text.Length > lastLength)
            {
                selection = text.Substring(lastLength);
                append = true;
            }
            else
                selection = text;
            lastLength = text.Length;

            encode(selection, append);
        }

        private void encode(string text, bool append)
        {
            setRotors();
            string result = machine.ProcessString(text);
            if (append)
                txtOutput.Text += result;
            else
                txtOutput.Text = result;
            updateRotors();
        }

        private void updateRotors()
        {
            nudSlow.Value = (decimal)machine.SlowRotor;
            nudMedium.Value = (decimal)machine.MediumRotor;
            nudFast.Value = (decimal)machine.FastRotor;
        }

        private void setRotors()
        {
            machine.SlowRotor = (uint)nudSlow.Value;
            machine.MediumRotor = (uint)nudMedium.Value;
            machine.FastRotor = (uint)nudFast.Value;
        }
    }
}
