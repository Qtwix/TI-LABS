using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TESTLAB1
{
    public class GrilleStepsForm : Form
    {
        private readonly ListBox _listSteps;
        private readonly Label _lblDescription;
        private readonly Label _lblLetters;
        private readonly Panel _panelMatrix;
        private readonly List<GrilleStep> _steps;

        public GrilleStepsForm(string title, List<GrilleStep> steps)
        {
            _steps = steps ?? new List<GrilleStep>();

            this.Text = title;
            this.ClientSize = new Size(720, 480);
            this.MinimumSize = new Size(720, 480);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.FromArgb(15, 23, 42);
            this.Font = new Font("Segoe UI", 9F);

            var lblStep = new Label
            {
                Text = "Шаги построения/чтения решётки:",
                Location = new Point(12, 130),
                AutoSize = true,
                ForeColor = Color.FromArgb(226, 232, 240)
            };
            _listSteps = new ListBox
            {
                Location = new Point(12, 150),
                Size = new Size(230, 160),
                Font = new Font("Segoe UI", 9F),
                DrawMode = DrawMode.OwnerDrawFixed,
                ItemHeight = 22,
                BorderStyle = BorderStyle.None
            };
            _listSteps.DrawItem += ListSteps_DrawItem;
            _listSteps.SelectedIndexChanged += ListSteps_SelectedIndexChanged;

            _lblDescription = new Label
            {
                Location = new Point(260, 10),
                Size = new Size(380, 40),
                AutoSize = true,
                MaximumSize = new Size(380, 0),
                ForeColor = Color.FromArgb(226, 232, 240),
                Font = new Font("Segoe UI", 9.5f)
            };

            _lblLetters = new Label
            {
                Location = new Point(260, 60),
                Size = new Size(420, 40),
                AutoSize = false,
                ForeColor = Color.FromArgb(96, 165, 250),
                Font = new Font("Consolas", 10f)
            };

            _panelMatrix = new Panel
            {
                Location = new Point(260, 110),
                Size = new Size(420, 340),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(15, 23, 42)
            };

            this.Controls.Add(lblStep);
            this.Controls.Add(_listSteps);
            this.Controls.Add(_lblDescription);
            this.Controls.Add(_lblLetters);
            this.Controls.Add(_panelMatrix);

            for (int i = 0; i < _steps.Count; i++)
                _listSteps.Items.Add($"Шаг {i + 1}: {GetStepShortName(_steps[i])}");
            if (_listSteps.Items.Count > 0)
                _listSteps.SelectedIndex = 0;
        }

        private static string GetStepShortName(GrilleStep s)
        {
            if (s.RotationDegrees == -3) return "Исходные буквы";
            if (s.RotationDegrees == -2) return "Заполнение матрицы";
            if (s.RotationDegrees == -4) return "Случайные буквы";
            if (s.RotationDegrees == -1) return "Итог (читаем построчно)";
            return $"Поворот {s.RotationDegrees}°";
        }

        private void ListSteps_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            bool selected = (e.State & DrawItemState.Selected) != 0;
            e.DrawBackground();
            Color back = selected ? Color.FromArgb(40, 80, 140) : (e.Index % 2 == 0 ? Color.FromArgb(22, 30, 42) : Color.FromArgb(18, 24, 32));
            using (var brush = new SolidBrush(back))
                e.Graphics.FillRectangle(brush, e.Bounds);
            using (var brush = new SolidBrush(selected ? Color.White : Color.FromArgb(210, 220, 235)))
                e.Graphics.DrawString(_listSteps.Items[e.Index].ToString(), e.Font, brush, e.Bounds.X + 2, e.Bounds.Y + 2);
            e.DrawFocusRectangle();
        }

        private void ListSteps_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = _listSteps.SelectedIndex;
            if (idx < 0 || idx >= _steps.Count) return;
            var step = _steps[idx];
            _lblDescription.Text = step.Description;
            _lblLetters.Text = string.IsNullOrEmpty(step.LettersThisRound)
                ? ""
                : (step.RotationDegrees == -3 ? "Буквы: " : "Буквы этого шага: ") + step.LettersThisRound;

            _panelMatrix.Controls.Clear();
            if (step.Matrix == null)
            {
                // Шаг "исходные буквы" — показываем буквы в одну строку с подсветкой каждой
                if (!string.IsNullOrEmpty(step.LettersThisRound))
                {
                    int len = Math.Min(step.LettersThisRound.Length, 16);
                    int cellW = 24;
                    for (int i = 0; i < len; i++)
                    {
                        var lbl = new Label
                        {
                            Text = step.LettersThisRound[i].ToString(),
                            Size = new Size(cellW - 2, cellW - 2),
                            Location = new Point(4 + i * cellW, 4),
                            TextAlign = ContentAlignment.MiddleCenter,
                            BackColor = Color.FromArgb(32, 64, 110),
                            BorderStyle = BorderStyle.FixedSingle,
                            Font = new Font("Consolas", 10f)
                        };
                        _panelMatrix.Controls.Add(lbl);
                    }
                    if (step.LettersThisRound.Length > 16)
                    {
                        var more = new Label
                        {
                            Text = "... ещё " + (step.LettersThisRound.Length - 16),
                            Location = new Point(4 + len * cellW, 6),
                            AutoSize = true,
                            ForeColor = Color.Gray
                        };
                        _panelMatrix.Controls.Add(more);
                    }
                }
                return;
            }

            int n = step.Matrix.GetLength(0);
            bool[,] highlight = step.HighlightCells;
            int cellSize = Math.Max(24, Math.Min(48, (270 - n - 1) / n));
            for (int r = 0; r < n; r++)
                for (int c = 0; c < n; c++)
                {
                    char ch = step.Matrix[r, c];
                    bool isEmpty = ch == '\0';
                    bool isHighlight = highlight != null && r < highlight.GetLength(0) && c < highlight.GetLength(1) && highlight[r, c];
                    Color back;
                    if (isEmpty)
                        back = Color.FromArgb(240, 242, 245);
                    else if (isHighlight)
                        back = Color.FromArgb(180, 220, 180);
                    else
                        back = Color.FromArgb(248, 250, 252);
                    var lbl = new Label
                    {
                        Text = isEmpty ? "—" : ch.ToString(),
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(2 + c * (cellSize + 2), 2 + r * (cellSize + 2)),
                        TextAlign = ContentAlignment.MiddleCenter,
                        BackColor = back,
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new Font("Consolas", isEmpty ? 8f : 9f),
                        ForeColor = isEmpty ? Color.Gray : Color.Black
                    };
                    _panelMatrix.Controls.Add(lbl);
                }
        }
    }
}
