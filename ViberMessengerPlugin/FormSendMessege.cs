using BookStorageBusinessLogic.Plugins.HelperModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Viber.Bot;

namespace ViberMessengerPlugin
{
    public partial class FormSendMessege : Form
    {
        private ViberBotClient _viberBotClient;
        public FormSendMessege(SendMessageModel message)
        {

            InitializeComponent();
            textBoxReciever.Text = "w4jEN3PoWhWwQ+FLKwpWzQ==";
            _viberBotClient = new ViberBotClient("4e74b0771467d558-bcb33d7417efdb25-a06987c41b285dc6");
        }

        public async Task SendTextMessageAsyncTest()
        {
            var result = await _viberBotClient.SendTextMessageAsync(new TextMessage
            {
                Receiver = textBoxReciever.Text,
                Sender = new UserBase
                {
                    Name = "RafaelBot"
                },
                Text = textBoxMessege.Text
            });
            return;
        }

        private void buttonSendMessege_Click(object sender, EventArgs e)
        {
            var result = SendTextMessageAsyncTest();
            if (result != null)
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
