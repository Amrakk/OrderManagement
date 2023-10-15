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
            textEmail = new DevExpress.XtraEditors.TextEdit();
            labelEmail = new System.Windows.Forms.Label();
            labelPassword = new System.Windows.Forms.Label();
            textPassword = new DevExpress.XtraEditors.TextEdit();
            btnSignin = new DevExpress.XtraEditors.SimpleButton();
            label2 = new System.Windows.Forms.Label();
            labelEmailWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)textEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textPassword.Properties).BeginInit();
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
            // textEmail
            // 
            textEmail.Location = new System.Drawing.Point(141, 124);
            textEmail.Name = "textEmail";
            textEmail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textEmail.Properties.Appearance.Options.UseFont = true;
            textEmail.Properties.AutoHeight = false;
            textEmail.Size = new System.Drawing.Size(234, 44);
            textEmail.TabIndex = 1;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelEmail.Location = new System.Drawing.Point(141, 103);
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
            // textPassword
            // 
            textPassword.Location = new System.Drawing.Point(141, 223);
            textPassword.Name = "textPassword";
            textPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textPassword.Properties.Appearance.Options.UseFont = true;
            textPassword.Properties.AutoHeight = false;
            textPassword.Properties.PasswordChar = '●';
            textPassword.Size = new System.Drawing.Size(234, 44);
            textPassword.TabIndex = 4;
            // 
            // btnSignin
            // 
            btnSignin.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSignin.Appearance.Options.UseFont = true;
            btnSignin.Location = new System.Drawing.Point(141, 306);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new System.Drawing.Size(234, 44);
            btnSignin.TabIndex = 6;
            btnSignin.Text = "SIGNIN";
            // 
            // label2
            // 
            label2.ForeColor = System.Drawing.Color.Red;
            label2.Location = new System.Drawing.Point(141, 270);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(237, 30);
            label2.TabIndex = 7;
            label2.Text = "Required";
            label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelEmailWarning
            // 
            labelEmailWarning.ForeColor = System.Drawing.Color.Red;
            labelEmailWarning.Location = new System.Drawing.Point(141, 171);
            labelEmailWarning.Name = "labelEmailWarning";
            labelEmailWarning.Size = new System.Drawing.Size(234, 30);
            labelEmailWarning.TabIndex = 8;
            labelEmailWarning.Text = "Required";
            labelEmailWarning.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Signin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(513, 402);
            Controls.Add(labelEmailWarning);
            Controls.Add(label2);
            Controls.Add(btnSignin);
            Controls.Add(labelPassword);
            Controls.Add(textPassword);
            Controls.Add(labelEmail);
            Controls.Add(textEmail);
            Controls.Add(label1);
            Name = "Signin";
            Text = "Signin";
            ((System.ComponentModel.ISupportInitialize)textEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textPassword.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private DevExpress.XtraEditors.TextEdit textPassword;
        private DevExpress.XtraEditors.SimpleButton btnSignin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEmailWarning;
    }
}

