
namespace BookStorageView
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчотПоЧитателямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчотПоКнигамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дианграммаПоФормамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableComponent = new NonVisualComponentsLibrary.TableComponent(this.components);
            this.documentWithDiagram = new Library_NotVisualComponents.DocumentWithDiagram(this.components);
            this.componentWordContextTables = new WindowsFormsComponentLibrary.ComponentWordContextTables(this.components);
            this.controlOutputlListBox = new ClassLibraryControlsFilippov.ControlOutputlListBox();
            this.формаНигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьКнигуToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.отчотПоЧитателямToolStripMenuItem,
            this.отчотПоКнигамToolStripMenuItem,
            this.дианграммаПоФормамToolStripMenuItem,
            this.добавитьЧитателяToolStripMenuItem,
            this.формаНигиToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(303, 224);
            // 
            // добавитьКнигуToolStripMenuItem
            // 
            this.добавитьКнигуToolStripMenuItem.Name = "добавитьКнигуToolStripMenuItem";
            this.добавитьКнигуToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.добавитьКнигуToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.добавитьКнигуToolStripMenuItem.Text = "Добавить Книгу";
            this.добавитьКнигуToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // отчотПоЧитателямToolStripMenuItem
            // 
            this.отчотПоЧитателямToolStripMenuItem.Name = "отчотПоЧитателямToolStripMenuItem";
            this.отчотПоЧитателямToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.отчотПоЧитателямToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.отчотПоЧитателямToolStripMenuItem.Text = "Отчот по читателям";
            this.отчотПоЧитателямToolStripMenuItem.Click += new System.EventHandler(this.отчотПоЧитателямToolStripMenuItem_Click);
            // 
            // отчотПоКнигамToolStripMenuItem
            // 
            this.отчотПоКнигамToolStripMenuItem.Name = "отчотПоКнигамToolStripMenuItem";
            this.отчотПоКнигамToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.отчотПоКнигамToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.отчотПоКнигамToolStripMenuItem.Text = "Отчот по книгам";
            this.отчотПоКнигамToolStripMenuItem.Click += new System.EventHandler(this.отчотПоКнигамToolStripMenuItem_Click);
            // 
            // дианграммаПоФормамToolStripMenuItem
            // 
            this.дианграммаПоФормамToolStripMenuItem.Name = "дианграммаПоФормамToolStripMenuItem";
            this.дианграммаПоФормамToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.дианграммаПоФормамToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.дианграммаПоФормамToolStripMenuItem.Text = "Дианграмма по формам";
            this.дианграммаПоФормамToolStripMenuItem.Click += new System.EventHandler(this.дианграммаПоФормамToolStripMenuItem_Click);
            // 
            // добавитьЧитателяToolStripMenuItem
            // 
            this.добавитьЧитателяToolStripMenuItem.Name = "добавитьЧитателяToolStripMenuItem";
            this.добавитьЧитателяToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.добавитьЧитателяToolStripMenuItem.Text = "Добавить читателя";
            this.добавитьЧитателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧитателяToolStripMenuItem_Click);
            // 
            // tableComponent
            // 
            this.tableComponent.ErrorMessage = null;
            // 
            // controlOutputlListBox
            // 
            this.controlOutputlListBox.Location = new System.Drawing.Point(13, 13);
            this.controlOutputlListBox.Name = "controlOutputlListBox";
            this.controlOutputlListBox.SelectedIndex = -1;
            this.controlOutputlListBox.Size = new System.Drawing.Size(1328, 425);
            this.controlOutputlListBox.TabIndex = 1;
            this.controlOutputlListBox.Load += new System.EventHandler(this.controlOutputlListBox_Load);
            // 
            // формаНигиToolStripMenuItem
            // 
            this.формаНигиToolStripMenuItem.Name = "формаНигиToolStripMenuItem";
            this.формаНигиToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.формаНигиToolStripMenuItem.Text = "Форма ниги";
            this.формаНигиToolStripMenuItem.Click += new System.EventHandler(this.формаНигиToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.controlOutputlListBox);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчотПоЧитателямToolStripMenuItem;
        private WindowsFormsComponentLibrary.ComponentWordContextTables componentWordContextTables;
        private System.Windows.Forms.ToolStripMenuItem отчотПоКнигамToolStripMenuItem;
        private NonVisualComponentsLibrary.TableComponent tableComponent;
        private System.Windows.Forms.ToolStripMenuItem дианграммаПоФормамToolStripMenuItem;
        private Library_NotVisualComponents.DocumentWithDiagram documentWithDiagram;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧитателяToolStripMenuItem;
        private ClassLibraryControlsFilippov.ControlOutputlListBox controlOutputlListBox;
        private System.Windows.Forms.ToolStripMenuItem формаНигиToolStripMenuItem;
    }
}