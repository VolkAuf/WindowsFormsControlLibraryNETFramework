
namespace BookStorageView
{
    partial class FormBook
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.labelAnnotation = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.userControlListBox = new WindowsFormsControlLibrary.UserControlListBox();
            this.inputUserControl = new VisualComponentsLibrary.InputUserControl();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(64, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(128, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Location = new System.Drawing.Point(13, 56);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(40, 17);
            this.labelForm.TabIndex = 2;
            this.labelForm.Text = "Form";
            // 
            // labelAnnotation
            // 
            this.labelAnnotation.AutoSize = true;
            this.labelAnnotation.Location = new System.Drawing.Point(16, 281);
            this.labelAnnotation.Name = "labelAnnotation";
            this.labelAnnotation.Size = new System.Drawing.Size(76, 17);
            this.labelAnnotation.TabIndex = 5;
            this.labelAnnotation.Text = "Annotation";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(263, 325);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(344, 325);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // userControlListBox
            // 
            this.userControlListBox.Location = new System.Drawing.Point(59, 34);
            this.userControlListBox.Name = "userControlListBox";
            this.userControlListBox.SelectedElement = "";
            this.userControlListBox.Size = new System.Drawing.Size(353, 240);
            this.userControlListBox.TabIndex = 9;
            this.userControlListBox.Load += new System.EventHandler(this.userControlListBox1_Load);
            // 
            // inputUserControl
            // 
            this.inputUserControl.Location = new System.Drawing.Point(113, 281);
            this.inputUserControl.Name = "inputUserControl";
            this.inputUserControl.Size = new System.Drawing.Size(150, 38);
            this.inputUserControl.TabIndex = 10;
            this.inputUserControl.maxLength = 200;
            this.inputUserControl.minLength = 100;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 366);
            this.Controls.Add(this.inputUserControl);
            this.Controls.Add(this.userControlListBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelAnnotation);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.Label labelAnnotation;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private WindowsFormsControlLibrary.UserControlListBox userControlListBox;
        private VisualComponentsLibrary.InputUserControl inputUserControl;
    }
}