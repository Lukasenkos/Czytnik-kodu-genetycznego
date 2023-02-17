namespace Czytnik_kodu_genetycznego
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.SekwencjaDNA1 = new System.Windows.Forms.Label();
            this.SekwencjaDNA2 = new System.Windows.Forms.Label();
            this.SekwencjaDNA3 = new System.Windows.Forms.Label();
            this.SCALKAWPRAWO = new System.Windows.Forms.PictureBox();
            this.Kodgenetycznywyjscie = new System.Windows.Forms.TextBox();
            this.CofnijDoGlownegoBUTTON = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SCALKAWPRAWO)).BeginInit();
            this.SuspendLayout();
            // 
            // SekwencjaDNA1
            // 
            this.SekwencjaDNA1.AutoSize = true;
            this.SekwencjaDNA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SekwencjaDNA1.Location = new System.Drawing.Point(55, 280);
            this.SekwencjaDNA1.Name = "SekwencjaDNA1";
            this.SekwencjaDNA1.Size = new System.Drawing.Size(70, 25);
            this.SekwencjaDNA1.TabIndex = 0;
            this.SekwencjaDNA1.Text = "label1";
            // 
            // SekwencjaDNA2
            // 
            this.SekwencjaDNA2.AutoSize = true;
            this.SekwencjaDNA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SekwencjaDNA2.Location = new System.Drawing.Point(55, 315);
            this.SekwencjaDNA2.Name = "SekwencjaDNA2";
            this.SekwencjaDNA2.Size = new System.Drawing.Size(70, 25);
            this.SekwencjaDNA2.TabIndex = 1;
            this.SekwencjaDNA2.Text = "label2";
            // 
            // SekwencjaDNA3
            // 
            this.SekwencjaDNA3.AutoSize = true;
            this.SekwencjaDNA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SekwencjaDNA3.Location = new System.Drawing.Point(55, 351);
            this.SekwencjaDNA3.Name = "SekwencjaDNA3";
            this.SekwencjaDNA3.Size = new System.Drawing.Size(70, 25);
            this.SekwencjaDNA3.TabIndex = 2;
            this.SekwencjaDNA3.Text = "label3";
            // 
            // SCALKAWPRAWO
            // 
            this.SCALKAWPRAWO.Image = ((System.Drawing.Image)(resources.GetObject("SCALKAWPRAWO.Image")));
            this.SCALKAWPRAWO.Location = new System.Drawing.Point(634, 293);
            this.SCALKAWPRAWO.Name = "SCALKAWPRAWO";
            this.SCALKAWPRAWO.Size = new System.Drawing.Size(104, 69);
            this.SCALKAWPRAWO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SCALKAWPRAWO.TabIndex = 3;
            this.SCALKAWPRAWO.TabStop = false;
            // 
            // Kodgenetycznywyjscie
            // 
            this.Kodgenetycznywyjscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kodgenetycznywyjscie.Location = new System.Drawing.Point(60, 45);
            this.Kodgenetycznywyjscie.Multiline = true;
            this.Kodgenetycznywyjscie.Name = "Kodgenetycznywyjscie";
            this.Kodgenetycznywyjscie.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Kodgenetycznywyjscie.Size = new System.Drawing.Size(678, 117);
            this.Kodgenetycznywyjscie.TabIndex = 4;
            this.Kodgenetycznywyjscie.TextChanged += new System.EventHandler(this.Kodgenetycznywyjscie_TextChanged);
            // 
            // CofnijDoGlownegoBUTTON
            // 
            this.CofnijDoGlownegoBUTTON.Location = new System.Drawing.Point(634, 185);
            this.CofnijDoGlownegoBUTTON.Name = "CofnijDoGlownegoBUTTON";
            this.CofnijDoGlownegoBUTTON.Size = new System.Drawing.Size(75, 23);
            this.CofnijDoGlownegoBUTTON.TabIndex = 5;
            this.CofnijDoGlownegoBUTTON.Text = "Cofnij";
            this.CofnijDoGlownegoBUTTON.UseVisualStyleBackColor = true;
            this.CofnijDoGlownegoBUTTON.Click += new System.EventHandler(this.CofnijDoGlownegoBUTTON_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CofnijDoGlownegoBUTTON);
            this.Controls.Add(this.Kodgenetycznywyjscie);
            this.Controls.Add(this.SCALKAWPRAWO);
            this.Controls.Add(this.SekwencjaDNA3);
            this.Controls.Add(this.SekwencjaDNA2);
            this.Controls.Add(this.SekwencjaDNA1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SCALKAWPRAWO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SekwencjaDNA1;
        private System.Windows.Forms.Label SekwencjaDNA2;
        private System.Windows.Forms.Label SekwencjaDNA3;
        private System.Windows.Forms.PictureBox SCALKAWPRAWO;
        private System.Windows.Forms.TextBox Kodgenetycznywyjscie;
        private System.Windows.Forms.Button CofnijDoGlownegoBUTTON;
    }
}