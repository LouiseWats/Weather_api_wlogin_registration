namespace Login_and_Registration
{
    partial class weatherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(weatherForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchCityTextbox = new System.Windows.Forms.TextBox();
            this.weatherPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SunsetLabel = new System.Windows.Forms.Label();
            this.SunriseLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.WindLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.PictureBox();
            this.weatherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "City";
            // 
            // searchCityTextbox
            // 
            this.searchCityTextbox.Font = new System.Drawing.Font("Lucida Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCityTextbox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.searchCityTextbox.Location = new System.Drawing.Point(211, 133);
            this.searchCityTextbox.Name = "searchCityTextbox";
            this.searchCityTextbox.Size = new System.Drawing.Size(226, 33);
            this.searchCityTextbox.TabIndex = 1;
            this.searchCityTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchCityTextbox_KeyDown);
            // 
            // weatherPanel
            // 
            this.weatherPanel.BackColor = System.Drawing.Color.Transparent;
            this.weatherPanel.Controls.Add(this.label9);
            this.weatherPanel.Controls.Add(this.label8);
            this.weatherPanel.Controls.Add(this.label7);
            this.weatherPanel.Controls.Add(this.label6);
            this.weatherPanel.Controls.Add(this.label5);
            this.weatherPanel.Controls.Add(this.label4);
            this.weatherPanel.Controls.Add(this.SunsetLabel);
            this.weatherPanel.Controls.Add(this.SunriseLabel);
            this.weatherPanel.Controls.Add(this.PressureLabel);
            this.weatherPanel.Controls.Add(this.WindLabel);
            this.weatherPanel.Controls.Add(this.DetailsLabel);
            this.weatherPanel.Controls.Add(this.ConditionLabel);
            this.weatherPanel.Controls.Add(this.TemperatureLabel);
            this.weatherPanel.Controls.Add(this.label3);
            this.weatherPanel.Location = new System.Drawing.Point(102, 280);
            this.weatherPanel.Name = "weatherPanel";
            this.weatherPanel.Size = new System.Drawing.Size(752, 333);
            this.weatherPanel.TabIndex = 3;
            this.weatherPanel.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(623, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sunset";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(462, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sunrise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(462, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pressure";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(462, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Wind Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Conditions";
            // 
            // SunsetLabel
            // 
            this.SunsetLabel.AutoSize = true;
            this.SunsetLabel.BackColor = System.Drawing.Color.Transparent;
            this.SunsetLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunsetLabel.ForeColor = System.Drawing.Color.White;
            this.SunsetLabel.Location = new System.Drawing.Point(624, 259);
            this.SunsetLabel.Name = "SunsetLabel";
            this.SunsetLabel.Size = new System.Drawing.Size(57, 18);
            this.SunsetLabel.TabIndex = 7;
            this.SunsetLabel.Text = "Sunset";
            // 
            // SunriseLabel
            // 
            this.SunriseLabel.AutoSize = true;
            this.SunriseLabel.BackColor = System.Drawing.Color.Transparent;
            this.SunriseLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SunriseLabel.ForeColor = System.Drawing.Color.White;
            this.SunriseLabel.Location = new System.Drawing.Point(463, 259);
            this.SunriseLabel.Name = "SunriseLabel";
            this.SunriseLabel.Size = new System.Drawing.Size(62, 18);
            this.SunriseLabel.TabIndex = 8;
            this.SunriseLabel.Text = "Sunrise";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.BackColor = System.Drawing.Color.Transparent;
            this.PressureLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressureLabel.ForeColor = System.Drawing.Color.White;
            this.PressureLabel.Location = new System.Drawing.Point(463, 169);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(70, 18);
            this.PressureLabel.TabIndex = 9;
            this.PressureLabel.Text = "Pressure";
            // 
            // WindLabel
            // 
            this.WindLabel.AutoSize = true;
            this.WindLabel.BackColor = System.Drawing.Color.Transparent;
            this.WindLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindLabel.ForeColor = System.Drawing.Color.White;
            this.WindLabel.Location = new System.Drawing.Point(463, 92);
            this.WindLabel.Name = "WindLabel";
            this.WindLabel.Size = new System.Drawing.Size(101, 18);
            this.WindLabel.TabIndex = 10;
            this.WindLabel.Text = "Wind Speed";
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DetailsLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DetailsLabel.ForeColor = System.Drawing.Color.White;
            this.DetailsLabel.Location = new System.Drawing.Point(58, 259);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(61, 18);
            this.DetailsLabel.TabIndex = 11;
            this.DetailsLabel.Text = "Details";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ConditionLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionLabel.ForeColor = System.Drawing.Color.White;
            this.ConditionLabel.Location = new System.Drawing.Point(58, 169);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(83, 18);
            this.ConditionLabel.TabIndex = 12;
            this.ConditionLabel.Text = "Condition";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.TemperatureLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLabel.ForeColor = System.Drawing.Color.White;
            this.TemperatureLabel.Location = new System.Drawing.Point(58, 92);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(100, 18);
            this.TemperatureLabel.TabIndex = 13;
            this.TemperatureLabel.Text = "Temperature";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(57, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Temperature";
            // 
            // CloseApp
            // 
            this.CloseApp.BackColor = System.Drawing.Color.Transparent;
            this.CloseApp.Image = ((System.Drawing.Image)(resources.GetObject("CloseApp.Image")));
            this.CloseApp.Location = new System.Drawing.Point(917, 12);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(20, 19);
            this.CloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseApp.TabIndex = 33;
            this.CloseApp.TabStop = false;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // weatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 672);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.weatherPanel);
            this.Controls.Add(this.searchCityTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "weatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "weatherForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.weatherForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.weatherForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.weatherForm_MouseUp);
            this.weatherPanel.ResumeLayout(false);
            this.weatherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchCityTextbox;
        private System.Windows.Forms.Panel weatherPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SunsetLabel;
        private System.Windows.Forms.Label SunriseLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label WindLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox CloseApp;
    }
}