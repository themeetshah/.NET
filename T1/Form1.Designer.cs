namespace Form01
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbnumber = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.cbqty = new System.Windows.Forms.ComboBox();
            this.chprime = new System.Windows.Forms.CheckBox();
            this.rbelec = new System.Windows.Forms.RadioButton();
            this.rbgame = new System.Windows.Forms.RadioButton();
            this.dgv = new System.Windows.Forms.DateTimePicker();
            this.bsubmit = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bclear);
            this.groupBox1.Controls.Add(this.bsubmit);
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Controls.Add(this.rbgame);
            this.groupBox1.Controls.Add(this.rbelec);
            this.groupBox1.Controls.Add(this.chprime);
            this.groupBox1.Controls.Add(this.cbqty);
            this.groupBox1.Controls.Add(this.tbprice);
            this.groupBox1.Controls.Add(this.tbnumber);
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qty. :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Membership :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date :";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(93, 24);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 7;
            // 
            // tbnumber
            // 
            this.tbnumber.Location = new System.Drawing.Point(102, 57);
            this.tbnumber.Name = "tbnumber";
            this.tbnumber.Size = new System.Drawing.Size(100, 20);
            this.tbnumber.TabIndex = 8;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(48, 90);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(100, 20);
            this.tbprice.TabIndex = 9;
            // 
            // cbqty
            // 
            this.cbqty.FormattingEnabled = true;
            this.cbqty.Location = new System.Drawing.Point(44, 123);
            this.cbqty.Name = "cbqty";
            this.cbqty.Size = new System.Drawing.Size(121, 21);
            this.cbqty.TabIndex = 10;
            // 
            // chprime
            // 
            this.chprime.AutoSize = true;
            this.chprime.Checked = true;
            this.chprime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chprime.Location = new System.Drawing.Point(81, 160);
            this.chprime.Name = "chprime";
            this.chprime.Size = new System.Drawing.Size(52, 17);
            this.chprime.TabIndex = 11;
            this.chprime.Text = "Prime";
            this.chprime.UseVisualStyleBackColor = true;
            this.chprime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbelec
            // 
            this.rbelec.AutoSize = true;
            this.rbelec.Location = new System.Drawing.Point(67, 189);
            this.rbelec.Name = "rbelec";
            this.rbelec.Size = new System.Drawing.Size(77, 17);
            this.rbelec.TabIndex = 12;
            this.rbelec.TabStop = true;
            this.rbelec.Text = "Electronics";
            this.rbelec.UseVisualStyleBackColor = true;
            // 
            // rbgame
            // 
            this.rbgame.AutoSize = true;
            this.rbgame.Location = new System.Drawing.Point(67, 212);
            this.rbgame.Name = "rbgame";
            this.rbgame.Size = new System.Drawing.Size(61, 17);
            this.rbgame.TabIndex = 13;
            this.rbgame.TabStop = true;
            this.rbgame.Text = "Gaming";
            this.rbgame.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            this.dgv.Location = new System.Drawing.Point(48, 249);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(200, 20);
            this.dgv.TabIndex = 14;
            // 
            // bsubmit
            // 
            this.bsubmit.Location = new System.Drawing.Point(30, 295);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(75, 23);
            this.bsubmit.TabIndex = 15;
            this.bsubmit.Text = "Submit";
            this.bsubmit.UseVisualStyleBackColor = true;
            // 
            // bclear
            // 
            this.bclear.Location = new System.Drawing.Point(160, 295);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(75, 23);
            this.bclear.TabIndex = 16;
            this.bclear.Text = "Clear";
            this.bclear.UseVisualStyleBackColor = true;
            // 
            // bupdate
            // 
            this.bupdate.Location = new System.Drawing.Point(430, 198);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(75, 23);
            this.bupdate.TabIndex = 17;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(547, 198);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 18;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.DateTimePicker dgv;
        private System.Windows.Forms.RadioButton rbgame;
        private System.Windows.Forms.RadioButton rbelec;
        private System.Windows.Forms.CheckBox chprime;
        private System.Windows.Forms.ComboBox cbqty;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbnumber;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

