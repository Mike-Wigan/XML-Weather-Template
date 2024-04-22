namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.windlabel = new System.Windows.Forms.Label();
            this.gustlabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rainlabel = new System.Windows.Forms.Label();
            this.riselabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.feelslikelabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Sunsetlabel = new System.Windows.Forms.Label();
            this.degrelebel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.Font = new System.Drawing.Font("Verdana", 64.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(123, 127);
            this.currentOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(283, 135);
            this.currentOutput.TabIndex = 28;
            this.currentOutput.Text = "13";
            this.currentOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 34);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.forecastLabel.Location = new System.Drawing.Point(338, 26);
            this.forecastLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(110, 34);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(84, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 72;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(81, 95);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(380, 32);
            this.cityOutput.TabIndex = 73;
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.AutoSize = true;
            this.minOutput.ForeColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(269, 351);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(44, 16);
            this.minOutput.TabIndex = 74;
            this.minOutput.Text = "label1";
            // 
            // maxOutput
            // 
            this.maxOutput.AutoSize = true;
            this.maxOutput.ForeColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(269, 316);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(44, 16);
            this.maxOutput.TabIndex = 75;
            this.maxOutput.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "Max temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(188, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Min temp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(188, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 81;
            this.label5.Text = "Wind Gust";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(188, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "Wind speed";
            // 
            // windlabel
            // 
            this.windlabel.AutoSize = true;
            this.windlabel.ForeColor = System.Drawing.Color.White;
            this.windlabel.Location = new System.Drawing.Point(269, 384);
            this.windlabel.Name = "windlabel";
            this.windlabel.Size = new System.Drawing.Size(44, 16);
            this.windlabel.TabIndex = 79;
            this.windlabel.Text = "label1";
            // 
            // gustlabel
            // 
            this.gustlabel.AutoSize = true;
            this.gustlabel.ForeColor = System.Drawing.Color.White;
            this.gustlabel.Location = new System.Drawing.Point(269, 419);
            this.gustlabel.Name = "gustlabel";
            this.gustlabel.Size = new System.Drawing.Size(44, 16);
            this.gustlabel.TabIndex = 78;
            this.gustlabel.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(188, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 85;
            this.label9.Text = "Sun Rise";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(188, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 84;
            this.label10.Text = "Rain /cm";
            // 
            // rainlabel
            // 
            this.rainlabel.AutoSize = true;
            this.rainlabel.ForeColor = System.Drawing.Color.White;
            this.rainlabel.Location = new System.Drawing.Point(269, 449);
            this.rainlabel.Name = "rainlabel";
            this.rainlabel.Size = new System.Drawing.Size(44, 16);
            this.rainlabel.TabIndex = 83;
            this.rainlabel.Text = "label1";
            // 
            // riselabel
            // 
            this.riselabel.AutoSize = true;
            this.riselabel.ForeColor = System.Drawing.Color.White;
            this.riselabel.Location = new System.Drawing.Point(269, 479);
            this.riselabel.Name = "riselabel";
            this.riselabel.Size = new System.Drawing.Size(44, 16);
            this.riselabel.TabIndex = 82;
            this.riselabel.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(191, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 87;
            this.label7.Text = "Feels like";
            // 
            // feelslikelabel
            // 
            this.feelslikelabel.AutoSize = true;
            this.feelslikelabel.ForeColor = System.Drawing.Color.White;
            this.feelslikelabel.Location = new System.Drawing.Point(272, 246);
            this.feelslikelabel.Name = "feelslikelabel";
            this.feelslikelabel.Size = new System.Drawing.Size(44, 16);
            this.feelslikelabel.TabIndex = 86;
            this.feelslikelabel.Text = "label1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(188, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 89;
            this.label8.Text = "Sun Set";
            // 
            // Sunsetlabel
            // 
            this.Sunsetlabel.AutoSize = true;
            this.Sunsetlabel.ForeColor = System.Drawing.Color.White;
            this.Sunsetlabel.Location = new System.Drawing.Point(269, 507);
            this.Sunsetlabel.Name = "Sunsetlabel";
            this.Sunsetlabel.Size = new System.Drawing.Size(44, 16);
            this.Sunsetlabel.TabIndex = 88;
            this.Sunsetlabel.Text = "label1";
            // 
            // degrelebel
            // 
            this.degrelebel.AutoSize = true;
            this.degrelebel.BackColor = System.Drawing.Color.Transparent;
            this.degrelebel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degrelebel.ForeColor = System.Drawing.Color.White;
            this.degrelebel.Location = new System.Drawing.Point(341, 151);
            this.degrelebel.Name = "degrelebel";
            this.degrelebel.Size = new System.Drawing.Size(0, 32);
            this.degrelebel.TabIndex = 90;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Controls.Add(this.degrelebel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Sunsetlabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.feelslikelabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rainlabel);
            this.Controls.Add(this.riselabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.windlabel);
            this.Controls.Add(this.gustlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentOutput);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(542, 587);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label windlabel;
        private System.Windows.Forms.Label gustlabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label rainlabel;
        private System.Windows.Forms.Label riselabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label feelslikelabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Sunsetlabel;
        private System.Windows.Forms.Label degrelebel;
    }
}
