namespace WindowsFormsApplication1
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
            this.lblLogin = new System.Windows.Forms.Button();
            this.lblLink1 = new System.Windows.Forms.LinkLabel();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogin.Location = new System.Drawing.Point(218, 178);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(176, 41);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            this.lblLogin.UseVisualStyleBackColor = false;
            this.lblLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLink1
            // 
            this.lblLink1.AutoSize = true;
            this.lblLink1.Location = new System.Drawing.Point(285, 281);
            this.lblLink1.Name = "lblLink1";
            this.lblLink1.Size = new System.Drawing.Size(46, 13);
            this.lblLink1.TabIndex = 1;
            this.lblLink1.TabStop = true;
            this.lblLink1.Text = "Sign up!";
            this.lblLink1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink1_LinkClicked);
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAccount.Location = new System.Drawing.Point(234, 239);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(128, 20);
            this.txtAccount.TabIndex = 2;
            this.txtAccount.Text = "Don\'t have an account?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 429);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.lblLink1);
            this.Controls.Add(this.lblLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblLogin;
        private System.Windows.Forms.LinkLabel lblLink1;
        private System.Windows.Forms.TextBox txtAccount;
    }
}

