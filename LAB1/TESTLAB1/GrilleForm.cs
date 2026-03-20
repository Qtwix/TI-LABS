using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TESTLAB1
{
    public class GrilleForm : Form
    {
        private int _gridSize = 4;
        private bool[,] _holes;
        private Button[,] _gridButtons;
        private TextBox _txtInput;
        private TextBox _txtOutput;
        private ComboBox _comboSize;
        private Panel _panelGrid;

        public GrilleForm()
        {
            InitializeComponent();
            _holes = new bool[_gridSize, _gridSize];
            SetDefaultHoles();
            BuildGrid();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.Text = "Поворачивающаяся решётка (латиница)";
            this.ClientSize = new Size(880, 540);
            this.MinimumSize = new Size(880, 540);
            this.MaximumSize = new Size(880, 540);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(15, 23, 42);
            this.Font = new Font("Segoe UI", 9F);

            // левая зона: параметры и решётка
            var leftPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = 330,
                Padding = new Padding(16),
                BackColor = Color.FromArgb(15, 23, 42)
            };

            var lblSize = new Label
            {
                Text = "Размер решётки:",
                Location = new Point(15, 50),
                AutoSize = true,
                ForeColor = Color.FromArgb(226, 232, 240)
            };

            _comboSize = new ComboBox
            {
                Location = new Point(140, 50),
                Width = 60,
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor = Color.FromArgb(26, 34, 48),
                ForeColor = Color.White
            };
            for (int i = 3; i <= 10; i++)
                _comboSize.Items.Add(i.ToString());
            _comboSize.SelectedIndex = 1;
            _comboSize.SelectedIndexChanged += ComboSize_SelectedIndexChanged;

            _panelGrid = new Panel
            {
                Location = new Point(8, 90),
                Size = new Size(290, 290),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(15, 23, 42)
            };

            leftPanel.Controls.Add(lblSize);
            leftPanel.Controls.Add(_comboSize);
            leftPanel.Controls.Add(_panelGrid);

            // правая зона: текст и кнопки
            var rightPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            var lblInput = new Label
            {
                Text = "Исходный текст (латиница):",
                Location = new Point(8, 8),
                AutoSize = true,
                ForeColor = Color.FromArgb(226, 232, 240)
            };
            _txtInput = new TextBox
            {
                Location = new Point(8, 32),
                Size = new Size(500, 150),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font("Consolas", 10f),
                BackColor = Color.FromArgb(15, 23, 42),
                ForeColor = Color.FromArgb(226, 232, 240),
                BorderStyle = BorderStyle.FixedSingle
            };

            var lblOutput = new Label
            {
                Text = "Результат:",
                Location = new Point(8, 196),
                AutoSize = true,
                ForeColor = Color.FromArgb(226, 232, 240)
            };
            _txtOutput = new TextBox
            {
                Location = new Point(8, 220),
                Size = new Size(500, 150),
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                BackColor = Color.FromArgb(15, 23, 42),
                ForeColor = Color.FromArgb(248, 250, 252),
                Font = new Font("Consolas", 10f),
                BorderStyle = BorderStyle.FixedSingle
            };

            var btnLoad = new Button
            {
                Text = "Загрузить текст",
                Location = new Point(8, 390),
                Size = new Size(150, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(30, 64, 175),
                ForeColor = Color.White
            };
            btnLoad.FlatAppearance.BorderSize = 0;
            btnLoad.Click += BtnLoad_Click;

            var btnSave = new Button
            {
                Text = "Сохранить результат",
                Location = new Point(170, 390),
                Size = new Size(180, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(30, 64, 175),
                ForeColor = Color.White
            };
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Click += BtnSave_Click;

            var btnEncrypt = new Button
            {
                Text = "Зашифровать",
                Location = new Point(170, 430),
                Size = new Size(180, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(56, 189, 248),
                ForeColor = Color.FromArgb(15, 23, 42)
            };
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.Click += BtnEncrypt_Click;

            var btnDecrypt = new Button
            {
                Text = "Дешифровать",
                Location = new Point(360, 430),
                Size = new Size(140, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(239, 68, 68),
                ForeColor = Color.White
            };
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.Click += BtnDecrypt_Click;

            var btnStepsEncrypt = new Button
            {
                Text = "Шаги шифрования",
                Location = new Point(360, 390),
                Size = new Size(140, 32),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(30, 64, 175),
                ForeColor = Color.White
            };
            btnStepsEncrypt.FlatAppearance.BorderSize = 0;
            btnStepsEncrypt.Click += BtnStepsEncrypt_Click;

            var btnStepsDecrypt = new Button
            {
                Text = "Шаги расшифровки",
                Location = new Point(8, 430),
                Size = new Size(150, 30),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(30, 64, 175),
                ForeColor = Color.White
            };
            btnStepsDecrypt.FlatAppearance.BorderSize = 0;
            btnStepsDecrypt.Click += BtnStepsDecrypt_Click;

            rightPanel.Controls.Add(lblInput);
            rightPanel.Controls.Add(_txtInput);
            rightPanel.Controls.Add(lblOutput);
            rightPanel.Controls.Add(_txtOutput);
            rightPanel.Controls.Add(btnLoad);
            rightPanel.Controls.Add(btnSave);
            rightPanel.Controls.Add(btnEncrypt);
            rightPanel.Controls.Add(btnDecrypt);
            rightPanel.Controls.Add(btnStepsEncrypt);
            rightPanel.Controls.Add(btnStepsDecrypt);

            this.Controls.Add(rightPanel);
            this.Controls.Add(leftPanel);
            this.ResumeLayout(false);
        }

        private void SetDefaultHoles()
        {
            if (_gridSize == 4)
            {
                _holes[0, 0] = true;
                _holes[0, 1] = true;
                _holes[0, 2] = true;
                _holes[1, 1] = true;
            }
        }

        private void ComboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_comboSize.SelectedItem == null) return;
            _gridSize = int.Parse(_comboSize.SelectedItem.ToString());
            _holes = new bool[_gridSize, _gridSize];
            SetDefaultHoles();
            BuildGrid();
        }

        private void BuildGrid()
        {
            _panelGrid.Controls.Clear();
            _gridButtons = new Button[_gridSize, _gridSize];
            int cellSize = Math.Max(20, Math.Min(60, (260 - _gridSize - 1) / _gridSize));
            int total = cellSize * _gridSize + _gridSize + 1;
            _panelGrid.Size = new Size(total, total);

            for (int r = 0; r < _gridSize; r++)
                for (int c = 0; c < _gridSize; c++)
                {
                    int rr = r, cc = c;
                    var btn = new Button
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(1 + c * (cellSize + 1), 1 + r * (cellSize + 1)),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = _holes[r, c] ? Color.FromArgb(143, 0, 255) : Color.FromArgb(240, 242, 245),
                        Text = "",
                        Tag = Tuple.Create(r, c)
                    };
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(200, 205, 212);
                    btn.Click += GridCell_Click;
                    btn.BackColor = _holes[r, c] ? Color.FromArgb(143, 0, 255) : Color.FromArgb(240, 242, 245);
                    _panelGrid.Controls.Add(btn);
                    _gridButtons[r, c] = btn;
                }
        }

        private void GridCell_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var t = (Tuple<int, int>)btn.Tag;
            int r = t.Item1, c = t.Item2;
            var orbit = GrilleCipher.GetOrbitCells(_gridSize, r, c);
            foreach (var cell in orbit)
                _holes[cell.Item1, cell.Item2] = false;
            _holes[r, c] = true;
            foreach (var cell in orbit)
            {
                bool isHole = cell.Item1 == r && cell.Item2 == c;
                _gridButtons[cell.Item1, cell.Item2].BackColor = isHole ? Color.FromArgb(143, 0, 255) : Color.FromArgb(240, 242, 245);
            }
        }

        private bool ValidateHoles()
        {
            int expected = GrilleCipher.ExpectedHoleCount(_gridSize);
            int count = 0;
            for (int r = 0; r < _gridSize; r++)
                for (int c = 0; c < _gridSize; c++)
                    if (_holes[r, c]) count++;
            return count == expected;
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateHoles())
            {
                MessageBox.Show("Задайте шаблон решётки: в каждой группе из 4 ячеек должна быть ровно одна отмечена (клик по ячейке).", "Шаблон", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var cipher = new GrilleCipher(_gridSize, _holes);
                _txtOutput.Text = cipher.Encrypt(_txtInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDecrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateHoles())
            {
                MessageBox.Show("Задайте шаблон решётки: в каждой группе из 4 ячеек должна быть ровно одна отмечена.", "Шаблон", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var cipher = new GrilleCipher(_gridSize, _holes);
                string letters = Alphabets.FilterToAlphabet(_txtInput.Text, Alphabets.English);
                int need = _gridSize * _gridSize;
                if (letters.Length < need)
                {
                    MessageBox.Show($"Для расшифровки решётки {_gridSize}×{_gridSize} нужно минимум {need} букв (сейчас {letters.Length}).", "Недостаточно символов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _txtOutput.Text = cipher.Decrypt(_txtInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    _txtInput.Text = File.ReadAllText(ofd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка чтения файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnStepsEncrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateHoles())
            {
                MessageBox.Show("Задайте шаблон решётки.", "Шаблон", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var cipher = new GrilleCipher(_gridSize, _holes);
                var t = cipher.EncryptWithSteps(_txtInput.Text);
                _txtOutput.Text = t.Item1;
                using (var f = new GrilleStepsForm("Поворачивающаяся решётка — шифрование по шагам", t.Item2))
                    f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnStepsDecrypt_Click(object sender, EventArgs e)
        {
            if (!ValidateHoles())
            {
                MessageBox.Show("Задайте шаблон решётки.", "Шаблон", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string letters = Alphabets.FilterToAlphabet(_txtInput.Text, Alphabets.English);
                if (letters.Length < _gridSize * _gridSize)
                {
                    MessageBox.Show($"Для расшифровки нужно минимум {_gridSize * _gridSize} букв.", "Недостаточно символов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var cipher = new GrilleCipher(_gridSize, _holes);
                var t = cipher.DecryptWithSteps(_txtInput.Text);
                _txtOutput.Text = t.Item1;
                using (var f = new GrilleStepsForm("Поворачивающаяся решётка — расшифровка по шагам", t.Item2))
                    f.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_txtOutput.Text))
            {
                MessageBox.Show("Нет результата для сохранения.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            using (var sfd = new SaveFileDialog())
            {
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    File.WriteAllText(sfd.FileName, _txtOutput.Text);
                    MessageBox.Show("Файл сохранён.", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка записи файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
