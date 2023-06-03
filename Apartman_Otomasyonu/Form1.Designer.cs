namespace Apartman_Otomasyonu
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
            this.gelirler = new System.Windows.Forms.Button();
            this.giderler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gelirler
            // 
            this.gelirler.BackColor = System.Drawing.Color.ForestGreen;
            this.gelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gelirler.Location = new System.Drawing.Point(129, 152);
            this.gelirler.Name = "gelirler";
            this.gelirler.Size = new System.Drawing.Size(128, 230);
            this.gelirler.TabIndex = 0;
            this.gelirler.Text = "Gelirler\r\n\r\n";
            this.gelirler.UseVisualStyleBackColor = false;
            this.gelirler.Click += new System.EventHandler(this.gelirler_Click);
            // 
            // giderler
            // 
            this.giderler.BackColor = System.Drawing.Color.LightCoral;
            this.giderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giderler.Location = new System.Drawing.Point(471, 152);
            this.giderler.Name = "giderler";
            this.giderler.Size = new System.Drawing.Size(125, 230);
            this.giderler.TabIndex = 1;
            this.giderler.Text = "Giderler";
            this.giderler.UseVisualStyleBackColor = false;
            this.giderler.Click += new System.EventHandler(this.giderler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(163, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "APARTMAN OTOMASYONU";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.giderler);
            this.Controls.Add(this.gelirler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gelirler;
        private System.Windows.Forms.Button giderler;
        private System.Windows.Forms.Label label1;
    }
}

