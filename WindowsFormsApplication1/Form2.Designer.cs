namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblForm2email = new System.Windows.Forms.Label();
            this.lbl4Form2ConfirmPassowrd = new System.Windows.Forms.Label();
            this.lblForm2Password = new System.Windows.Forms.Label();
            this.lblForm2UserName = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblForm2email
            // 
            this.lblForm2email.AutoSize = true;
            this.lblForm2email.BackColor = System.Drawing.Color.Transparent;
            this.lblForm2email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm2email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm2email.Location = new System.Drawing.Point(49, 92);
            this.lblForm2email.Name = "lblForm2email";
            this.lblForm2email.Size = new System.Drawing.Size(59, 15);
            this.lblForm2email.TabIndex = 15;
            this.lblForm2email.Text = "Email id";
            // 
            // lbl4Form2ConfirmPassowrd
            // 
            this.lbl4Form2ConfirmPassowrd.AutoSize = true;
            this.lbl4Form2ConfirmPassowrd.BackColor = System.Drawing.Color.Transparent;
            this.lbl4Form2ConfirmPassowrd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Form2ConfirmPassowrd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl4Form2ConfirmPassowrd.Location = new System.Drawing.Point(49, 219);
            this.lbl4Form2ConfirmPassowrd.Name = "lbl4Form2ConfirmPassowrd";
            this.lbl4Form2ConfirmPassowrd.Size = new System.Drawing.Size(126, 15);
            this.lbl4Form2ConfirmPassowrd.TabIndex = 14;
            this.lbl4Form2ConfirmPassowrd.Text = "Confirm Password";
            // 
            // lblForm2Password
            // 
            this.lblForm2Password.AutoSize = true;
            this.lblForm2Password.BackColor = System.Drawing.Color.Transparent;
            this.lblForm2Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm2Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm2Password.Location = new System.Drawing.Point(49, 158);
            this.lblForm2Password.Name = "lblForm2Password";
            this.lblForm2Password.Size = new System.Drawing.Size(71, 15);
            this.lblForm2Password.TabIndex = 13;
            this.lblForm2Password.Text = "Password";
            this.lblForm2Password.Click += new System.EventHandler(this.lblForm2Password_Click);
            // 
            // lblForm2UserName
            // 
            this.lblForm2UserName.AutoSize = true;
            this.lblForm2UserName.BackColor = System.Drawing.Color.Transparent;
            this.lblForm2UserName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm2UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm2UserName.Location = new System.Drawing.Point(49, 23);
            this.lblForm2UserName.Name = "lblForm2UserName";
            this.lblForm2UserName.Size = new System.Drawing.Size(79, 15);
            this.lblForm2UserName.TabIndex = 12;
            this.lblForm2UserName.Text = "User Name";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox4.Location = new System.Drawing.Point(229, 214);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(229, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(229, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(229, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(727, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblForm2email);
            this.Controls.Add(this.lbl4Form2ConfirmPassowrd);
            this.Controls.Add(this.lblForm2Password);
            this.Controls.Add(this.lblForm2UserName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "menu ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm2email;
        private System.Windows.Forms.Label lbl4Form2ConfirmPassowrd;
        private System.Windows.Forms.Label lblForm2Password;
        private System.Windows.Forms.Label lblForm2UserName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        //private _400_data_baseDataSet1 _400_data_baseDataSet1;
        private System.Windows.Forms.BindingSource loginfoBindingSource;
        //private _400_data_baseDataSet1TableAdapters.log_infoTableAdapter log_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}