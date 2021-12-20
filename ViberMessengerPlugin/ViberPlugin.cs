using BookStorageBusinessLogic.Plugins.HelperModels;
using BookStorageBusinessLogic.Plugins.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViberMessengerPlugin
{
    [Export(typeof(IMessengerPlugin))]
    public class ViberPlugin : IMessengerPlugin
    {
        public string PluginType => "ViberMessengerPlugin";

        private List<(string, string)> some_errors = new List<(string, string)>();

        public IEnumerable<(string Title, string Message)> Errors => some_errors;


        public IEnumerable<(string Title, string Message)> Connect(SenderConfiguratorModel config)
        {
            try
            {

                var form = new FormInfo(new SenderConfiguratorModel { AuthToken = "4e74b0771467d558-bcb33d7417efdb25-a06987c41b285dc6" });
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Данные получены!", "Получеие данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                return null;
            }
            catch (Exception e)
            {
                some_errors.Add(("Ошибка", e.Message));

                return null;
            }
        }

        public void SendMessage(SendMessageModel message)
        {
            try
            {
                var form = new FormSendMessege(new SendMessageModel { UserId = "w4jEN3PoWhWwQ + FLKwpWzQ =="});
                form.ShowDialog();

                if (form.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Сообщение было успешно отправлено!", "Отправка сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Console.WriteLine(message.Text);
            }
            catch (Exception e)
            {
                some_errors.Add(("Ошибка", e.Message));
            }
        }
    }
}
