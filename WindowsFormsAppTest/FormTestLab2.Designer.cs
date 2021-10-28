
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
            this.componentWordContextTables = new WindowsFormsComponentLibrary.ComponentWordContextTables(this.components);
            this.componentWordDiagram = new WindowsFormsComponentLibrary.ComponentWordDiagram(this.components);
            this.componentWordMultyTable = new WindowsFormsComponentLibrary.ComponentWordMultyTable(this.components);
            this.buttonContextTableInvoke = new System.Windows.Forms.Button();
            this.buttonDiagramInvoke = new System.Windows.Forms.Button();
            this.buttonMultyTableInvoke = new System.Windows.Forms.Button();
            this.textBoxCountTables = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelSizeTables = new System.Windows.Forms.Label();
            this.labelCountTables = new System.Windows.Forms.Label();
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
            // 
            // buttonMultyTableInvoke
            // 
            this.buttonMultyTableInvoke.Location = new System.Drawing.Point(141, 12);
            this.buttonMultyTableInvoke.Name = "buttonMultyTableInvoke";
            this.buttonMultyTableInvoke.Size = new System.Drawing.Size(105, 37);
            this.buttonMultyTableInvoke.TabIndex = 2;
            this.buttonMultyTableInvoke.Text = "Multy Table";
            this.buttonMultyTableInvoke.UseVisualStyleBackColor = true;
            // 
            // textBoxCountTables
            // 
            this.textBoxCountTables.Location = new System.Drawing.Point(12, 170);
            this.textBoxCountTables.Name = "textBoxCountTables";
            this.textBoxCountTables.Size = new System.Drawing.Size(100, 22);
            this.textBoxCountTables.TabIndex = 3;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(12, 93);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
            this.textBoxHeight.TabIndex = 4;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(12, 121);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 22);
            this.textBoxWidth.TabIndex = 5;
            // 
            // labelSizeTables
            // 
            this.labelSizeTables.AutoSize = true;
            this.labelSizeTables.Location = new System.Drawing.Point(12, 73);
            this.labelSizeTables.Name = "labelSizeTables";
            this.labelSizeTables.Size = new System.Drawing.Size(77, 17);
            this.labelSizeTables.TabIndex = 6;
            this.labelSizeTables.Text = "Size tables";
            // 
            // labelCountTables
            // 
            this.labelCountTables.AutoSize = true;
            this.labelCountTables.Location = new System.Drawing.Point(12, 150);
            this.labelCountTables.Name = "labelCountTables";
            this.labelCountTables.Size = new System.Drawing.Size(87, 17);
            this.labelCountTables.TabIndex = 7;
            this.labelCountTables.Text = "Count tables";
            // 
            // FormTestLab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCountTables);
            this.Controls.Add(this.labelSizeTables);
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
        private System.Windows.Forms.Label labelSizeTables;
        private System.Windows.Forms.Label labelCountTables;
    }
}