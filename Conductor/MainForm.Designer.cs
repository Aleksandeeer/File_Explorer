namespace Conductor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.MainWebBrowser = new System.Windows.Forms.WebBrowser();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NoteBookTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WordTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PowerPointTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ExcelTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.PathLabel = new System.Windows.Forms.ToolStripLabel();
            this.PathTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).BeginInit();
            this.MainSplitContainer.Panel1.SuspendLayout();
            this.MainSplitContainer.Panel2.SuspendLayout();
            this.MainSplitContainer.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainSplitContainer
            // 
            this.MainSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainSplitContainer.Location = new System.Drawing.Point(0, 58);
            this.MainSplitContainer.Name = "MainSplitContainer";
            // 
            // MainSplitContainer.Panel1
            // 
            this.MainSplitContainer.Panel1.Controls.Add(this.MainTreeView);
            // 
            // MainSplitContainer.Panel2
            // 
            this.MainSplitContainer.Panel2.Controls.Add(this.MainWebBrowser);
            this.MainSplitContainer.Size = new System.Drawing.Size(951, 464);
            this.MainSplitContainer.SplitterDistance = 316;
            this.MainSplitContainer.TabIndex = 0;
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(316, 464);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseClick);
            // 
            // MainWebBrowser
            // 
            this.MainWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.MainWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.MainWebBrowser.Name = "MainWebBrowser";
            this.MainWebBrowser.Size = new System.Drawing.Size(631, 464);
            this.MainWebBrowser.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTSMI});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(951, 28);
            this.MainMenuStrip.TabIndex = 1;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileTSMI
            // 
            this.FileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTSMI,
            this.CloseTSMI});
            this.FileTSMI.Name = "FileTSMI";
            this.FileTSMI.Size = new System.Drawing.Size(59, 24);
            this.FileTSMI.Text = "Файл";
            // 
            // CreateTSMI
            // 
            this.CreateTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderTSMI,
            this.NoteBookTSMI,
            this.WordTSMI,
            this.PowerPointTSMI,
            this.ExcelTSMI});
            this.CreateTSMI.Name = "CreateTSMI";
            this.CreateTSMI.Size = new System.Drawing.Size(202, 26);
            this.CreateTSMI.Text = "Создать";
            // 
            // FolderTSMI
            // 
            this.FolderTSMI.Name = "FolderTSMI";
            this.FolderTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FolderTSMI.Size = new System.Drawing.Size(215, 26);
            this.FolderTSMI.Text = "Папка";
            this.FolderTSMI.Click += new System.EventHandler(this.FolderTSMI_Click);
            // 
            // NoteBookTSMI
            // 
            this.NoteBookTSMI.Name = "NoteBookTSMI";
            this.NoteBookTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.NoteBookTSMI.Size = new System.Drawing.Size(215, 26);
            this.NoteBookTSMI.Text = "Блокнот";
            this.NoteBookTSMI.Click += new System.EventHandler(this.NoteBookTSMI_Click);
            // 
            // WordTSMI
            // 
            this.WordTSMI.Name = "WordTSMI";
            this.WordTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.WordTSMI.Size = new System.Drawing.Size(215, 26);
            this.WordTSMI.Text = "Word";
            this.WordTSMI.Click += new System.EventHandler(this.WordTSMI_Click);
            // 
            // PowerPointTSMI
            // 
            this.PowerPointTSMI.Name = "PowerPointTSMI";
            this.PowerPointTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PowerPointTSMI.Size = new System.Drawing.Size(215, 26);
            this.PowerPointTSMI.Text = "PowerPoint";
            this.PowerPointTSMI.Click += new System.EventHandler(this.PowerPointTSMI_Click);
            // 
            // ExcelTSMI
            // 
            this.ExcelTSMI.Name = "ExcelTSMI";
            this.ExcelTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.ExcelTSMI.Size = new System.Drawing.Size(215, 26);
            this.ExcelTSMI.Text = "Excel";
            this.ExcelTSMI.Click += new System.EventHandler(this.ExcelTSMI_Click);
            // 
            // CloseTSMI
            // 
            this.CloseTSMI.Name = "CloseTSMI";
            this.CloseTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.CloseTSMI.Size = new System.Drawing.Size(202, 26);
            this.CloseTSMI.Text = "Закрыть";
            this.CloseTSMI.Click += new System.EventHandler(this.CloseTSMI_Click);
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.PathLabel,
            this.PathTextBox,
            this.OpenButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 28);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(951, 27);
            this.MainToolStrip.TabIndex = 2;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 24);
            this.BackButton.Text = "Назад";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ForwardButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardButton.Image")));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(64, 24);
            this.ForwardButton.Text = "Вперёд";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(44, 24);
            this.PathLabel.Text = "Путь:";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(400, 27);
            this.PathTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PathTextBox_KeyUp);
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(71, 24);
            this.OpenButton.Text = "Открыть";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 522);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainSplitContainer);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Проводник";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainSplitContainer.Panel1.ResumeLayout(false);
            this.MainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplitContainer)).EndInit();
            this.MainSplitContainer.ResumeLayout(false);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer MainSplitContainer;
        private System.Windows.Forms.TreeView MainTreeView;
        private new System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripLabel PathLabel;
        private System.Windows.Forms.ToolStripTextBox PathTextBox;
        private System.Windows.Forms.WebBrowser MainWebBrowser;
        private System.Windows.Forms.ToolStripButton OpenButton;
        private System.Windows.Forms.ToolStripMenuItem FileTSMI;
        private System.Windows.Forms.ToolStripMenuItem CreateTSMI;
        private System.Windows.Forms.ToolStripMenuItem FolderTSMI;
        private System.Windows.Forms.ToolStripMenuItem NoteBookTSMI;
        private System.Windows.Forms.ToolStripMenuItem WordTSMI;
        private System.Windows.Forms.ToolStripMenuItem PowerPointTSMI;
        private System.Windows.Forms.ToolStripMenuItem ExcelTSMI;
        private System.Windows.Forms.ToolStripMenuItem CloseTSMI;
    }
}

