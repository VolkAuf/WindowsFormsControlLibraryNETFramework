
namespace ViberMessengerPlugin
{
    partial class FormInfo
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
            this.buttonGetInfo = new System.Windows.Forms.Button();
            this.labelSubs = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelWebhook = new System.Windows.Forms.Label();
            this.labelToken = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBotSubs = new System.Windows.Forms.Label();
            this.labelBotOwner = new System.Windows.Forms.Label();
            this.labelBotWebhook = new System.Windows.Forms.Label();
            this.labelBotToken = new System.Windows.Forms.Label();
            this.labelBotName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGetInfo
            // 
            this.buttonGetInfo.Location = new System.Drawing.Point(215, 256);
            this.buttonGetInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGetInfo.Name = "buttonGetInfo";
            this.buttonGetInfo.Size = new System.Drawing.Size(339, 58);
            this.buttonGetInfo.TabIndex = 21;
            this.buttonGetInfo.Text = "Получить информацию";
            this.buttonGetInfo.UseVisualStyleBackColor = true;
            this.buttonGetInfo.Click += new System.EventHandler(this.buttonGetInfo_Click);
            // 
            // labelSubs
            // 
            this.labelSubs.AutoSize = true;
            this.labelSubs.Location = new System.Drawing.Point(323, 206);
            this.labelSubs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubs.Name = "labelSubs";
            this.labelSubs.Size = new System.Drawing.Size(0, 17);
            this.labelSubs.TabIndex = 20;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(323, 158);
            this.labelOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(0, 17);
            this.labelOwner.TabIndex = 19;
            // 
            // labelWebhook
            // 
            this.labelWebhook.AutoSize = true;
            this.labelWebhook.Location = new System.Drawing.Point(323, 115);
            this.labelWebhook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWebhook.Name = "labelWebhook";
            this.labelWebhook.Size = new System.Drawing.Size(0, 17);
            this.labelWebhook.TabIndex = 18;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(323, 71);
            this.labelToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(0, 17);
            this.labelToken.TabIndex = 17;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(319, 27);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 17);
            this.labelName.TabIndex = 16;
            // 
            // labelBotSubs
            // 
            this.labelBotSubs.AutoSize = true;
            this.labelBotSubs.Location = new System.Drawing.Point(12, 206);
            this.labelBotSubs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBotSubs.Name = "labelBotSubs";
            this.labelBotSubs.Size = new System.Drawing.Size(146, 17);
            this.labelBotSubs.TabIndex = 15;
            this.labelBotSubs.Text = "Кол-во подписчиков:";
            // 
            // labelBotOwner
            // 
            this.labelBotOwner.AutoSize = true;
            this.labelBotOwner.Location = new System.Drawing.Point(12, 158);
            this.labelBotOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBotOwner.Name = "labelBotOwner";
            this.labelBotOwner.Size = new System.Drawing.Size(77, 17);
            this.labelBotOwner.TabIndex = 14;
            this.labelBotOwner.Text = "Владелец:";
            // 
            // labelBotWebhook
            // 
            this.labelBotWebhook.AutoSize = true;
            this.labelBotWebhook.Location = new System.Drawing.Point(12, 115);
            this.labelBotWebhook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBotWebhook.Name = "labelBotWebhook";
            this.labelBotWebhook.Size = new System.Drawing.Size(57, 17);
            this.labelBotWebhook.TabIndex = 13;
            this.labelBotWebhook.Text = "Вебхук:";
            // 
            // labelBotToken
            // 
            this.labelBotToken.AutoSize = true;
            this.labelBotToken.Location = new System.Drawing.Point(12, 71);
            this.labelBotToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBotToken.Name = "labelBotToken";
            this.labelBotToken.Size = new System.Drawing.Size(52, 17);
            this.labelBotToken.TabIndex = 12;
            this.labelBotToken.Text = "Токен:";
            // 
            // labelBotName
            // 
            this.labelBotName.AutoSize = true;
            this.labelBotName.Location = new System.Drawing.Point(13, 27);
            this.labelBotName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBotName.Name = "labelBotName";
            this.labelBotName.Size = new System.Drawing.Size(39, 17);
            this.labelBotName.TabIndex = 11;
            this.labelBotName.Text = "Имя:";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 334);
            this.Controls.Add(this.buttonGetInfo);
            this.Controls.Add(this.labelSubs);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.labelWebhook);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelBotSubs);
            this.Controls.Add(this.labelBotOwner);
            this.Controls.Add(this.labelBotWebhook);
            this.Controls.Add(this.labelBotToken);
            this.Controls.Add(this.labelBotName);
            this.Name = "FormInfo";
            this.Text = "FormInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetInfo;
        private System.Windows.Forms.Label labelSubs;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelWebhook;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBotSubs;
        private System.Windows.Forms.Label labelBotOwner;
        private System.Windows.Forms.Label labelBotWebhook;
        private System.Windows.Forms.Label labelBotToken;
        private System.Windows.Forms.Label labelBotName;
    }
}