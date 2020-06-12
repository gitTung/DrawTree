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
    public partial class Form1 : Form
    {
        private double _degree1;
        private double _degree2;

        private Graphics graphics;
        private int Layers { get; set; }     //递归层数
        const double PI = Math.PI;
        private double Degree1
        {
            get
            {
                return _degree1;
            }
            set
            {
                _degree1 = value * Math.PI / 180;
            }
        }
        private double Degree2
        {
            get
            {
                return _degree2;
            }
            set
            {
                _degree2 = value * Math.PI / 180;
            }
        }
        private double Length { get; set; }
        private double Loc_k { get; set; }  //位置系数k(0.2~1.0)
        private Color TreeColor { get; set; }
        private double BranchWidth { get; set; }

        double per1 = 0.6;  //子树1与母树的长度系数
        double per2 = 0.7;  //子树2与母树的长度系数

        private Form1()
        {
            InitializeComponent();
            //this.AutoScaleBaseSize = new Size(6, 14);
            //this.ClientSize = new Size(600, 400);
            this.Paint += new PaintEventHandler(this.Form1_Paint);
        }

        public Form1(int layers, double degree1, double degree2,
            double length, double per1, double per2, double loc_k,
            Color color, double width) : this()
        {
            Layers = layers;
            Degree1 = degree1;
            Degree2 = degree2;
            Length = length;
            this.per1 = per1;
            this.per2 = per2;
            Loc_k = loc_k >= 0 ? (1 - loc_k) : (-loc_k - 1);
            TreeColor = color;
            BranchWidth = width;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            drawTree(Layers, 400, 600, Length, -PI / 2);
        }

        //n递归层数；x0,y0生长点；leng树长度；角度
        void drawTree(int n, double x0, double y0, double leng, double degree)
        {
            if (n == 0) return;
            double x1, y1, x2, y2;
            if(Loc_k > 0)
            {
                x1 = x0 + leng * Math.Cos(degree);
                y1 = y0 + leng * Math.Sin(degree);
                x2 = x0 + leng * Math.Cos(degree) * Loc_k;
                y2 = y0 + leng * Math.Sin(degree) * Loc_k;
                drawLine(x0, y0, x1, y1, (int)(BranchWidth * n / Layers));
            }
            else
            {
                x1 = x0 - leng * Math.Cos(degree) * Loc_k;
                y1 = y0 - leng * Math.Sin(degree) * Loc_k;
                x2 = x0 + leng * Math.Cos(degree);
                y2 = y0 + leng * Math.Sin(degree);
                drawLine(x0, y0, x2, y2, (int)(BranchWidth * n / Layers));
            }

            drawTree(n - 1, x1, y1, per1 * leng, degree + Degree1);
            drawTree(n - 1, x2, y2, per2 * leng, degree - Degree2);
        }

        void drawLine(double x0, double y0, double x1, double y1, int width)
        {
            graphics.DrawLine(new Pen(TreeColor, width), (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
