namespace Czytnik_kodu_genetycznego
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NatepnyButton = new System.Windows.Forms.Button();
            this.PoprzedniButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(211, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 276);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NatepnyButton
            // 
            this.NatepnyButton.Location = new System.Drawing.Point(678, 204);
            this.NatepnyButton.Name = "NatepnyButton";
            this.NatepnyButton.Size = new System.Drawing.Size(75, 23);
            this.NatepnyButton.TabIndex = 1;
            this.NatepnyButton.Text = "Nastepny";
            this.NatepnyButton.UseVisualStyleBackColor = true;
            this.NatepnyButton.Click += new System.EventHandler(this.NatepnyButton_Click);
            // 
            // PoprzedniButton
            // 
            this.PoprzedniButton.Location = new System.Drawing.Point(40, 204);
            this.PoprzedniButton.Name = "PoprzedniButton";
            this.PoprzedniButton.Size = new System.Drawing.Size(75, 23);
            this.PoprzedniButton.TabIndex = 2;
            this.PoprzedniButton.Text = "Poprzedni";
            this.PoprzedniButton.UseVisualStyleBackColor = true;
            this.PoprzedniButton.Click += new System.EventHandler(this.PoprzedniButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PoprzedniButton);
            this.Controls.Add(this.NatepnyButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button NatepnyButton;
        private System.Windows.Forms.Button PoprzedniButton;
    }
}