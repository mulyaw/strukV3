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
            this.label7 = new System.Windows.Forms.Label();
            this.cblistgrupK = new System.Windows.Forms.ComboBox();
            this.webviewK = new System.Windows.Forms.WebBrowser();
            this.bresetK = new System.Windows.Forms.Button();
            this.bprintK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bloadK = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbidpelK = new System.Windows.Forms.TextBox();
            this.dtpK = new System.Windows.Forms.DateTimePicker();
            this.cbitemK = new System.Windows.Forms.ComboBox();
            this.bprosesK = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.cblistgrupM = new System.Windows.Forms.ComboBox();
            this.webviewM = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bloadM = new System.Windows.Forms.Button();
            this.bresetM = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpM = new System.Windows.Forms.DateTimePicker();
            this.bprintM = new System.Windows.Forms.Button();
            this.bprosesM = new System.Windows.Forms.Button();
            this.cbtipeM = new System.Windows.Forms.ComboBox();
            this.tbidpelM = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.bresetG = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.listgrup = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.rtbgrup = new System.Windows.Forms.RichTextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbPrinterlist = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cblistgrupK);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Isi IDPEL dari grup kolektif";
            // 
            // cblistgrupK
            // 
            this.cblistgrupK.FormattingEnabled = true;
            this.cblistgrupK.Location = new System.Drawing.Point(142, 389);
            this.cblistgrupK.Name = "cblistgrupK";
            this.cblistgrupK.Size = new System.Drawing.Size(137, 21);
            this.cblistgrupK.TabIndex = 17;
            this.cblistgrupK.SelectedIndexChanged += new System.EventHandler(this.cblistgrupK_SelectedIndexChanged);
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
            this.groupBox2.Controls.Add(this.bloadK);
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
            // bloadK
            // 
            this.bloadK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloadK.Location = new System.Drawing.Point(249, 12);
            this.bloadK.Name = "bloadK";
            this.bloadK.Size = new System.Drawing.Size(24, 23);
            this.bloadK.TabIndex = 10;
            this.bloadK.Text = "+";
            this.bloadK.UseVisualStyleBackColor = true;
            this.bloadK.Click += new System.EventHandler(this.bloadK_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 17);
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
            this.tbidpelK.Size = new System.Drawing.Size(191, 20);
            this.tbidpelK.TabIndex = 0;
            // 
            // dtpK
            // 
            this.dtpK.Location = new System.Drawing.Point(353, 12);
            this.dtpK.Name = "dtpK";
            this.dtpK.Size = new System.Drawing.Size(155, 20);
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
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.cblistgrupM);
            this.tabPage2.Controls.Add(this.webviewM);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mobile Mode";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Isi IDPEL dari grup kolektif";
            // 
            // cblistgrupM
            // 
            this.cblistgrupM.FormattingEnabled = true;
            this.cblistgrupM.Location = new System.Drawing.Point(759, 26);
            this.cblistgrupM.Name = "cblistgrupM";
            this.cblistgrupM.Size = new System.Drawing.Size(138, 21);
            this.cblistgrupM.TabIndex = 21;
            this.cblistgrupM.SelectedIndexChanged += new System.EventHandler(this.cblistgrupM_SelectedIndexChanged);
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
            this.groupBox1.Controls.Add(this.bloadM);
            this.groupBox1.Controls.Add(this.bresetM);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpM);
            this.groupBox1.Controls.Add(this.bprintM);
            this.groupBox1.Controls.Add(this.bprosesM);
            this.groupBox1.Controls.Add(this.cbtipeM);
            this.groupBox1.Controls.Add(this.tbidpelM);
            this.groupBox1.Location = new System.Drawing.Point(274, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 257);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // bloadM
            // 
            this.bloadM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bloadM.Location = new System.Drawing.Point(302, 18);
            this.bloadM.Name = "bloadM";
            this.bloadM.Size = new System.Drawing.Size(24, 23);
            this.bloadM.TabIndex = 20;
            this.bloadM.Text = "+";
            this.bloadM.UseVisualStyleBackColor = true;
            this.bloadM.Click += new System.EventHandler(this.bloadM_Click);
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
            this.tbidpelM.Name = "tbidpelM";
            this.tbidpelM.Size = new System.Drawing.Size(141, 20);
            this.tbidpelM.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.bresetG);
            this.tabPage3.Controls.Add(this.bdelete);
            this.tabPage3.Controls.Add(this.bupdate);
            this.tabPage3.Controls.Add(this.listgrup);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.tbnama);
            this.tabPage3.Controls.Add(this.rtbgrup);
            this.tabPage3.Controls.Add(this.bAdd);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(904, 416);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grup Kolektif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data ID Pelanggan, Pisah dengan enter";
            // 
            // bresetG
            // 
            this.bresetG.Location = new System.Drawing.Point(486, 333);
            this.bresetG.Name = "bresetG";
            this.bresetG.Size = new System.Drawing.Size(75, 23);
            this.bresetG.TabIndex = 10;
            this.bresetG.Text = "Reset";
            this.bresetG.UseVisualStyleBackColor = true;
            this.bresetG.Click += new System.EventHandler(this.bresetG_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(405, 333);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 8;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bupdate
            // 
            this.bupdate.Location = new System.Drawing.Point(324, 333);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(75, 23);
            this.bupdate.TabIndex = 7;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // listgrup
            // 
            this.listgrup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listgrup.FormattingEnabled = true;
            this.listgrup.Location = new System.Drawing.Point(724, 25);
            this.listgrup.Name = "listgrup";
            this.listgrup.Size = new System.Drawing.Size(177, 327);
            this.listgrup.TabIndex = 6;
            this.listgrup.SelectedIndexChanged += new System.EventHandler(this.listgrup_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(721, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "List Grup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Grup";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(71, 335);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(166, 20);
            this.tbnama.TabIndex = 2;
            // 
            // rtbgrup
            // 
            this.rtbgrup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbgrup.Location = new System.Drawing.Point(4, 25);
            this.rtbgrup.Name = "rtbgrup";
            this.rtbgrup.Size = new System.Drawing.Size(712, 301);
            this.rtbgrup.TabIndex = 1;
            this.rtbgrup.Text = "";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(243, 333);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(668, 455);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pilih printer";
            // 
            // cbPrinterlist
            // 
            this.cbPrinterlist.FormattingEnabled = true;
            this.cbPrinterlist.Location = new System.Drawing.Point(732, 450);
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
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
        private System.Windows.Forms.Button bloadK;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.RichTextBox rtbgrup;
        private System.Windows.Forms.Button bloadM;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.ListBox listgrup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bresetG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cblistgrupK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cblistgrupM;
    }
}

