namespace DIGITAL_DIARY
{
    partial class EDIT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDIT));
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlyear = new System.Windows.Forms.ComboBox();
            this.ddlmonth = new System.Windows.Forms.ComboBox();
            this.ddldate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rdbfrnd = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbr = new System.Windows.Forms.RadioButton();
            this.rdboff = new System.Windows.Forms.RadioButton();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ddleno = new System.Windows.Forms.ComboBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(255, 316);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(200, 70);
            this.txtaddress.TabIndex = 31;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(103, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "ADDRESS";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(835, 197);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(200, 23);
            this.txtcontact.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(716, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "CONTACT NO.";
            // 
            // ddlyear
            // 
            this.ddlyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlyear.FormattingEnabled = true;
            this.ddlyear.Location = new System.Drawing.Point(378, 200);
            this.ddlyear.Name = "ddlyear";
            this.ddlyear.Size = new System.Drawing.Size(77, 24);
            this.ddlyear.TabIndex = 27;
            this.ddlyear.SelectedIndexChanged += new System.EventHandler(this.ddlyear_SelectedIndexChanged);
            // 
            // ddlmonth
            // 
            this.ddlmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlmonth.FormattingEnabled = true;
            this.ddlmonth.Items.AddRange(new object[] {
            "JAN",
            "FEB",
            "MARCH",
            "APRIL",
            "MAY",
            "JUNE",
            "JULY",
            "AUG",
            "SEPT",
            "OCT",
            "NOV",
            "DEC"});
            this.ddlmonth.Location = new System.Drawing.Point(320, 200);
            this.ddlmonth.Name = "ddlmonth";
            this.ddlmonth.Size = new System.Drawing.Size(59, 24);
            this.ddlmonth.TabIndex = 26;
            this.ddlmonth.SelectedIndexChanged += new System.EventHandler(this.ddlmonth_SelectedIndexChanged);
            // 
            // ddldate
            // 
            this.ddldate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddldate.FormattingEnabled = true;
            this.ddldate.Location = new System.Drawing.Point(262, 200);
            this.ddldate.Name = "ddldate";
            this.ddldate.Size = new System.Drawing.Size(59, 24);
            this.ddldate.TabIndex = 25;
            this.ddldate.SelectedIndexChanged += new System.EventHandler(this.ddldate_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(193, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "D.O.B";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(957, 120);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(200, 23);
            this.txtlname.TabIndex = 23;
            this.txtlname.TextChanged += new System.EventHandler(this.txtlname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(856, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "LAST NAME";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(560, 120);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(200, 23);
            this.txtmname.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(442, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "MIDDLE NAME";
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(163, 117);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(200, 23);
            this.txtfname.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(63, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "FIRST NAME";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(499, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "ENTRY NO.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Location = new System.Drawing.Point(359, 798);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 32;
            this.button1.Text = "EDIT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(791, 798);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 29);
            this.button2.TabIndex = 33;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(574, 798);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 29);
            this.button3.TabIndex = 34;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(1034, 798);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 29);
            this.button4.TabIndex = 35;
            this.button4.Text = "CANCEL";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // rdbfrnd
            // 
            this.rdbfrnd.AutoSize = true;
            this.rdbfrnd.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rdbfrnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbfrnd.Location = new System.Drawing.Point(84, 49);
            this.rdbfrnd.Name = "rdbfrnd";
            this.rdbfrnd.Size = new System.Drawing.Size(72, 23);
            this.rdbfrnd.TabIndex = 19;
            this.rdbfrnd.TabStop = true;
            this.rdbfrnd.Text = "Friends";
            this.rdbfrnd.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.rdbfrnd);
            this.groupBox2.Controls.Add(this.rdbr);
            this.groupBox2.Controls.Add(this.rdboff);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox2.Location = new System.Drawing.Point(741, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 123);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Group";
            // 
            // rdbr
            // 
            this.rdbr.AutoSize = true;
            this.rdbr.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rdbr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdbr.Location = new System.Drawing.Point(156, 49);
            this.rdbr.Name = "rdbr";
            this.rdbr.Size = new System.Drawing.Size(81, 23);
            this.rdbr.TabIndex = 19;
            this.rdbr.TabStop = true;
            this.rdbr.Text = "Relatives";
            this.rdbr.UseVisualStyleBackColor = false;
            // 
            // rdboff
            // 
            this.rdboff.AutoSize = true;
            this.rdboff.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rdboff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rdboff.Location = new System.Drawing.Point(20, 49);
            this.rdboff.Name = "rdboff";
            this.rdboff.Size = new System.Drawing.Size(64, 23);
            this.rdboff.TabIndex = 20;
            this.rdboff.TabStop = true;
            this.rdboff.Text = "Office";
            this.rdboff.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-15, -49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 44;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button7.Location = new System.Drawing.Point(410, 632);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 45;
            this.button7.Text = "UPDATE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button8.Location = new System.Drawing.Point(580, 636);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 46;
            this.button8.Text = "DELETE";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button9.Location = new System.Drawing.Point(752, 636);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 47;
            this.button9.Text = "CANCEL";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // ddleno
            // 
            this.ddleno.FormattingEnabled = true;
            this.ddleno.Location = new System.Drawing.Point(639, 39);
            this.ddleno.Name = "ddleno";
            this.ddleno.Size = new System.Drawing.Size(200, 24);
            this.ddleno.TabIndex = 48;
            this.ddleno.SelectedIndexChanged += new System.EventHandler(this.ddleno_SelectedIndexChanged);
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(263, 201);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(192, 23);
            this.txtdob.TabIndex = 49;
            // 
            // txtg
            // 
            this.txtg.Enabled = false;
            this.txtg.Location = new System.Drawing.Point(834, 274);
            this.txtg.Name = "txtg";
            this.txtg.Size = new System.Drawing.Size(200, 23);
            this.txtg.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(716, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "GROUP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 52;
            this.label2.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-15, -15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 53;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(320, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 23);
            this.textBox2.TabIndex = 54;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // EDIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1285, 742);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.ddleno);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcontact);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ddlyear);
            this.Controls.Add(this.ddlmonth);
            this.Controls.Add(this.ddldate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EDIT";
            this.Text = "EDIT CONTACTS";
            this.Load += new System.EventHandler(this.EDIT_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcontact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ddlyear;
        private System.Windows.Forms.ComboBox ddlmonth;
        private System.Windows.Forms.ComboBox ddldate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rdbfrnd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbr;
        private System.Windows.Forms.RadioButton rdboff;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox ddleno;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

    }
}