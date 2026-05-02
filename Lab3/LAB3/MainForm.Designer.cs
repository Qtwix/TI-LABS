namespace Lab3WinForms;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null!;

    private Panel panelHeader;
    private Label lblSubtitle;
    private Panel panelMain;
    private SplitContainer splitMain;
    private GroupBox grpParams;
    private GroupBox grpFiles;
    private Panel panelPreview;
    private Label lblTitle;
    private Label lblParams;
    private TextBox txtP;
    private TextBox txtX;
    private TextBox txtK;
    private Button btnFindRoots;
    private Label lblRoots;
    private ComboBox cmbG;
    private Label lblEncrypt;
    private TextBox txtEncryptPath;
    private Button btnBrowseEncrypt;
    private Button btnEncrypt;
    private Label lblDecrypt;
    private TextBox txtDecryptPath;
    private Button btnBrowseDecrypt;
    private Button btnDecrypt;
    private Label lblPreview;
    private TextBox txtPreview;
    private Label lblStatus;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        panelHeader = new Panel();
        lblSubtitle = new Label();
        panelMain = new Panel();
        splitMain = new SplitContainer();
        grpParams = new GroupBox();
        grpFiles = new GroupBox();
        panelPreview = new Panel();
        lblTitle = new Label();
        lblParams = new Label();
        txtP = new TextBox();
        txtX = new TextBox();
        txtK = new TextBox();
        btnFindRoots = new Button();
        lblRoots = new Label();
        cmbG = new ComboBox();
        lblEncrypt = new Label();
        txtEncryptPath = new TextBox();
        btnBrowseEncrypt = new Button();
        btnEncrypt = new Button();
        lblDecrypt = new Label();
        txtDecryptPath = new TextBox();
        btnBrowseDecrypt = new Button();
        btnDecrypt = new Button();
        lblPreview = new Label();
        txtPreview = new TextBox();
        lblStatus = new Label();
        panelHeader.SuspendLayout();
        panelMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
        splitMain.Panel1.SuspendLayout();
        splitMain.Panel2.SuspendLayout();
        splitMain.SuspendLayout();
        grpParams.SuspendLayout();
        grpFiles.SuspendLayout();
        panelPreview.SuspendLayout();
        SuspendLayout();

        panelHeader.BackColor = Color.FromArgb(0, 0, 128);
        panelHeader.Controls.Add(lblSubtitle);
        panelHeader.Controls.Add(lblTitle);
        panelHeader.Dock = DockStyle.Top;
        panelHeader.Name = "panelHeader";
        panelHeader.Padding = new Padding(18, 14, 18, 14);
        panelHeader.Size = new Size(1224, 84);
        panelHeader.TabIndex = 0;
        panelHeader.Visible = true;

        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
        lblTitle.ForeColor = Color.White;
        lblTitle.Location = new Point(18, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(300, 41);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Эль-Гамаль";

        lblSubtitle.AutoSize = true;
        lblSubtitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblSubtitle.ForeColor = Color.FromArgb(156, 163, 175);
        lblSubtitle.Location = new Point(20, 55);
        lblSubtitle.Name = "lblSubtitle";
        lblSubtitle.Size = new Size(453, 23);
        lblSubtitle.TabIndex = 1;
        lblSubtitle.Text = "";

        panelMain.BackColor = Color.FromArgb(0, 0, 139);
        panelMain.Controls.Add(splitMain);
        panelMain.Dock = DockStyle.Top;
        panelMain.Name = "panelMain";
        panelMain.Padding = new Padding(16);
        panelMain.Size = new Size(1224, 440);
        panelMain.TabIndex = 1;

        splitMain.Dock = DockStyle.Fill;
        splitMain.FixedPanel = FixedPanel.Panel1;
        splitMain.IsSplitterFixed = false;
        splitMain.Location = new Point(16, 16);
        splitMain.Name = "splitMain";
        splitMain.Orientation = Orientation.Vertical;
        splitMain.Panel1.Controls.Add(grpParams);
        splitMain.Panel2.Controls.Add(grpFiles);
        splitMain.Size = new Size(1192, 408);
        splitMain.SplitterDistance = 520;
        splitMain.SplitterWidth = 10;
        splitMain.TabIndex = 0;

        grpParams.BackColor = Color.FromArgb(249, 250, 251);
        grpParams.Dock = DockStyle.Fill;
        grpParams.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
        grpParams.ForeColor = Color.FromArgb(17, 24, 39);
        grpParams.Location = new Point(0, 0);
        grpParams.Name = "grpParams";
        grpParams.Padding = new Padding(14, 14, 14, 12);
        grpParams.Size = new Size(520, 408);
        grpParams.TabIndex = 0;
        grpParams.TabStop = false;
        grpParams.Text = "Параметры и первообразные корни";
        grpParams.Controls.Add(lblParams);
        grpParams.Controls.Add(txtP);
        grpParams.Controls.Add(txtX);
        grpParams.Controls.Add(txtK);
        grpParams.Controls.Add(btnFindRoots);
        grpParams.Controls.Add(lblRoots);
        grpParams.Controls.Add(cmbG);

        grpFiles.BackColor = Color.FromArgb(249, 250, 251);
        grpFiles.Dock = DockStyle.Fill;
        grpFiles.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
        grpFiles.ForeColor = Color.FromArgb(17, 24, 39);
        grpFiles.Location = new Point(0, 0);
        grpFiles.Name = "grpFiles";
        grpFiles.Padding = new Padding(14, 14, 14, 12);
        grpFiles.Size = new Size(662, 408);
        grpFiles.TabIndex = 0;
        grpFiles.TabStop = false;
        grpFiles.Text = "Файлы: шифрование / дешифрование";
        grpFiles.Controls.Add(lblEncrypt);
        grpFiles.Controls.Add(txtEncryptPath);
        grpFiles.Controls.Add(btnBrowseEncrypt);
        grpFiles.Controls.Add(btnEncrypt);
        grpFiles.Controls.Add(lblDecrypt);
        grpFiles.Controls.Add(txtDecryptPath);
        grpFiles.Controls.Add(btnBrowseDecrypt);
        grpFiles.Controls.Add(btnDecrypt);
        grpFiles.Controls.Add(lblStatus);

        panelPreview.BackColor = Color.FromArgb(0, 0, 139);
        panelPreview.BorderStyle = BorderStyle.FixedSingle;
        panelPreview.Controls.Add(lblPreview);
        panelPreview.Controls.Add(txtPreview);
        panelPreview.Dock = DockStyle.Fill;
        panelPreview.Name = "panelPreview";
        panelPreview.Padding = new Padding(16);
        panelPreview.Size = new Size(1224, 300);
        panelPreview.TabIndex = 2;

        lblParams.AutoSize = true;
        lblParams.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblParams.ForeColor = Color.FromArgb(55, 65, 81);
        lblParams.Location = new Point(18, 34);
        lblParams.Name = "lblParams";
        lblParams.Size = new Size(296, 23);
        lblParams.Text = "Параметры p, x, k (10-я система)";

        txtP.BackColor = Color.White;
        txtP.BorderStyle = BorderStyle.FixedSingle;
        txtP.ForeColor = Color.FromArgb(32, 40, 56);
        txtP.Location = new Point(18, 64);
        txtP.Name = "txtP";
        txtP.PlaceholderText = "p (простое)";
        txtP.Size = new Size(480, 30);
        txtP.TabIndex = 1;

        txtX.BackColor = Color.White;
        txtX.BorderStyle = BorderStyle.FixedSingle;
        txtX.ForeColor = Color.FromArgb(32, 40, 56);
        txtX.Location = new Point(18, 104);
        txtX.Name = "txtX";
        txtX.PlaceholderText = "x ";
        txtX.Size = new Size(480, 30);
        txtX.TabIndex = 2;

        txtK.BackColor = Color.White;
        txtK.BorderStyle = BorderStyle.FixedSingle;
        txtK.ForeColor = Color.FromArgb(32, 40, 56);
        txtK.Location = new Point(18, 144);
        txtK.Name = "txtK";
        txtK.PlaceholderText = "k для 1-го байта ";
        txtK.Size = new Size(480, 30);
        txtK.TabIndex = 3;

        btnFindRoots.BackColor = Color.FromArgb(102, 0, 211);
        btnFindRoots.FlatAppearance.BorderSize = 0;
        btnFindRoots.FlatStyle = FlatStyle.Flat;
        btnFindRoots.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        btnFindRoots.ForeColor = Color.White;
        btnFindRoots.Location = new Point(18, 192);
        btnFindRoots.Name = "btnFindRoots";
        btnFindRoots.Size = new Size(480, 40);
        btnFindRoots.TabIndex = 4;
        btnFindRoots.Text = "Найти первообразные корни";
        btnFindRoots.UseVisualStyleBackColor = false;
        btnFindRoots.Click += BtnFindRoots_Click;

        lblRoots.AutoSize = true;
        lblRoots.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        lblRoots.ForeColor = Color.FromArgb(55, 65, 81);
        lblRoots.Location = new Point(18, 248);
        lblRoots.Name = "lblRoots";
        lblRoots.Size = new Size(355, 20);
        lblRoots.Text = "Выбор первообразного корня g по модулю p";

        cmbG.BackColor = Color.White;
        cmbG.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbG.ForeColor = Color.FromArgb(32, 40, 56);
        cmbG.FormattingEnabled = true;
        cmbG.Location = new Point(18, 274);
        cmbG.Name = "cmbG";
        cmbG.Size = new Size(480, 31);
        cmbG.TabIndex = 5;
        cmbG.Enabled = false;

        lblEncrypt.AutoSize = true;
        lblEncrypt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        lblEncrypt.ForeColor = Color.FromArgb(31, 41, 55);
        lblEncrypt.Location = new Point(18, 34);
        lblEncrypt.Name = "lblEncrypt";
        lblEncrypt.Size = new Size(161, 23);
        lblEncrypt.Text = "Шифрование файла";

        txtEncryptPath.BackColor = Color.White;
        txtEncryptPath.BorderStyle = BorderStyle.FixedSingle;
        txtEncryptPath.ForeColor = Color.FromArgb(32, 40, 56);
        txtEncryptPath.Location = new Point(18, 64);
        txtEncryptPath.Name = "txtEncryptPath";
        txtEncryptPath.ReadOnly = true;
        txtEncryptPath.Size = new Size(500, 30);
        txtEncryptPath.TabIndex = 6;

        btnBrowseEncrypt.BackColor = Color.FromArgb(229, 231, 235);
        btnBrowseEncrypt.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
        btnBrowseEncrypt.FlatStyle = FlatStyle.Flat;
        btnBrowseEncrypt.ForeColor = Color.FromArgb(31, 41, 55);
        btnBrowseEncrypt.Location = new Point(530, 63);
        btnBrowseEncrypt.Name = "btnBrowseEncrypt";
        btnBrowseEncrypt.Size = new Size(110, 32);
        btnBrowseEncrypt.TabIndex = 7;
        btnBrowseEncrypt.Text = "Выбрать";
        btnBrowseEncrypt.UseVisualStyleBackColor = false;
        btnBrowseEncrypt.Click += BtnBrowseEncrypt_Click;

        btnEncrypt.BackColor = Color.FromArgb(16, 185, 129);
        btnEncrypt.FlatAppearance.BorderSize = 0;
        btnEncrypt.FlatStyle = FlatStyle.Flat;
        btnEncrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        btnEncrypt.ForeColor = Color.White;
        btnEncrypt.Location = new Point(18, 108);
        btnEncrypt.Name = "btnEncrypt";
        btnEncrypt.Size = new Size(260, 40);
        btnEncrypt.TabIndex = 8;
        btnEncrypt.Text = "Зашифровать ";
        btnEncrypt.UseVisualStyleBackColor = false;
        btnEncrypt.Click += BtnEncrypt_Click;

        lblDecrypt.AutoSize = true;
        lblDecrypt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
        lblDecrypt.ForeColor = Color.FromArgb(31, 41, 55);
        lblDecrypt.Location = new Point(18, 174);
        lblDecrypt.Name = "lblDecrypt";
        lblDecrypt.Size = new Size(186, 23);
        lblDecrypt.Text = "Дешифрование файла";

        txtDecryptPath.BackColor = Color.White;
        txtDecryptPath.BorderStyle = BorderStyle.FixedSingle;
        txtDecryptPath.ForeColor = Color.FromArgb(32, 40, 56);
        txtDecryptPath.Location = new Point(18, 204);
        txtDecryptPath.Name = "txtDecryptPath";
        txtDecryptPath.ReadOnly = true;
        txtDecryptPath.Size = new Size(500, 30);
        txtDecryptPath.TabIndex = 9;

        btnBrowseDecrypt.BackColor = Color.FromArgb(229, 231, 235);
        btnBrowseDecrypt.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
        btnBrowseDecrypt.FlatStyle = FlatStyle.Flat;
        btnBrowseDecrypt.ForeColor = Color.FromArgb(31, 41, 55);
        btnBrowseDecrypt.Location = new Point(530, 203);
        btnBrowseDecrypt.Name = "btnBrowseDecrypt";
        btnBrowseDecrypt.Size = new Size(110, 32);
        btnBrowseDecrypt.TabIndex = 10;
        btnBrowseDecrypt.Text = "Выбрать";
        btnBrowseDecrypt.UseVisualStyleBackColor = false;
        btnBrowseDecrypt.Click += BtnBrowseDecrypt_Click;

        btnDecrypt.BackColor = Color.FromArgb(139, 0, 0);
        btnDecrypt.FlatAppearance.BorderSize = 0;
        btnDecrypt.FlatStyle = FlatStyle.Flat;
        btnDecrypt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
        btnDecrypt.ForeColor = Color.White;
        btnDecrypt.Location = new Point(18, 248);
        btnDecrypt.Name = "btnDecrypt";
        btnDecrypt.Size = new Size(260, 40);
        btnDecrypt.TabIndex = 11;
        btnDecrypt.Text = "Расшифровать файл";
        btnDecrypt.UseVisualStyleBackColor = false;
        btnDecrypt.Click += BtnDecrypt_Click;

        lblPreview.AutoSize = true;
        lblPreview.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point, 204);
        lblPreview.ForeColor = Color.FromArgb(249, 250, 251);
        lblPreview.Location = new Point(18, 14);
        lblPreview.Name = "lblPreview";
        lblPreview.Size = new Size(521, 21);
        lblPreview.Text = "Содержимое шифротекста в 10-й системе: ";

        txtPreview.BackColor = Color.White;
        txtPreview.BorderStyle = BorderStyle.FixedSingle;
        txtPreview.ForeColor = Color.FromArgb(70, 82, 102);
        txtPreview.Location = new Point(18, 44);
        txtPreview.Multiline = true;
        txtPreview.ReadOnly = true;
        txtPreview.ScrollBars = ScrollBars.Vertical;
        txtPreview.Size = new Size(1186, 222);
        txtPreview.TabIndex = 12;
        txtPreview.TabStop = false;
        txtPreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

        lblStatus.AutoSize = true;
        lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        lblStatus.ForeColor = Color.FromArgb(16, 185, 129);
        lblStatus.Location = new Point(18, 318);
        lblStatus.Name = "lblStatus";
        lblStatus.Size = new Size(0, 20);
        lblStatus.Text = "";

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(0, 0, 128);
        ClientSize = new Size(1224, 820);
        Controls.Add(panelPreview);
        Controls.Add(panelMain);
        Controls.Add(panelHeader);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
        FormBorderStyle = FormBorderStyle.Sizable;
        MaximizeBox = true;
        MinimumSize = new Size(1120, 760);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ЛР3 ";
        panelHeader.ResumeLayout(false);
        panelHeader.PerformLayout();
        panelMain.ResumeLayout(false);
        splitMain.Panel1.ResumeLayout(false);
        splitMain.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
        splitMain.ResumeLayout(false);
        grpParams.ResumeLayout(false);
        grpParams.PerformLayout();
        grpFiles.ResumeLayout(false);
        grpFiles.PerformLayout();
        panelPreview.ResumeLayout(false);
        panelPreview.PerformLayout();
        ResumeLayout(false);
    }
}
