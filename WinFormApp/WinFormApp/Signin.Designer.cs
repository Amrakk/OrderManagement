namespace WinFormApp
{
    partial class Signin
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
            label1 = new System.Windows.Forms.Label();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            labelEmail = new System.Windows.Forms.Label();
            labelPassword = new System.Windows.Forms.Label();
            txtPassword = new DevExpress.XtraEditors.TextEdit();
            btnSignin = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(96, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(333, 58);
            label1.TabIndex = 0;
            label1.Text = "Signin to OM";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(141, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Properties.AutoHeight = false;
            txtEmail.Size = new System.Drawing.Size(234, 44);
            txtEmail.TabIndex = 0;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEmail.Location = new System.Drawing.Point(141, 116);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new System.Drawing.Size(41, 18);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelPassword.Location = new System.Drawing.Point(141, 202);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(69, 18);
            labelPassword.TabIndex = 5;
            labelPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(141, 223);
            txtPassword.Name = "txtPassword";
            txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Properties.Appearance.Options.UseFont = true;
            txtPassword.Properties.AutoHeight = false;
            txtPassword.Properties.PasswordChar = '●';
            txtPassword.Size = new System.Drawing.Size(234, 44);
            txtPassword.TabIndex = 1;
            // 
            // btnSignin
            // 
            btnSignin.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSignin.Appearance.Options.UseFont = true;
            btnSignin.Location = new System.Drawing.Point(141, 306);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new System.Drawing.Size(234, 44);
            btnSignin.TabIndex = 2;
            btnSignin.Text = "SIGNIN";
            btnSignin.Click += btnSignin_Click;
            // 
            // Signin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(513, 402);
            Controls.Add(btnSignin);
            Controls.Add(labelPassword);
            Controls.Add(txtPassword);
            Controls.Add(labelEmail);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Signin";
            Text = "Signin";
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnSignin;
    }
}

