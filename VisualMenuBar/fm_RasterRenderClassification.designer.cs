namespace VisualMenuBar
{
    partial class fm_RasterRenderClassification
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbbs_ColorStretch2 = new cbbColor.ComboBoxSym();
            this.cbbs_ColorStretch = new cbbColor.ComboBoxSym();
            this.btn_OkStretch = new System.Windows.Forms.Button();
            this.cbb_RasterLayersStretch = new System.Windows.Forms.ComboBox();
            this.cbb_BandStretch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbbs_ColorScale2 = new cbbColor.ComboBoxSym();
            this.cbbs_ColorScale = new cbbColor.ComboBoxSym();
            this.btn_OkScale = new System.Windows.Forms.Button();
            this.cbb_NumberScale = new System.Windows.Forms.ComboBox();
            this.cbb_RasterLayersScale = new System.Windows.Forms.ComboBox();
            this.cbb_MethodScale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(504, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbbs_ColorStretch2);
            this.tabPage1.Controls.Add(this.cbbs_ColorStretch);
            this.tabPage1.Controls.Add(this.btn_OkStretch);
            this.tabPage1.Controls.Add(this.cbb_RasterLayersStretch);
            this.tabPage1.Controls.Add(this.cbb_BandStretch);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(496, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "拉伸渲染";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbbs_ColorStretch2
            // 
            this.cbbs_ColorStretch2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbs_ColorStretch2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbs_ColorStretch2.FormattingEnabled = true;
            this.cbbs_ColorStretch2.Location = new System.Drawing.Point(134, 176);
            this.cbbs_ColorStretch2.Name = "cbbs_ColorStretch2";
            this.cbbs_ColorStretch2.Size = new System.Drawing.Size(249, 27);
            this.cbbs_ColorStretch2.TabIndex = 9;
            this.cbbs_ColorStretch2.Visible = false;
            // 
            // cbbs_ColorStretch
            // 
            this.cbbs_ColorStretch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbs_ColorStretch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbs_ColorStretch.FormattingEnabled = true;
            this.cbbs_ColorStretch.Location = new System.Drawing.Point(134, 137);
            this.cbbs_ColorStretch.Name = "cbbs_ColorStretch";
            this.cbbs_ColorStretch.Size = new System.Drawing.Size(249, 27);
            this.cbbs_ColorStretch.TabIndex = 9;
            // 
            // btn_OkStretch
            // 
            this.btn_OkStretch.Location = new System.Drawing.Point(203, 218);
            this.btn_OkStretch.Name = "btn_OkStretch";
            this.btn_OkStretch.Size = new System.Drawing.Size(82, 27);
            this.btn_OkStretch.TabIndex = 8;
            this.btn_OkStretch.Text = "确定";
            this.btn_OkStretch.UseVisualStyleBackColor = true;
            this.btn_OkStretch.Click += new System.EventHandler(this.btn_OkStretch_Click);
            // 
            // cbb_RasterLayersStretch
            // 
            this.cbb_RasterLayersStretch.FormattingEnabled = true;
            this.cbb_RasterLayersStretch.Location = new System.Drawing.Point(134, 41);
            this.cbb_RasterLayersStretch.Name = "cbb_RasterLayersStretch";
            this.cbb_RasterLayersStretch.Size = new System.Drawing.Size(249, 24);
            this.cbb_RasterLayersStretch.TabIndex = 6;
            this.cbb_RasterLayersStretch.SelectedIndexChanged += new System.EventHandler(this.cbb_RasterLayersStretch_SelectedIndexChanged);
            // 
            // cbb_BandStretch
            // 
            this.cbb_BandStretch.FormattingEnabled = true;
            this.cbb_BandStretch.Location = new System.Drawing.Point(134, 84);
            this.cbb_BandStretch.Name = "cbb_BandStretch";
            this.cbb_BandStretch.Size = new System.Drawing.Size(249, 24);
            this.cbb_BandStretch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "渲染颜色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "选择图层";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "渲染波段";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbbs_ColorScale2);
            this.tabPage2.Controls.Add(this.cbbs_ColorScale);
            this.tabPage2.Controls.Add(this.btn_OkScale);
            this.tabPage2.Controls.Add(this.cbb_NumberScale);
            this.tabPage2.Controls.Add(this.cbb_RasterLayersScale);
            this.tabPage2.Controls.Add(this.cbb_MethodScale);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lable);
            this.tabPage2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(496, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "分级渲染";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbbs_ColorScale2
            // 
            this.cbbs_ColorScale2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbs_ColorScale2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbs_ColorScale2.FormattingEnabled = true;
            this.cbbs_ColorScale2.Location = new System.Drawing.Point(149, 194);
            this.cbbs_ColorScale2.Name = "cbbs_ColorScale2";
            this.cbbs_ColorScale2.Size = new System.Drawing.Size(220, 27);
            this.cbbs_ColorScale2.TabIndex = 14;
            this.cbbs_ColorScale2.Visible = false;
            // 
            // cbbs_ColorScale
            // 
            this.cbbs_ColorScale.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbs_ColorScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbs_ColorScale.FormattingEnabled = true;
            this.cbbs_ColorScale.Location = new System.Drawing.Point(140, 150);
            this.cbbs_ColorScale.Name = "cbbs_ColorScale";
            this.cbbs_ColorScale.Size = new System.Drawing.Size(262, 27);
            this.cbbs_ColorScale.TabIndex = 15;
            // 
            // btn_OkScale
            // 
            this.btn_OkScale.Location = new System.Drawing.Point(219, 227);
            this.btn_OkScale.Name = "btn_OkScale";
            this.btn_OkScale.Size = new System.Drawing.Size(82, 27);
            this.btn_OkScale.TabIndex = 13;
            this.btn_OkScale.Text = "确定";
            this.btn_OkScale.UseVisualStyleBackColor = true;
            this.btn_OkScale.Click += new System.EventHandler(this.btn_OkScale_Click);
            // 
            // cbb_NumberScale
            // 
            this.cbb_NumberScale.FormattingEnabled = true;
            this.cbb_NumberScale.Location = new System.Drawing.Point(140, 111);
            this.cbb_NumberScale.Name = "cbb_NumberScale";
            this.cbb_NumberScale.Size = new System.Drawing.Size(262, 24);
            this.cbb_NumberScale.TabIndex = 11;
            // 
            // cbb_RasterLayersScale
            // 
            this.cbb_RasterLayersScale.FormattingEnabled = true;
            this.cbb_RasterLayersScale.Location = new System.Drawing.Point(140, 37);
            this.cbb_RasterLayersScale.Name = "cbb_RasterLayersScale";
            this.cbb_RasterLayersScale.Size = new System.Drawing.Size(262, 24);
            this.cbb_RasterLayersScale.TabIndex = 11;
            // 
            // cbb_MethodScale
            // 
            this.cbb_MethodScale.FormattingEnabled = true;
            this.cbb_MethodScale.Location = new System.Drawing.Point(140, 75);
            this.cbb_MethodScale.Name = "cbb_MethodScale";
            this.cbb_MethodScale.Size = new System.Drawing.Size(262, 24);
            this.cbb_MethodScale.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "渲染颜色";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "选择图层";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "分级数量";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Location = new System.Drawing.Point(43, 78);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(72, 16);
            this.lable.TabIndex = 10;
            this.lable.Text = "分级方法";
            // 
            // fm_RasterRenderClassification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 324);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Name = "fm_RasterRenderClassification";
            this.Text = "栅格渲染分级";
            this.Load += new System.EventHandler(this.fm_RasterRenderClassification_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_OkStretch;
        private System.Windows.Forms.ComboBox cbb_BandStretch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_OkScale;
        private System.Windows.Forms.ComboBox cbb_MethodScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.ComboBox cbb_NumberScale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbb_RasterLayersStretch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_RasterLayersScale;
        private System.Windows.Forms.Label label6;
        private cbbColor.ComboBoxSym cbbs_ColorStretch;
        private cbbColor.ComboBoxSym cbbs_ColorStretch2;
        private cbbColor.ComboBoxSym cbbs_ColorScale2;
        private cbbColor.ComboBoxSym cbbs_ColorScale;
    }
}