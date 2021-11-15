
namespace ServerConfigForm_P5_20190140111
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
            this.ON = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKet = new System.Windows.Forms.Label();
            this.labelOnOrOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ON
            // 
            this.ON.Location = new System.Drawing.Point(284, 256);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(75, 23);
            this.ON.TabIndex = 0;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.button1_Click);
            // 
            // OFF
            // 
            this.OFF.Location = new System.Drawing.Point(450, 256);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(75, 23);
            this.OFF.TabIndex = 1;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelKet
            // 
            this.labelKet.AutoSize = true;
            this.labelKet.Location = new System.Drawing.Point(384, 156);
            this.labelKet.Name = "labelKet";
            this.labelKet.Size = new System.Drawing.Size(0, 17);
            this.labelKet.TabIndex = 3;
            // 
            // labelOnOrOff
            // 
            this.labelOnOrOff.AutoSize = true;
            this.labelOnOrOff.Location = new System.Drawing.Point(384, 117);
            this.labelOnOrOff.Name = "labelOnOrOff";
            this.labelOnOrOff.Size = new System.Drawing.Size(8, 17);
            this.labelOnOrOff.TabIndex = 4;
            this.labelOnOrOff.Text = "\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOnOrOff);
            this.Controls.Add(this.labelKet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKet;
        private System.Windows.Forms.Label labelOnOrOff;
    }
}

