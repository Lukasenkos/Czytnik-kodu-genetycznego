namespace Czytnik_kodu_genetycznego
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.clear = new System.Windows.Forms.Button();
            this.KodgenetycznyInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fgfgfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Zatwierdz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Infooblendzie = new System.Windows.Forms.Label();
            this.Wczytajzplikubutton = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(674, 67);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(90, 31);
            this.clear.TabIndex = 0;
            this.clear.Text = "Czyszczenie";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // KodgenetycznyInput
            // 
            this.KodgenetycznyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KodgenetycznyInput.ForeColor = System.Drawing.Color.Black;
            this.KodgenetycznyInput.Location = new System.Drawing.Point(29, 67);
            this.KodgenetycznyInput.MaxLength = 213769420;
            this.KodgenetycznyInput.Multiline = true;
            this.KodgenetycznyInput.Name = "KodgenetycznyInput";
            this.KodgenetycznyInput.Size = new System.Drawing.Size(537, 31);
            this.KodgenetycznyInput.TabIndex = 1;
            this.KodgenetycznyInput.WordWrap = false;
            this.KodgenetycznyInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fgfgfToolStripMenuItem,
            this.fgToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // fgfgfToolStripMenuItem
            // 
            this.fgfgfToolStripMenuItem.Name = "fgfgfToolStripMenuItem";
            this.fgfgfToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.fgfgfToolStripMenuItem.Text = "fgfgf";
            // 
            // fgToolStripMenuItem
            // 
            this.fgToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ggToolStripMenuItem});
            this.fgToolStripMenuItem.Name = "fgToolStripMenuItem";
            this.fgToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.fgToolStripMenuItem.Text = "fg";
            // 
            // ggToolStripMenuItem
            // 
            this.ggToolStripMenuItem.Name = "ggToolStripMenuItem";
            this.ggToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.ggToolStripMenuItem.Text = "gg";
            // 
            // Zatwierdz
            // 
            this.Zatwierdz.Location = new System.Drawing.Point(572, 67);
            this.Zatwierdz.Name = "Zatwierdz";
            this.Zatwierdz.Size = new System.Drawing.Size(96, 31);
            this.Zatwierdz.TabIndex = 3;
            this.Zatwierdz.Text = "Zatwierdź";
            this.Zatwierdz.UseVisualStyleBackColor = true;
            this.Zatwierdz.Click += new System.EventHandler(this.Zatwierdz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wpisz kod DNA lub RNA";
            // 
            // Infooblendzie
            // 
            this.Infooblendzie.AutoSize = true;
            this.Infooblendzie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Infooblendzie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Infooblendzie.ForeColor = System.Drawing.Color.Red;
            this.Infooblendzie.Location = new System.Drawing.Point(140, 101);
            this.Infooblendzie.Name = "Infooblendzie";
            this.Infooblendzie.Size = new System.Drawing.Size(331, 25);
            this.Infooblendzie.TabIndex = 5;
            this.Infooblendzie.Text = "Kod jest błędny, wpisz poprawny.";
            this.Infooblendzie.Visible = false;
            this.Infooblendzie.Click += new System.EventHandler(this.label2_Click);
            // 
            // Wczytajzplikubutton
            // 
            this.Wczytajzplikubutton.Location = new System.Drawing.Point(572, 104);
            this.Wczytajzplikubutton.Name = "Wczytajzplikubutton";
            this.Wczytajzplikubutton.Size = new System.Drawing.Size(192, 31);
            this.Wczytajzplikubutton.TabIndex = 6;
            this.Wczytajzplikubutton.Text = "Wczytaj z pliku...";
            this.Wczytajzplikubutton.UseVisualStyleBackColor = true;
            this.Wczytajzplikubutton.Click += new System.EventHandler(this.Wczytajzplikubutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wczytajzplikubutton);
            this.Controls.Add(this.Infooblendzie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zatwierdz);
            this.Controls.Add(this.KodgenetycznyInput);
            this.Controls.Add(this.clear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rozpoznawacz białek";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox KodgenetycznyInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fgfgfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ggToolStripMenuItem;
        private System.Windows.Forms.Button Zatwierdz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Infooblendzie;
        private System.Windows.Forms.Button Wczytajzplikubutton;
    }
}

