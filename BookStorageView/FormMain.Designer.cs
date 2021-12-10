
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
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчотПоЧитателямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчотПоКнигамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дианграммаПоФормамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentWordContextTables = new WindowsFormsComponentLibrary.ComponentWordContextTables(this.components);
            this.tableComponent = new NonVisualComponentsLibrary.TableComponent(this.components);
            this.documentWithDiagram = new Library_NotVisualComponents.DocumentWithDiagram(this.components);
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.отчотПоЧитателямToolStripMenuItem,
            this.отчотПоКнигамToolStripMenuItem,
            this.дианграммаПоФормамToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(252, 148);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // отчотПоЧитателямToolStripMenuItem
            // 
            this.отчотПоЧитателямToolStripMenuItem.Name = "отчотПоЧитателямToolStripMenuItem";
            this.отчотПоЧитателямToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.отчотПоЧитателямToolStripMenuItem.Text = "Отчот по читателям";
            this.отчотПоЧитателямToolStripMenuItem.Click += new System.EventHandler(this.отчотПоЧитателямToolStripMenuItem_Click);
            // 
            // отчотПоКнигамToolStripMenuItem
            // 
            this.отчотПоКнигамToolStripMenuItem.Name = "отчотПоКнигамToolStripMenuItem";
            this.отчотПоКнигамToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.отчотПоКнигамToolStripMenuItem.Text = "Отчот по книгам";
            this.отчотПоКнигамToolStripMenuItem.Click += new System.EventHandler(this.отчотПоКнигамToolStripMenuItem_Click);
            // 
            // дианграммаПоФормамToolStripMenuItem
            // 
            this.дианграммаПоФормамToolStripMenuItem.Name = "дианграммаПоФормамToolStripMenuItem";
            this.дианграммаПоФормамToolStripMenuItem.Size = new System.Drawing.Size(251, 24);
            this.дианграммаПоФормамToolStripMenuItem.Text = "Дианграмма по формам";
            this.дианграммаПоФормамToolStripMenuItem.Click += new System.EventHandler(this.дианграммаПоФормамToolStripMenuItem_Click);
            // 
            // tableComponent
            // 
            this.tableComponent.ErrorMessage = null;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчотПоЧитателямToolStripMenuItem;
        private WindowsFormsComponentLibrary.ComponentWordContextTables componentWordContextTables;
        private System.Windows.Forms.ToolStripMenuItem отчотПоКнигамToolStripMenuItem;
        private NonVisualComponentsLibrary.TableComponent tableComponent;
        private System.Windows.Forms.ToolStripMenuItem дианграммаПоФормамToolStripMenuItem;
        private Library_NotVisualComponents.DocumentWithDiagram documentWithDiagram;
    }
}