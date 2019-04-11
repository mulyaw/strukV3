namespace Struk
{
    partial class Form1
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
            this.webviewK = new System.Windows.Forms.WebBrowser();
            this.bresetK = new System.Windows.Forms.Button();
            this.bprintK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbidpelK = new System.Windows.Forms.TextBox();
            this.dtpK = new System.Windows.Forms.DateTimePicker();
            this.cbitemK = new System.Windows.Forms.ComboBox();
            this.bprosesK = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.webviewM = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bresetM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpM = new System.Windows.Forms.DateTimePicker();
            this.bprintM = new System.Windows.Forms.Button();
            this.bprosesM = new System.Windows.Forms.Button();
            this.cbtipeM = new System.Windows.Forms.ComboBox();
            this.tbidpelM = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPrinterlist = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.webviewK);
            this.tabPage1.Controls.Add(this.bresetK);
            this.tabPage1.Controls.Add(this.bprintK);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Standard";
            // 
            // webviewK
            // 
            this.webviewK.Location = new System.Drawing.Point(6, 53);
            this.webviewK.MinimumSize = new System.Drawing.Size(20, 20);
            this.webviewK.Name = "webviewK";
            this.webviewK.Size = new System.Drawing.Size(891, 328);
            this.webviewK.TabIndex = 16;
            // 
            // bresetK
            // 
            this.bresetK.Location = new System.Drawing.Point(735, 387);
            this.bresetK.Name = "bresetK";
            this.bresetK.Size = new System.Drawing.Size(75, 23);
            this.bresetK.TabIndex = 15;
            this.bresetK.Text = "Reset";
            this.bresetK.UseVisualStyleBackColor = true;
            this.bresetK.Click += new System.EventHandler(this.bresetK_Click);
            // 
            // bprintK
            // 
            this.bprintK.Location = new System.Drawing.Point(816, 387);
            this.bprintK.Name = "bprintK";
            this.bprintK.Size = new System.Drawing.Size(75, 23);
            this.bprintK.TabIndex = 14;
            this.bprintK.Text = "Print";
            this.bprintK.UseVisualStyleBackColor = true;
            this.bprintK.Click += new System.EventHandler(this.bprintK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbidpelK);
            this.groupBox2.Controls.Add(this.dtpK);
            this.groupBox2.Controls.Add(this.cbitemK);
            this.groupBox2.Controls.Add(this.bprosesK);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(891, 41);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "TANGGAL :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "TIPE PEMBAYARAN :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "IDPEL :";
            // 
            // tbidpelK
            // 
            this.tbidpelK.Location = new System.Drawing.Point(56, 13);
            this.tbidpelK.Name = "tbidpelK";
            this.tbidpelK.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbidpelK.Size = new System.Drawing.Size(175, 20);
            this.tbidpelK.TabIndex = 0;
            // 
            // dtpK
            // 
            this.dtpK.Location = new System.Drawing.Point(331, 12);
            this.dtpK.Name = "dtpK";
            this.dtpK.Size = new System.Drawing.Size(175, 20);
            this.dtpK.TabIndex = 2;
            // 
            // cbitemK
            // 
            this.cbitemK.FormattingEnabled = true;
            this.cbitemK.Location = new System.Drawing.Point(645, 11);
            this.cbitemK.Name = "cbitemK";
            this.cbitemK.Size = new System.Drawing.Size(159, 21);
            this.cbitemK.TabIndex = 6;
            // 
            // bprosesK
            // 
            this.bprosesK.Location = new System.Drawing.Point(810, 10);
            this.bprosesK.Name = "bprosesK";
            this.bprosesK.Size = new System.Drawing.Size(75, 23);
            this.bprosesK.TabIndex = 4;
            this.bprosesK.Text = "Proses";
            this.bprosesK.UseVisualStyleBackColor = true;
            this.bprosesK.Click += new System.EventHandler(this.bprosesK_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.Controls.Add(this.webviewM);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mobile Mode";
            // 
            // webviewM
            // 
            this.webviewM.Location = new System.Drawing.Point(6, 6);
            this.webviewM.MinimumSize = new System.Drawing.Size(20, 20);
            this.webviewM.Name = "webviewM";
            this.webviewM.Size = new System.Drawing.Size(262, 404);
            this.webviewM.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bresetM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpM);
            this.groupBox1.Controls.Add(this.bprintM);
            this.groupBox1.Controls.Add(this.bprosesM);
            this.groupBox1.Controls.Add(this.cbtipeM);
            this.groupBox1.Controls.Add(this.tbidpelM);
            this.groupBox1.Location = new System.Drawing.Point(396, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bresetM
            // 
            this.bresetM.Location = new System.Drawing.Point(155, 159);
            this.bresetM.Name = "bresetM";
            this.bresetM.Size = new System.Drawing.Size(171, 23);
            this.bresetM.TabIndex = 19;
            this.bresetM.Text = "Reset";
            this.bresetM.UseVisualStyleBackColor = true;
            this.bresetM.Click += new System.EventHandler(this.bresetM_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tanggal Pembayaran :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipe Pembayaran :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Masukkan ID Pelanggan :";
            // 
            // dtpM
            // 
            this.dtpM.Location = new System.Drawing.Point(155, 55);
            this.dtpM.Name = "dtpM";
            this.dtpM.Size = new System.Drawing.Size(171, 20);
            this.dtpM.TabIndex = 15;
            // 
            // bprintM
            // 
            this.bprintM.Location = new System.Drawing.Point(251, 130);
            this.bprintM.Name = "bprintM";
            this.bprintM.Size = new System.Drawing.Size(75, 23);
            this.bprintM.TabIndex = 14;
            this.bprintM.Text = "Print";
            this.bprintM.UseVisualStyleBackColor = true;
            this.bprintM.Click += new System.EventHandler(this.bprintM_Click);
            // 
            // bprosesM
            // 
            this.bprosesM.Location = new System.Drawing.Point(155, 130);
            this.bprosesM.Name = "bprosesM";
            this.bprosesM.Size = new System.Drawing.Size(75, 23);
            this.bprosesM.TabIndex = 13;
            this.bprosesM.Text = "Proses";
            this.bprosesM.UseVisualStyleBackColor = true;
            this.bprosesM.Click += new System.EventHandler(this.bprosesM_Click);
            // 
            // cbtipeM
            // 
            this.cbtipeM.FormattingEnabled = true;
            this.cbtipeM.Location = new System.Drawing.Point(155, 90);
            this.cbtipeM.Name = "cbtipeM";
            this.cbtipeM.Size = new System.Drawing.Size(171, 21);
            this.cbtipeM.TabIndex = 12;
            // 
            // tbidpelM
            // 
            this.tbidpelM.Location = new System.Drawing.Point(155, 19);
            this.tbidpelM.Multiline = true;
            this.tbidpelM.Name = "tbidpelM";
            this.tbidpelM.Size = new System.Drawing.Size(171, 20);
            this.tbidpelM.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 453);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pilih printer";
            // 
            // cbPrinterlist
            // 
            this.cbPrinterlist.FormattingEnabled = true;
            this.cbPrinterlist.Location = new System.Drawing.Point(77, 448);
            this.cbPrinterlist.Name = "cbPrinterlist";
            this.cbPrinterlist.Size = new System.Drawing.Size(166, 21);
            this.cbPrinterlist.TabIndex = 14;
            this.cbPrinterlist.SelectedIndexChanged += new System.EventHandler(this.cbPrinterlist_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 477);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbPrinterlist);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Struk";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webviewK;
        private System.Windows.Forms.Button bresetK;
        private System.Windows.Forms.Button bprintK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbidpelK;
        private System.Windows.Forms.DateTimePicker dtpK;
        private System.Windows.Forms.ComboBox cbitemK;
        private System.Windows.Forms.Button bprosesK;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser webviewM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bresetM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpM;
        private System.Windows.Forms.Button bprintM;
        private System.Windows.Forms.Button bprosesM;
        private System.Windows.Forms.ComboBox cbtipeM;
        private System.Windows.Forms.TextBox tbidpelM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbPrinterlist;
    }
}

