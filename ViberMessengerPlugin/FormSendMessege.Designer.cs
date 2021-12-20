
namespace ViberMessengerPlugin
{
    partial class FormSendMessege
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
            this.textBoxMessege = new System.Windows.Forms.TextBox();
            this.textBoxReciever = new System.Windows.Forms.TextBox();
            this.buttonSendMessege = new System.Windows.Forms.Button();
            this.labelMessege = new System.Windows.Forms.Label();
            this.labelReciever = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMessege
            // 
            this.textBoxMessege.Location = new System.Drawing.Point(196, 90);
            this.textBoxMessege.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMessege.Name = "textBoxMessege";
            this.textBoxMessege.Size = new System.Drawing.Size(352, 22);
            this.textBoxMessege.TabIndex = 9;
            // 
            // textBoxReciever
            // 
            this.textBoxReciever.Location = new System.Drawing.Point(196, 25);
            this.textBoxReciever.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxReciever.Name = "textBoxReciever";
            this.textBoxReciever.Size = new System.Drawing.Size(352, 22);
            this.textBoxReciever.TabIndex = 8;
            // 
            // buttonSendMessege
            // 
            this.buttonSendMessege.Location = new System.Drawing.Point(173, 160);
            this.buttonSendMessege.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendMessege.Name = "buttonSendMessege";
            this.buttonSendMessege.Size = new System.Drawing.Size(271, 31);
            this.buttonSendMessege.TabIndex = 7;
            this.buttonSendMessege.Text = "Отправить сообщение";
            this.buttonSendMessege.UseVisualStyleBackColor = true;
            this.buttonSendMessege.Click += new System.EventHandler(this.buttonSendMessege_Click);
            // 
            // labelMessege
            // 
            this.labelMessege.AutoSize = true;
            this.labelMessege.Location = new System.Drawing.Point(13, 98);
            this.labelMessege.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMessege.Name = "labelMessege";
            this.labelMessege.Size = new System.Drawing.Size(128, 17);
            this.labelMessege.TabIndex = 6;
            this.labelMessege.Text = "Текст сообщения:";
            // 
            // labelReciever
            // 
            this.labelReciever.AutoSize = true;
            this.labelReciever.Location = new System.Drawing.Point(13, 34);
            this.labelReciever.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReciever.Name = "labelReciever";
            this.labelReciever.Size = new System.Drawing.Size(91, 17);
            this.labelReciever.TabIndex = 5;
            this.labelReciever.Text = "Получатель:";
            // 
            // FormSendMessege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 216);
            this.Controls.Add(this.textBoxMessege);
            this.Controls.Add(this.textBoxReciever);
            this.Controls.Add(this.buttonSendMessege);
            this.Controls.Add(this.labelMessege);
            this.Controls.Add(this.labelReciever);
            this.Name = "FormSendMessege";
            this.Text = "FormSendMessege";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessege;
        private System.Windows.Forms.TextBox textBoxReciever;
        private System.Windows.Forms.Button buttonSendMessege;
        private System.Windows.Forms.Label labelMessege;
        private System.Windows.Forms.Label labelReciever;
    }
}