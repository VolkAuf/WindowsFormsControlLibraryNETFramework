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
    public partial class FormInfo : Form
    {
        private string authToken;
        public FormInfo(SenderConfiguratorModel config)
        {
            InitializeComponent();

            authToken = "4e74b0771467d558-bcb33d7417efdb25-a06987c41b285dc6";
        }

        private void buttonGetInfo_Click(object sender, EventArgs e)
        {
            var _viberBotClient = new ViberBotClient(authToken);
            _ = GetAccountInfoAsyncTest(_viberBotClient);
        }

        public async Task GetAccountInfoAsyncTest(ViberBotClient viberBotClient)
        {
            var result = await viberBotClient.GetAccountInfoAsync();
            labelName.Text = result.Name;
            labelToken.Text = authToken;
            labelOwner.Text = result.Members.FirstOrDefault().Name;
            labelSubs.Text = result.SubscribersCount.ToString();
            labelWebhook.Text = result.Webhook;
            return;
        }
    }
}
