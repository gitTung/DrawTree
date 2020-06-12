namespace DrawTree
{
    partial class OptionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barDegree1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.barDegree2 = new System.Windows.Forms.TrackBar();
            this.barLength = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.btnColorRnd = new System.Windows.Forms.Button();
            this.lblDegree1 = new System.Windows.Forms.Label();
            this.lblDegree2 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.barWidth = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDrawRdn = new System.Windows.Forms.Button();
            this.lblLayer = new System.Windows.Forms.Label();
            this.barLayer = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.barLoc = new System.Windows.Forms.TrackBar();
            this.lblPer1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.barPer1 = new System.Windows.Forms.TrackBar();
            this.lblPer2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.barPer2 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.barDegree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDegree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPer2)).BeginInit();
            this.SuspendLayout();
            // 
            // barDegree1
            // 
            this.barDegree1.Location = new System.Drawing.Point(130, 41);
            this.barDegree1.Maximum = 90;
            this.barDegree1.Name = "barDegree1";
            this.barDegree1.Size = new System.Drawing.Size(399, 56);
            this.barDegree1.TabIndex = 0;
            this.barDegree1.Value = 30;
            this.barDegree1.Scroll += new System.EventHandler(this.barDegree1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(58, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "角度1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "角度2";
            // 
            // barDegree2
            // 
            this.barDegree2.Location = new System.Drawing.Point(130, 103);
            this.barDegree2.Maximum = 90;
            this.barDegree2.Name = "barDegree2";
            this.barDegree2.Size = new System.Drawing.Size(399, 56);
            this.barDegree2.TabIndex = 3;
            this.barDegree2.Value = 35;
            this.barDegree2.Scroll += new System.EventHandler(this.barDegree2_Scroll);
            // 
            // barLength
            // 
            this.barLength.Location = new System.Drawing.Point(130, 221);
            this.barLength.Maximum = 150;
            this.barLength.Minimum = 50;
            this.barLength.Name = "barLength";
            this.barLength.Size = new System.Drawing.Size(399, 56);
            this.barLength.TabIndex = 5;
            this.barLength.Value = 100;
            this.barLength.Scroll += new System.EventHandler(this.barLength_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(21, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "树干高度";
            // 
            // btnDraw
            // 
            this.btnDraw.Font = new System.Drawing.Font("宋体", 15F);
            this.btnDraw.Location = new System.Drawing.Point(159, 490);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(136, 59);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "画树";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("宋体", 15F);
            this.btnColor.Location = new System.Drawing.Point(198, 401);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(153, 55);
            this.btnColor.TabIndex = 7;
            this.btnColor.Text = "选择颜色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(125, 401);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(57, 55);
            this.panelColor.TabIndex = 8;
            this.panelColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColorRnd
            // 
            this.btnColorRnd.Font = new System.Drawing.Font("宋体", 15F);
            this.btnColorRnd.Location = new System.Drawing.Point(376, 401);
            this.btnColorRnd.Name = "btnColorRnd";
            this.btnColorRnd.Size = new System.Drawing.Size(153, 55);
            this.btnColorRnd.TabIndex = 9;
            this.btnColorRnd.Text = "随机颜色";
            this.btnColorRnd.UseVisualStyleBackColor = true;
            this.btnColorRnd.Click += new System.EventHandler(this.btnColorRnd_Click);
            // 
            // lblDegree1
            // 
            this.lblDegree1.AutoSize = true;
            this.lblDegree1.Font = new System.Drawing.Font("宋体", 15F);
            this.lblDegree1.Location = new System.Drawing.Point(531, 41);
            this.lblDegree1.Name = "lblDegree1";
            this.lblDegree1.Size = new System.Drawing.Size(63, 25);
            this.lblDegree1.TabIndex = 10;
            this.lblDegree1.Text = "30度";
            // 
            // lblDegree2
            // 
            this.lblDegree2.AutoSize = true;
            this.lblDegree2.Font = new System.Drawing.Font("宋体", 15F);
            this.lblDegree2.Location = new System.Drawing.Point(531, 103);
            this.lblDegree2.Name = "lblDegree2";
            this.lblDegree2.Size = new System.Drawing.Size(63, 25);
            this.lblDegree2.TabIndex = 11;
            this.lblDegree2.Text = "35度";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("宋体", 15F);
            this.lblLength.Location = new System.Drawing.Point(531, 221);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(101, 25);
            this.lblLength.TabIndex = 12;
            this.lblLength.Text = "100像素";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("宋体", 15F);
            this.lblWidth.Location = new System.Drawing.Point(225, 283);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(75, 25);
            this.lblWidth.TabIndex = 15;
            this.lblWidth.Text = "5像素";
            // 
            // barWidth
            // 
            this.barWidth.Location = new System.Drawing.Point(130, 283);
            this.barWidth.Minimum = 1;
            this.barWidth.Name = "barWidth";
            this.barWidth.Size = new System.Drawing.Size(97, 56);
            this.barWidth.TabIndex = 14;
            this.barWidth.Value = 5;
            this.barWidth.Scroll += new System.EventHandler(this.barWidth_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(21, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "树干粗细";
            // 
            // btnDrawRdn
            // 
            this.btnDrawRdn.Font = new System.Drawing.Font("宋体", 15F);
            this.btnDrawRdn.Location = new System.Drawing.Point(351, 490);
            this.btnDrawRdn.Name = "btnDrawRdn";
            this.btnDrawRdn.Size = new System.Drawing.Size(136, 59);
            this.btnDrawRdn.TabIndex = 16;
            this.btnDrawRdn.Text = "随机生成";
            this.btnDrawRdn.UseVisualStyleBackColor = true;
            this.btnDrawRdn.Click += new System.EventHandler(this.btnDrawRdn_Click);
            // 
            // lblLayer
            // 
            this.lblLayer.AutoSize = true;
            this.lblLayer.Font = new System.Drawing.Font("宋体", 15F);
            this.lblLayer.Location = new System.Drawing.Point(531, 283);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(38, 25);
            this.lblLayer.TabIndex = 19;
            this.lblLayer.Text = "10";
            // 
            // barLayer
            // 
            this.barLayer.Location = new System.Drawing.Point(432, 283);
            this.barLayer.Maximum = 15;
            this.barLayer.Minimum = 2;
            this.barLayer.Name = "barLayer";
            this.barLayer.Size = new System.Drawing.Size(97, 56);
            this.barLayer.TabIndex = 18;
            this.barLayer.Value = 10;
            this.barLayer.Scroll += new System.EventHandler(this.barLayer_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(346, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "茂盛度";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("宋体", 15F);
            this.lblLoc.Location = new System.Drawing.Point(225, 342);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(25, 25);
            this.lblLoc.TabIndex = 22;
            this.lblLoc.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F);
            this.label7.Location = new System.Drawing.Point(21, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "位置系数";
            // 
            // barLoc
            // 
            this.barLoc.Location = new System.Drawing.Point(130, 339);
            this.barLoc.Maximum = 4;
            this.barLoc.Minimum = -4;
            this.barLoc.Name = "barLoc";
            this.barLoc.Size = new System.Drawing.Size(97, 56);
            this.barLoc.TabIndex = 20;
            this.barLoc.Scroll += new System.EventHandler(this.barLoc_Scroll);
            // 
            // lblPer1
            // 
            this.lblPer1.AutoSize = true;
            this.lblPer1.Font = new System.Drawing.Font("宋体", 15F);
            this.lblPer1.Location = new System.Drawing.Point(225, 165);
            this.lblPer1.Name = "lblPer1";
            this.lblPer1.Size = new System.Drawing.Size(51, 25);
            this.lblPer1.TabIndex = 25;
            this.lblPer1.Text = "0.6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F);
            this.label8.Location = new System.Drawing.Point(8, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "长度系数1";
            // 
            // barPer1
            // 
            this.barPer1.Location = new System.Drawing.Point(130, 162);
            this.barPer1.Maximum = 80;
            this.barPer1.Minimum = 50;
            this.barPer1.Name = "barPer1";
            this.barPer1.Size = new System.Drawing.Size(97, 56);
            this.barPer1.SmallChange = 5;
            this.barPer1.TabIndex = 23;
            this.barPer1.TickFrequency = 5;
            this.barPer1.Value = 60;
            this.barPer1.Scroll += new System.EventHandler(this.barPer1_Scroll);
            // 
            // lblPer2
            // 
            this.lblPer2.AutoSize = true;
            this.lblPer2.Font = new System.Drawing.Font("宋体", 15F);
            this.lblPer2.Location = new System.Drawing.Point(525, 168);
            this.lblPer2.Name = "lblPer2";
            this.lblPer2.Size = new System.Drawing.Size(51, 25);
            this.lblPer2.TabIndex = 28;
            this.lblPer2.Text = "0.7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15F);
            this.label9.Location = new System.Drawing.Point(308, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "长度系数2";
            // 
            // barPer2
            // 
            this.barPer2.Location = new System.Drawing.Point(430, 165);
            this.barPer2.Maximum = 80;
            this.barPer2.Minimum = 50;
            this.barPer2.Name = "barPer2";
            this.barPer2.Size = new System.Drawing.Size(97, 56);
            this.barPer2.SmallChange = 5;
            this.barPer2.TabIndex = 26;
            this.barPer2.TickFrequency = 5;
            this.barPer2.Value = 70;
            this.barPer2.Scroll += new System.EventHandler(this.barPer2_Scroll);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 586);
            this.Controls.Add(this.lblPer2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.barPer2);
            this.Controls.Add(this.lblPer1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.barPer1);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.barLoc);
            this.Controls.Add(this.lblLayer);
            this.Controls.Add(this.barLayer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDrawRdn);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.barWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblDegree2);
            this.Controls.Add(this.lblDegree1);
            this.Controls.Add(this.btnColorRnd);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.barLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.barDegree2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDegree1);
            this.Name = "OptionForm";
            this.Text = "OptionForm";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barDegree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barDegree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barLoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar barDegree1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar barDegree2;
        private System.Windows.Forms.TrackBar barLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Button btnColorRnd;
        private System.Windows.Forms.Label lblDegree1;
        private System.Windows.Forms.Label lblDegree2;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TrackBar barWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDrawRdn;
        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.TrackBar barLayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar barLoc;
        private System.Windows.Forms.Label lblPer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar barPer1;
        private System.Windows.Forms.Label lblPer2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar barPer2;
    }
}