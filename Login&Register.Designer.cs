namespace CitisoftVendorAssignment
{
    partial class Login_Register
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
            this.CitisoftLogo = new System.Windows.Forms.PictureBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginUserPicturebox = new System.Windows.Forms.PictureBox();
            this.loginPasswordPicturebox = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CitisoftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPasswordPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // CitisoftLogo
            // 
            this.CitisoftLogo.Location = new System.Drawing.Point(46, 171);
            this.CitisoftLogo.Name = "CitisoftLogo";
            this.CitisoftLogo.Size = new System.Drawing.Size(429, 148);
            this.CitisoftLogo.TabIndex = 0;
            this.CitisoftLogo.TabStop = false;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(140, 435);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(246, 30);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(140, 522);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(246, 30);
            this.passwordTextbox.TabIndex = 2;
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(255, 578);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(131, 48);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.Snow;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(88, 699);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(113, 52);
            this.registerButton.TabIndex = 4;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginUserPicturebox
            // 
            this.loginUserPicturebox.Location = new System.Drawing.Point(88, 435);
            this.loginUserPicturebox.Name = "loginUserPicturebox";
            this.loginUserPicturebox.Size = new System.Drawing.Size(52, 29);
            this.loginUserPicturebox.TabIndex = 5;
            this.loginUserPicturebox.TabStop = false;
            this.loginUserPicturebox.Click += new System.EventHandler(this.loginUserPicturebox_Click);
            // 
            // loginPasswordPicturebox
            // 
            this.loginPasswordPicturebox.Location = new System.Drawing.Point(88, 522);
            this.loginPasswordPicturebox.Name = "loginPasswordPicturebox";
            this.loginPasswordPicturebox.Size = new System.Drawing.Size(52, 30);
            this.loginPasswordPicturebox.TabIndex = 6;
            this.loginPasswordPicturebox.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(136, 400);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(102, 25);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(136, 494);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(98, 25);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // Login_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(528, 968);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginPasswordPicturebox);
            this.Controls.Add(this.loginUserPicturebox);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.CitisoftLogo);
            this.Name = "Login_Register";
            this.Text = "Login_Register";
            ((System.ComponentModel.ISupportInitialize)(this.CitisoftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginUserPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginPasswordPicturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CitisoftLogo;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox loginUserPicturebox;
        private System.Windows.Forms.PictureBox loginPasswordPicturebox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}