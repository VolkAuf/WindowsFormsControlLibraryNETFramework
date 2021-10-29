
namespace WindowsFormsAppTest
{
    partial class FormTestLab2
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
            this.buttonContextTableInvoke = new System.Windows.Forms.Button();
            this.buttonDiagramInvoke = new System.Windows.Forms.Button();
            this.buttonMultyTableInvoke = new System.Windows.Forms.Button();
            this.textBoxCountTables = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelCountTables = new System.Windows.Forms.Label();
            this.labelMultyHeight = new System.Windows.Forms.Label();
            this.textBoxWIdthMultyT = new System.Windows.Forms.TextBox();
            this.textBoxHeightMultyT = new System.Windows.Forms.TextBox();
            this.componentWordContextTables = new WindowsFormsComponentLibrary.ComponentWordContextTables(this.components);
            this.componentWordDiagram = new WindowsFormsComponentLibrary.ComponentWordDiagram(this.components);
            this.componentWordMultyTable = new WindowsFormsComponentLibrary.ComponentWordMultyTable(this.components);
            this.labelTablesHeight = new System.Windows.Forms.Label();
            this.labelTablesWidth = new System.Windows.Forms.Label();
            this.labelMultyWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonContextTableInvoke
            // 
            this.buttonContextTableInvoke.Location = new System.Drawing.Point(13, 13);
            this.buttonContextTableInvoke.Name = "buttonContextTableInvoke";
            this.buttonContextTableInvoke.Size = new System.Drawing.Size(105, 36);
            this.buttonContextTableInvoke.TabIndex = 0;
            this.buttonContextTableInvoke.Text = "ContextTable";
            this.buttonContextTableInvoke.UseVisualStyleBackColor = true;
            this.buttonContextTableInvoke.Click += new System.EventHandler(this.buttonContextTableInvoke_Click);
            // 
            // buttonDiagramInvoke
            // 
            this.buttonDiagramInvoke.Location = new System.Drawing.Point(279, 12);
            this.buttonDiagramInvoke.Name = "buttonDiagramInvoke";
            this.buttonDiagramInvoke.Size = new System.Drawing.Size(105, 37);
            this.buttonDiagramInvoke.TabIndex = 1;
            this.buttonDiagramInvoke.Text = "Diagram";
            this.buttonDiagramInvoke.UseVisualStyleBackColor = true;
            this.buttonDiagramInvoke.Click += new System.EventHandler(this.buttonDiagramInvoke_Click);
            // 
            // buttonMultyTableInvoke
            // 
            this.buttonMultyTableInvoke.Location = new System.Drawing.Point(141, 12);
            this.buttonMultyTableInvoke.Name = "buttonMultyTableInvoke";
            this.buttonMultyTableInvoke.Size = new System.Drawing.Size(105, 37);
            this.buttonMultyTableInvoke.TabIndex = 2;
            this.buttonMultyTableInvoke.Text = "Multy Table";
            this.buttonMultyTableInvoke.UseVisualStyleBackColor = true;
            this.buttonMultyTableInvoke.Click += new System.EventHandler(this.buttonMultyTableInvoke_Click);
            // 
            // textBoxCountTables
            // 
            this.textBoxCountTables.Location = new System.Drawing.Point(13, 189);
            this.textBoxCountTables.Name = "textBoxCountTables";
            this.textBoxCountTables.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountTables.TabIndex = 3;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(13, 91);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 4;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(13, 140);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidth.TabIndex = 5;
            // 
            // labelCountTables
            // 
            this.labelCountTables.AutoSize = true;
            this.labelCountTables.Location = new System.Drawing.Point(13, 169);
            this.labelCountTables.Name = "labelCountTables";
            this.labelCountTables.Size = new System.Drawing.Size(87, 17);
            this.labelCountTables.TabIndex = 7;
            this.labelCountTables.Text = "Count tables";
            // 
            // labelMultyHeight
            // 
            this.labelMultyHeight.AutoSize = true;
            this.labelMultyHeight.Location = new System.Drawing.Point(138, 73);
            this.labelMultyHeight.Name = "labelMultyHeight";
            this.labelMultyHeight.Size = new System.Drawing.Size(49, 17);
            this.labelMultyHeight.TabIndex = 13;
            this.labelMultyHeight.Text = "Height";
            // 
            // textBoxWIdthMultyT
            // 
            this.textBoxWIdthMultyT.Location = new System.Drawing.Point(138, 140);
            this.textBoxWIdthMultyT.Name = "textBoxWIdthMultyT";
            this.textBoxWIdthMultyT.Size = new System.Drawing.Size(100, 22);
            this.textBoxWIdthMultyT.TabIndex = 12;
            // 
            // textBoxHeightMultyT
            // 
            this.textBoxHeightMultyT.Location = new System.Drawing.Point(138, 93);
            this.textBoxHeightMultyT.Name = "textBoxHeightMultyT";
            this.textBoxHeightMultyT.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeightMultyT.TabIndex = 11;
            // 
            // labelTablesHeight
            // 
            this.labelTablesHeight.AutoSize = true;
            this.labelTablesHeight.Location = new System.Drawing.Point(11, 71);
            this.labelTablesHeight.Name = "labelTablesHeight";
            this.labelTablesHeight.Size = new System.Drawing.Size(49, 17);
            this.labelTablesHeight.TabIndex = 15;
            this.labelTablesHeight.Text = "Height";
            // 
            // labelTablesWidth
            // 
            this.labelTablesWidth.AutoSize = true;
            this.labelTablesWidth.Location = new System.Drawing.Point(11, 120);
            this.labelTablesWidth.Name = "labelTablesWidth";
            this.labelTablesWidth.Size = new System.Drawing.Size(44, 17);
            this.labelTablesWidth.TabIndex = 16;
            this.labelTablesWidth.Text = "Width";
            // 
            // labelMultyWidth
            // 
            this.labelMultyWidth.AutoSize = true;
            this.labelMultyWidth.Location = new System.Drawing.Point(138, 120);
            this.labelMultyWidth.Name = "labelMultyWidth";
            this.labelMultyWidth.Size = new System.Drawing.Size(44, 17);
            this.labelMultyWidth.TabIndex = 17;
            this.labelMultyWidth.Text = "Width";
            // 
            // FormTestLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMultyWidth);
            this.Controls.Add(this.labelTablesWidth);
            this.Controls.Add(this.labelTablesHeight);
            this.Controls.Add(this.labelMultyHeight);
            this.Controls.Add(this.textBoxWIdthMultyT);
            this.Controls.Add(this.textBoxHeightMultyT);
            this.Controls.Add(this.labelCountTables);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxCountTables);
            this.Controls.Add(this.buttonMultyTableInvoke);
            this.Controls.Add(this.buttonDiagramInvoke);
            this.Controls.Add(this.buttonContextTableInvoke);
            this.Name = "FormTestLab2";
            this.Text = "FormTestLab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsComponentLibrary.ComponentWordContextTables componentWordContextTables;
        private WindowsFormsComponentLibrary.ComponentWordDiagram componentWordDiagram;
        private WindowsFormsComponentLibrary.ComponentWordMultyTable componentWordMultyTable;
        private System.Windows.Forms.Button buttonContextTableInvoke;
        private System.Windows.Forms.Button buttonDiagramInvoke;
        private System.Windows.Forms.Button buttonMultyTableInvoke;
        private System.Windows.Forms.TextBox textBoxCountTables;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelCountTables;
        private System.Windows.Forms.Label labelMultyHeight;
        private System.Windows.Forms.TextBox textBoxWIdthMultyT;
        private System.Windows.Forms.TextBox textBoxHeightMultyT;
        private System.Windows.Forms.Label labelTablesHeight;
        private System.Windows.Forms.Label labelTablesWidth;
        private System.Windows.Forms.Label labelMultyWidth;
    }
}