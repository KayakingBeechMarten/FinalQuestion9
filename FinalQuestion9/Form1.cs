using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalQuestion9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            band5.BackColor = Color.NavajoWhite;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            band5.BackColor = Color.DimGray;
        }

        private void band1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                band1.BackColor = colorDialog1.Color;
        }

        private void band2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
                band2.BackColor = colorDialog2.Color;
        }

        private void band3_Click(object sender, EventArgs e)
        {
            if (colorDialog3.ShowDialog() == DialogResult.OK)
                band3.BackColor = colorDialog3.Color;
        }

        private void band4_Click(object sender, EventArgs e)
        {
            if (colorDialog4.ShowDialog() == DialogResult.OK)
                band4.BackColor = colorDialog4.Color;
        }

        private void band5_Click(object sender, EventArgs e)
        {
            if (colorDialog5.ShowDialog() == DialogResult.OK)
                band5.BackColor = colorDialog5.Color;
        }
    }
}
