namespace GUI
{
    partial class FrmChangepassword
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
            this.lbChangepass = new System.Windows.Forms.Label();
            this.lbOldpassword = new System.Windows.Forms.Label();
            this.lbNewpassword = new System.Windows.Forms.Label();
            this.lbConfirmNewpassword = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.txtNewpass = new System.Windows.Forms.TextBox();
            this.txtConfirmNewpass = new System.Windows.Forms.TextBox();
            this.checkShowpass = new System.Windows.Forms.CheckBox();
            this.btnChangepass = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbChangepass
            // 
            this.lbChangepass.AutoSize = true;
            this.lbChangepass.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbChangepass.Location = new System.Drawing.Point(141, 40);
            this.lbChangepass.Name = "lbChangepass";
            this.lbChangepass.Size = new System.Drawing.Size(267, 41);
            this.lbChangepass.TabIndex = 0;
            this.lbChangepass.Text = "Change Password";
            // 
            // lbOldpassword
            // 
            this.lbOldpassword.AutoSize = true;
            this.lbOldpassword.Location = new System.Drawing.Point(79, 129);
            this.lbOldpassword.Name = "lbOldpassword";
            this.lbOldpassword.Size = new System.Drawing.Size(100, 20);
            this.lbOldpassword.TabIndex = 2;
            this.lbOldpassword.Text = "Old password";
            // 
            // lbNewpassword
            // 
            this.lbNewpassword.AutoSize = true;
            this.lbNewpassword.Location = new System.Drawing.Point(79, 198);
            this.lbNewpassword.Name = "lbNewpassword";
            this.lbNewpassword.Size = new System.Drawing.Size(106, 20);
            this.lbNewpassword.TabIndex = 3;
            this.lbNewpassword.Text = "New password";
            // 
            // lbConfirmNewpassword
            // 
            this.lbConfirmNewpassword.AutoSize = true;
            this.lbConfirmNewpassword.Location = new System.Drawing.Point(79, 256);
            this.lbConfirmNewpassword.Name = "lbConfirmNewpassword";
            this.lbConfirmNewpassword.Size = new System.Drawing.Size(155, 20);
            this.lbConfirmNewpassword.TabIndex = 4;
            this.lbConfirmNewpassword.Text = "Cofirm New password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(268, 129);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '*';
            this.txtOldPass.Size = new System.Drawing.Size(196, 27);
            this.txtOldPass.TabIndex = 6;
            // 
            // txtNewpass
            // 
            this.txtNewpass.Location = new System.Drawing.Point(268, 195);
            this.txtNewpass.Name = "txtNewpass";
            this.txtNewpass.PasswordChar = '*';
            this.txtNewpass.Size = new System.Drawing.Size(196, 27);
            this.txtNewpass.TabIndex = 7;
            // 
            // txtConfirmNewpass
            // 
            this.txtConfirmNewpass.Location = new System.Drawing.Point(268, 253);
            this.txtConfirmNewpass.Name = "txtConfirmNewpass";
            this.txtConfirmNewpass.PasswordChar = '*';
            this.txtConfirmNewpass.Size = new System.Drawing.Size(196, 27);
            this.txtConfirmNewpass.TabIndex = 8;
            // 
            // checkShowpass
            // 
            this.checkShowpass.AutoSize = true;
            this.checkShowpass.Location = new System.Drawing.Point(268, 315);
            this.checkShowpass.Name = "checkShowpass";
            this.checkShowpass.Size = new System.Drawing.Size(134, 24);
            this.checkShowpass.TabIndex = 9;
            this.checkShowpass.Text = "Show password";
            this.checkShowpass.UseVisualStyleBackColor = true;
            this.checkShowpass.CheckedChanged += new System.EventHandler(this.checkShowpass_CheckedChanged);
            // 
            // btnChangepass
            // 
            this.btnChangepass.Location = new System.Drawing.Point(204, 375);
            this.btnChangepass.Name = "btnChangepass";
            this.btnChangepass.Size = new System.Drawing.Size(94, 29);
            this.btnChangepass.TabIndex = 10;
            this.btnChangepass.Text = "Change";
            this.btnChangepass.UseVisualStyleBackColor = true;
            this.btnChangepass.Click += new System.EventHandler(this.btnChangepass_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 375);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmChangepassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChangepass);
            this.Controls.Add(this.checkShowpass);
            this.Controls.Add(this.txtConfirmNewpass);
            this.Controls.Add(this.txtNewpass);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.lbConfirmNewpassword);
            this.Controls.Add(this.lbNewpassword);
            this.Controls.Add(this.lbOldpassword);
            this.Controls.Add(this.lbChangepass);
            this.Name = "FrmChangepassword";
            this.Text = "FrmChangepassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChangepass;
        private System.Windows.Forms.Label lbOldpassword;
        private System.Windows.Forms.Label lbNewpassword;
        private System.Windows.Forms.Label lbConfirmNewpassword;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.TextBox txtNewpass;
        private System.Windows.Forms.TextBox txtConfirmNewpass;
        private System.Windows.Forms.CheckBox checkShowpass;
        private System.Windows.Forms.Button btnChangepass;
        private System.Windows.Forms.Button btnCancel;
    }
}