namespace TESTLAB1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnGrille = new System.Windows.Forms.Button();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.labelTitle.Location = new System.Drawing.Point(0, 48);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1100, 96);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Криптографические алгоритмы";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGrille
            // 
            this.btnGrille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGrille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(189)))), ((int)(((byte)(248)))));
            this.btnGrille.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrille.FlatAppearance.BorderSize = 0;
            this.btnGrille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrille.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnGrille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnGrille.Location = new System.Drawing.Point(320, 222);
            this.btnGrille.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGrille.Name = "btnGrille";
            this.btnGrille.Size = new System.Drawing.Size(489, 96);
            this.btnGrille.TabIndex = 2;
            this.btnGrille.Text = "Поворачивающаяся решётка\r\nанглийский алфавит, матричное шифрование";
            this.btnGrille.UseVisualStyleBackColor = false;
            this.btnGrille.Click += new System.EventHandler(this.btnGrille_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVigenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btnVigenere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVigenere.FlatAppearance.BorderSize = 0;
            this.btnVigenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVigenere.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnVigenere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnVigenere.Location = new System.Drawing.Point(320, 393);
            this.btnVigenere.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(489, 96);
            this.btnVigenere.TabIndex = 3;
            this.btnVigenere.Text = "Шифр Виженера\r\nрусский язык, прогрессивный ключ и пошаговый просмотр";
            this.btnVigenere.UseVisualStyleBackColor = false;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1100, 672);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnGrille);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MinimumSize = new System.Drawing.Size(997, 587);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная по криптографии";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnGrille;
        private System.Windows.Forms.Button btnVigenere;
    }
}
