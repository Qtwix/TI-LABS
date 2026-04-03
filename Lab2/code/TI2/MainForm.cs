using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TI2
{
    public partial class MainForm : Form
    {
        readonly LFSRCipher lFSRCipher = new LFSRCipher();

        public MainForm()
        {
            InitializeComponent();
            RegisterTextBox.KeyPress += RegisterTextBox_KeyPress;
            RegisterTextBox.MaxLength = 34;
            PlainTextBox.MaxLength = 1000000;
            KeyTextBox.MaxLength = 1000000;
            CipherTextBox.MaxLength = 1000000;
        }

        private void RegisterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '0' && e.KeyChar != '1' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        void RegisterTextBox_TextChanged(object sender, EventArgs e)
        {
            LengthLabel.Text = $@"Длина: {RegisterTextBox.Text.Length}";
        }

        void ResultButton_Click(object sender, EventArgs e)
        {
            if (RegisterTextBox.Text.Length != 34)
            {
                MessageBox.Show("Длина регистра должна быть 34 бита!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lFSRCipher.PlainText == null)
            {
                MessageBox.Show("Сначала выберите файл!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lFSRCipher.ProduceBitRegister(RegisterTextBox.Text);
            lFSRCipher.ProduceBitKey(lFSRCipher.PlainText.Length);
            KeyTextBox.Text = BitArrayToStr(lFSRCipher.BitKey);
            lFSRCipher.Cipher();
            CipherTextBox.Text = BitArrayToStr(lFSRCipher.CipherBit);
            AutoSaveResult();
            SaveButton.Enabled = true;
        }
                
        string BitArrayToStr(BitArray array)
        {
            if (array == null || array.Length == 0)
                return string.Empty;
            StringBuilder temp = new StringBuilder();
            if (array.Length <= 240)
            {
                for (int i = 0; i < array.Length; i++)
                    temp.Append(array[i] ? '1' : '0');
            }
            else
            {
                for (int i = 0; i < 120; i++)
                    temp.Append(array[i] ? '1' : '0');
                temp.Append("...");
                for (int i = array.Length - 120; i < array.Length; i++)
                    temp.Append(array[i] ? '1' : '0');
            }
            return temp.ToString();
        }

        void OpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] fileBytes = File.ReadAllBytes(OpenFileDialog.FileName);
                lFSRCipher.PlainText = new BitArray(fileBytes);
                PlainTextBox.Text = BitArrayToStr(lFSRCipher.PlainText);
            }
        }

        void SaveFile_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] result = new byte[(lFSRCipher.CipherBit.Length + 7) / 8];
                lFSRCipher.CipherBit.CopyTo(result, 0);
                File.WriteAllBytes(SaveFileDialog.FileName, result);
                MessageBox.Show("Файл успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MenuClear_Click(object sender, EventArgs e)
        {
            KeyTextBox.Clear();
            CipherTextBox.Clear();
            PlainTextBox.Clear();
            RegisterTextBox.Clear();
            lFSRCipher.PlainText = null;
            SaveButton.Enabled = false;
        }

        private void AutoSaveResult()
        {
            string baseDirectory, extension, autoSavePath;
            try
            {
                baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                extension = Path.GetExtension(OpenFileDialog.FileName);
                autoSavePath = Path.Combine(baseDirectory, "auto_result" + extension);
                byte[] result = new byte[(lFSRCipher.CipherBit.Length + 7) / 8];
                lFSRCipher.CipherBit.CopyTo(result, 0);
                File.WriteAllBytes(autoSavePath, result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка сохранения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}