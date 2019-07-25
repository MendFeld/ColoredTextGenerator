using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextColorGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color _color = Color.Blue;
        bool _first;
        private void BtnSend_Click(object sender, EventArgs e)
        {
            rtfResult.SelectionColor = _color;
            if (_first)
                rtfResult.SelectedText = txtValue.Text;
            else
                rtfResult.SelectedText = Environment.NewLine + txtValue.Text;
            _first = false;
            txtValue.Clear();
            txtValue.Focus();
                    
        }

        private void PColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialog1.Color;
                pColor.BackColor = _color;
            }
        }
    }
}
