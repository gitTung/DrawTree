using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawTree
{
    public partial class OptionForm : Form
    {
        private Color treeColor;
        private double Loc_k
        {
            get
            {
                double k = barLoc.Value;
                if (k <= 10)
                    return k/10.0;
                else
                {
                    return 10.0 / (20 - k);
                }
            }
        }

        public OptionForm()
        {
            InitializeComponent();
            panelColor.BackColor = treeColor = Color.Black;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
             treeColor = Color.Black;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            new Form1(barLayer.Value,
                barDegree1.Value,barDegree2.
                Value,barLength.Value, 
                barPer1.Value / 100.0, barPer2.Value / 100.0,
                barLoc.Value / 10.0, 
                treeColor,barWidth.Value).Visible = true;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = this.treeColor = color.Color;
            }
        }

        private void btnColorRnd_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            panelColor.BackColor = treeColor = Color.FromArgb(rdn.Next(256), rdn.Next(256), rdn.Next(256));
        }

        private void barDegree1_Scroll(object sender, EventArgs e)
        {
            lblDegree1.Text = barDegree1.Value + "度";
        }

        private void barDegree2_Scroll(object sender, EventArgs e)
        {
            lblDegree2.Text = barDegree2.Value + "度";
        }

        private void barLength_Scroll(object sender, EventArgs e)
        {
            lblLength.Text = barLength.Value + "像素";
        }

        private void barWidth_Scroll(object sender, EventArgs e)
        {
            lblWidth.Text = barWidth.Value + "像素";
        }

        private void barLayer_Scroll(object sender, EventArgs e)
        {
            lblLayer.Text = barLayer.Value.ToString();
        }

        private void barLoc_Scroll(object sender, EventArgs e)
        {
            lblLoc.Text = (barLoc.Value / 10.0).ToString();
        }

        private void barPer1_Scroll(object sender, EventArgs e)
        {
            lblPer1.Text = (barPer1.Value / 100.0).ToString();
        }

        private void barPer2_Scroll(object sender, EventArgs e)
        {
            lblPer2.Text = (barPer2.Value / 100.0).ToString();
        }

        private void btnDrawRdn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            new Form1(10, rnd.Next(20,80), rnd.Next(20,80),
                rnd.Next(100, 150), rnd.Next(5, 10) / 10.0, rnd.Next(5, 10) / 10.0, 
                rnd.Next(-4,4) / 10.0,
                Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256)),
                rnd.Next(6, 10)).Visible = true;
        }
    }
}
