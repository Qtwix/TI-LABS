namespace TI2
{
    partial class MainForm
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
            this.CipherTextBox = new System.Windows.Forms.TextBox();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.PlainTextBox = new System.Windows.Forms.TextBox();
            this.KeyTextBox = new System.Windows.Forms.TextBox();
            this.labelCipherText = new System.Windows.Forms.Label();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.labelGeneratedKey = new System.Windows.Forms.Label();
            this.CipherButton = new System.Windows.Forms.Button();
            this.RegisterTextBox = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CipherTextBox.Location = new System.Drawing.Point(330, 216);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.ReadOnly = true;
            this.CipherTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CipherTextBox.Size = new System.Drawing.Size(297, 225);
            this.CipherTextBox.TabIndex = 10;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlainTextBox.Location = new System.Drawing.Point(12, 346);
            this.PlainTextBox.Multiline = true;
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.ReadOnly = true;
            this.PlainTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlainTextBox.Size = new System.Drawing.Size(301, 95);
            this.PlainTextBox.TabIndex = 6;
            // 
            // KeyTextBox
            // 
            this.KeyTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyTextBox.Location = new System.Drawing.Point(12, 216);
            this.KeyTextBox.Multiline = true;
            this.KeyTextBox.Name = "KeyTextBox";
            this.KeyTextBox.ReadOnly = true;
            this.KeyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.KeyTextBox.Size = new System.Drawing.Size(301, 95);
            this.KeyTextBox.TabIndex = 8;
            // 
            // labelCipherText
            // 
            this.labelCipherText.Location = new System.Drawing.Point(327, 184);
            this.labelCipherText.Name = "labelCipherText";
            this.labelCipherText.Size = new System.Drawing.Size(180, 29);
            this.labelCipherText.TabIndex = 18;
            this.labelCipherText.Text = "Зашифрованный текст:";
            this.labelCipherText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlainText
            // 
            this.labelPlainText.Location = new System.Drawing.Point(12, 314);
            this.labelPlainText.Name = "labelPlainText";
            this.labelPlainText.Size = new System.Drawing.Size(175, 29);
            this.labelPlainText.TabIndex = 18;
            this.labelPlainText.Text = "Исходный текст:";
            this.labelPlainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGeneratedKey
            // 
            this.labelGeneratedKey.Location = new System.Drawing.Point(12, 184);
            this.labelGeneratedKey.Name = "labelGeneratedKey";
            this.labelGeneratedKey.Size = new System.Drawing.Size(206, 29);
            this.labelGeneratedKey.TabIndex = 17;
            this.labelGeneratedKey.Text = "Сгенерированный ключ:";
            this.labelGeneratedKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CipherButton
            // 
            this.CipherButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.CipherButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CipherButton.ForeColor = System.Drawing.Color.White;
            this.CipherButton.Location = new System.Drawing.Point(423, 90);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(204, 29);
            this.CipherButton.TabIndex = 3;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = false;
            this.CipherButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // RegisterTextBox
            // 
            this.RegisterTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterTextBox.Location = new System.Drawing.Point(12, 90);
            this.RegisterTextBox.MaxLength = 34;
            this.RegisterTextBox.Multiline = true;
            this.RegisterTextBox.Name = "RegisterTextBox";
            this.RegisterTextBox.Size = new System.Drawing.Size(395, 29);
            this.RegisterTextBox.TabIndex = 4;
            this.RegisterTextBox.TextChanged += new System.EventHandler(this.RegisterTextBox_TextChanged);
            this.RegisterTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RegisterTextBox_KeyPress);
            // 
            // OpenButton
            // 
            this.OpenButton.BackColor = System.Drawing.Color.Teal;
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenButton.ForeColor = System.Drawing.Color.White;
            this.OpenButton.Location = new System.Drawing.Point(12, 140);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(170, 26);
            this.OpenButton.TabIndex = 11;
            this.OpenButton.Text = "Открыть файл";
            this.OpenButton.UseVisualStyleBackColor = false;
            this.OpenButton.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Teal;
            this.SaveButton.Enabled = false;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(219, 140);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(170, 26);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Text = "Сохранить файл";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Teal;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.ForeColor = System.Drawing.Color.White;
            this.ClearButton.Location = new System.Drawing.Point(429, 140);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(198, 26);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.MenuClear_Click);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(12, 63);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(58, 16);
            this.LengthLabel.TabIndex = 14;
            this.LengthLabel.Text = "Длина: 0";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(12, 37);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(290, 16);
            this.RegisterLabel.TabIndex = 15;
            this.RegisterLabel.Text = "Введите начальное состояние регистра (34 бита)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(655, 467);
            this.Controls.Add(this.RegisterLabel);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.RegisterTextBox);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.labelCipherText);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.labelGeneratedKey);
            this.Controls.Add(this.CipherTextBox);
            this.Controls.Add(this.PlainTextBox);
            this.Controls.Add(this.KeyTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Потоковое шифрование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.TextBox CipherTextBox;

        #endregion

        private System.Windows.Forms.TextBox PlainTextBox;
        private System.Windows.Forms.TextBox KeyTextBox;
        private System.Windows.Forms.Label labelCipherText;
        private System.Windows.Forms.Label labelGeneratedKey;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.TextBox RegisterTextBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label RegisterLabel;
    }
}