using BookStorageBusinessLogic.Plugins.HelperModels;
using BookStorageBusinessLogic.Plugins.Interfaces;
using BookStorageBusinessLogic.Plugins.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace BookStorageView
{
    public partial class FormMessenger : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private IMessengerPlugin _messenger;
        private PluginMessengerManager _manager;

        public FormMessenger(PluginMessengerManager manager)
        {
            _manager = manager;
            InitializeComponent();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            _messenger = _manager.plugins[comboBoxPlugin.Text];
            _messenger.Connect(new SenderConfiguratorModel());
        }

        private void buttonSendMessage_Click(object sender, EventArgs e)
        {
            _messenger = _manager.plugins[comboBoxPlugin.Text];
            _messenger.SendMessage(new SendMessageModel());
        }

        private void FormMessenger_Load(object sender, EventArgs e)
        {
            if (_manager.Headers is null || _manager.Headers.Count.Equals(0)) return;
            comboBoxPlugin.Items.AddRange(_manager.Headers.ToArray());
            comboBoxPlugin.Text = comboBoxPlugin.Items[0].ToString();
        }
    }
}
