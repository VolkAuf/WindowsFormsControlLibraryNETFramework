
namespace WindowsFormsAppTest
{
    partial class FormTest
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
            this.userControlListBox = new WindowsFormsControlLibrary.UserControlListBox();
            this.userControlTextBox = new WindowsFormsControlLibrary.UserControlTextBox();
            this.userControlDataGridView = new WindowsFormsControlLibrary.UserControlDataGridView();
            this.componentWordContextTables = new WindowsFormsComponentLibrary.ComponentWordContextTables(this.components);
            this.componentWordMultyTable = new WindowsFormsComponentLibrary.ComponentWordMultyTable(this.components);
            this.userControlListBox1 = new WindowsFormsControlLibrary.UserControlListBox();
            this.userControlTextBox1 = new WindowsFormsControlLibrary.UserControlTextBox();
            this.SuspendLayout();
            // 
            // userControlListBox
            // 
            this.userControlListBox.Location = new System.Drawing.Point(12, 12);
            this.userControlListBox.Name = "userControlListBox";
            this.userControlListBox.SelectedElement = "";
            this.userControlListBox.Size = new System.Drawing.Size(353, 240);
            this.userControlListBox.TabIndex = 1;
            // 
            // userControlTextBox
            // 
            this.userControlTextBox.Location = new System.Drawing.Point(23, 240);
            this.userControlTextBox.Name = "userControlTextBox";
            this.userControlTextBox.Size = new System.Drawing.Size(333, 53);
            this.userControlTextBox.TabIndex = 2;
            // 
            // userControlDataGridView
            // 
            this.userControlDataGridView.Location = new System.Drawing.Point(371, 12);
            this.userControlDataGridView.Name = "userControlDataGridView";
            this.userControlDataGridView.SelectedRowIndex = -1;
            this.userControlDataGridView.Size = new System.Drawing.Size(494, 266);
            this.userControlDataGridView.TabIndex = 3;
            // 
            // userControlListBox1
            // 
            this.userControlListBox1.Location = new System.Drawing.Point(12, 12);
            this.userControlListBox1.Name = "userControlListBox1";
            this.userControlListBox1.SelectedElement = "";
            this.userControlListBox1.Size = new System.Drawing.Size(353, 240);
            this.userControlListBox1.TabIndex = 1;
            // 
            // userControlTextBox1
            // 
            this.userControlTextBox1.Location = new System.Drawing.Point(12, 239);
            this.userControlTextBox1.Name = "userControlTextBox1";
            this.userControlTextBox1.Size = new System.Drawing.Size(333, 53);
            this.userControlTextBox1.TabIndex = 2;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.userControlDataGridView);
            this.Controls.Add(this.userControlTextBox);
            this.Controls.Add(this.userControlListBox);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);

        }

        #endregion
        private WindowsFormsControlLibrary.UserControlListBox userControlListBox;
        private WindowsFormsControlLibrary.UserControlTextBox userControlTextBox;
        private WindowsFormsControlLibrary.UserControlDataGridView userControlDataGridView;
        private WindowsFormsComponentLibrary.ComponentWordContextTables componentWordContextTables;
        private WindowsFormsComponentLibrary.ComponentWordMultyTable componentWordMultyTable;
        private WindowsFormsControlLibrary.UserControlListBox userControlListBox1;
        private WindowsFormsControlLibrary.UserControlTextBox userControlTextBox1;
    }
}