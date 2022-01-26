namespace Login_and_Registration
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.goToRegisterButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.showPassCheckbox = new System.Windows.Forms.CheckBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MessageType = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // goToRegisterButton
            // 
            this.goToRegisterButton.BackColor = System.Drawing.Color.White;
            this.goToRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goToRegisterButton.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToRegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.goToRegisterButton.Location = new System.Drawing.Point(57, 393);
            this.goToRegisterButton.Name = "goToRegisterButton";
            this.goToRegisterButton.Size = new System.Drawing.Size(200, 35);
            this.goToRegisterButton.TabIndex = 10;
            this.goToRegisterButton.Text = "REGISTER ACCOUNT";
            this.goToRegisterButton.UseVisualStyleBackColor = false;
            this.goToRegisterButton.Click += new System.EventHandler(this.goToRegisterButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(57, 340);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 35);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showPassCheckbox
            // 
            this.showPassCheckbox.AutoSize = true;
            this.showPassCheckbox.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.showPassCheckbox.Location = new System.Drawing.Point(139, 282);
            this.showPassCheckbox.Name = "showPassCheckbox";
            this.showPassCheckbox.Size = new System.Drawing.Size(118, 16);
            this.showPassCheckbox.TabIndex = 9;
            this.showPassCheckbox.Text = "Show Password";
            this.showPassCheckbox.UseVisualStyleBackColor = true;
            this.showPassCheckbox.CheckedChanged += new System.EventHandler(this.showPassCheckbox_CheckedChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.passwordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextbox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.passwordTextbox.Location = new System.Drawing.Point(57, 231);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(200, 25);
            this.passwordTextbox.TabIndex = 7;
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usernameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextbox.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.usernameTextbox.Location = new System.Drawing.Point(57, 156);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(200, 25);
            this.usernameTextbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.label3.Location = new System.Drawing.Point(54, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(54, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(21)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // MessageType
            // 
            this.MessageType.AutoSize = true;
            this.MessageType.Location = new System.Drawing.Point(12, 9);
            this.MessageType.Name = "MessageType";
            this.MessageType.Size = new System.Drawing.Size(50, 13);
            this.MessageType.TabIndex = 29;
            this.MessageType.Text = "Message";
            this.MessageType.Visible = false;
            // 
            // CloseApp
            // 
            this.CloseApp.Image = ((System.Drawing.Image)(resources.GetObject("CloseApp.Image")));
            this.CloseApp.Location = new System.Drawing.Point(276, 9);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(20, 19);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseApp.TabIndex = 30;
            this.CloseApp.TabStop = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 504);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.MessageType);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.goToRegisterButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.showPassCheckbox);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goToRegisterButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox showPassCheckbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MessageType;
        private System.Windows.Forms.PictureBox CloseApp;
    }
}

