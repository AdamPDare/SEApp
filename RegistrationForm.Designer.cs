namespace CitisoftVendorAssignment
{
    partial class RegistrationForm
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
            this.citisoftPicturebox2 = new System.Windows.Forms.PictureBox();
            this.usernameTextbox2 = new System.Windows.Forms.TextBox();
            this.passwordTextbox2 = new System.Windows.Forms.TextBox();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.companyRoleCombobox = new System.Windows.Forms.ComboBox();
            this.registerAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citisoftPicturebox2)).BeginInit();
            this.SuspendLayout();
            // 
            // citisoftPicturebox2
            // 
            this.citisoftPicturebox2.Location = new System.Drawing.Point(70, 50);
            this.citisoftPicturebox2.Name = "citisoftPicturebox2";
            this.citisoftPicturebox2.Size = new System.Drawing.Size(375, 141);
            this.citisoftPicturebox2.TabIndex = 0;
            this.citisoftPicturebox2.TabStop = false;
            // 
            // usernameTextbox2
            // 
            this.usernameTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox2.Location = new System.Drawing.Point(135, 278);
            this.usernameTextbox2.Name = "usernameTextbox2";
            this.usernameTextbox2.Size = new System.Drawing.Size(246, 30);
            this.usernameTextbox2.TabIndex = 1;
            // 
            // passwordTextbox2
            // 
            this.passwordTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox2.Location = new System.Drawing.Point(135, 355);
            this.passwordTextbox2.Name = "passwordTextbox2";
            this.passwordTextbox2.Size = new System.Drawing.Size(246, 30);
            this.passwordTextbox2.TabIndex = 2;
            // 
            // emailTextbox
            // 
            this.emailTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextbox.Location = new System.Drawing.Point(135, 429);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(246, 30);
            this.emailTextbox.TabIndex = 3;
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextbox.Location = new System.Drawing.Point(135, 500);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(246, 30);
            this.firstNameTextbox.TabIndex = 4;
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextbox.Location = new System.Drawing.Point(135, 564);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(246, 30);
            this.lastNameTextbox.TabIndex = 5;
            // 
            // companyRoleCombobox
            // 
            this.companyRoleCombobox.FormattingEnabled = true;
            this.companyRoleCombobox.Items.AddRange(new object[] {
            "Owner",
            "Admin",
            "Financial Advisor"});
            this.companyRoleCombobox.Location = new System.Drawing.Point(135, 641);
            this.companyRoleCombobox.Name = "companyRoleCombobox";
            this.companyRoleCombobox.Size = new System.Drawing.Size(246, 28);
            this.companyRoleCombobox.TabIndex = 6;
            // 
            // registerAccountButton
            // 
            this.registerAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerAccountButton.Location = new System.Drawing.Point(268, 720);
            this.registerAccountButton.Name = "registerAccountButton";
            this.registerAccountButton.Size = new System.Drawing.Size(113, 52);
            this.registerAccountButton.TabIndex = 7;
            this.registerAccountButton.Text = "Register";
            this.registerAccountButton.UseVisualStyleBackColor = true;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(528, 968);
            this.Controls.Add(this.registerAccountButton);
            this.Controls.Add(this.companyRoleCombobox);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.firstNameTextbox);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.passwordTextbox2);
            this.Controls.Add(this.usernameTextbox2);
            this.Controls.Add(this.citisoftPicturebox2);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.citisoftPicturebox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox citisoftPicturebox2;
        private System.Windows.Forms.TextBox usernameTextbox2;
        private System.Windows.Forms.TextBox passwordTextbox2;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.ComboBox companyRoleCombobox;
        private System.Windows.Forms.Button registerAccountButton;
    }
}