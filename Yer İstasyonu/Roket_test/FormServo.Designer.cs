namespace Roket_test
{
    partial class FormServo
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
            this.trackBarUp = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarLow = new System.Windows.Forms.TrackBar();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.lblDegreeUp = new System.Windows.Forms.Label();
            this.lblDegreeLow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLow)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarUp
            // 
            this.trackBarUp.Location = new System.Drawing.Point(32, 31);
            this.trackBarUp.Name = "trackBarUp";
            this.trackBarUp.Size = new System.Drawing.Size(390, 45);
            this.trackBarUp.TabIndex = 0;
            this.trackBarUp.TickFrequency = 0;
            this.trackBarUp.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarUp.Scroll += new System.EventHandler(this.trackBarUp_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üst Mekanik Sistem :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(428, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "180";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(428, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "180";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Alt Mekanik Sistem :";
            // 
            // trackBarLow
            // 
            this.trackBarLow.Location = new System.Drawing.Point(32, 134);
            this.trackBarLow.Name = "trackBarLow";
            this.trackBarLow.Size = new System.Drawing.Size(390, 45);
            this.trackBarLow.TabIndex = 5;
            this.trackBarLow.TickFrequency = 0;
            this.trackBarLow.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarLow.Scroll += new System.EventHandler(this.trackBarLow_Scroll);
            // 
            // lblDegreeUp
            // 
            this.lblDegreeUp.AutoSize = true;
            this.lblDegreeUp.BackColor = System.Drawing.Color.Transparent;
            this.lblDegreeUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegreeUp.ForeColor = System.Drawing.Color.White;
            this.lblDegreeUp.Location = new System.Drawing.Point(211, 79);
            this.lblDegreeUp.Name = "lblDegreeUp";
            this.lblDegreeUp.Size = new System.Drawing.Size(36, 19);
            this.lblDegreeUp.TabIndex = 11;
            this.lblDegreeUp.Text = "180";
            // 
            // lblDegreeLow
            // 
            this.lblDegreeLow.AutoSize = true;
            this.lblDegreeLow.BackColor = System.Drawing.Color.Transparent;
            this.lblDegreeLow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegreeLow.ForeColor = System.Drawing.Color.White;
            this.lblDegreeLow.Location = new System.Drawing.Point(211, 189);
            this.lblDegreeLow.Name = "lblDegreeLow";
            this.lblDegreeLow.Size = new System.Drawing.Size(36, 19);
            this.lblDegreeLow.TabIndex = 12;
            this.lblDegreeLow.Text = "180";
            // 
            // FormServo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(479, 217);
            this.Controls.Add(this.lblDegreeLow);
            this.Controls.Add(this.lblDegreeUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarLow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarUp);
            this.Name = "FormServo";
            this.Text = "FormServo";
            this.Load += new System.EventHandler(this.FormServo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarLow;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label lblDegreeUp;
        private System.Windows.Forms.Label lblDegreeLow;
    }
}