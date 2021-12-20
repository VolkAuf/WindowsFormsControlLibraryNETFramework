using BookStorageBusinessLogic.Plugins.HelperModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.Plugins.Interfaces
{
    public interface IMessengerPlugin
    {
        string PluginType { get; }
        IEnumerable<(string Title, string Message)> Errors { get; }

        IEnumerable<(string Title, string Message)> Connect(SenderConfiguratorModel config);

        void SendMessage(SendMessageModel message);
    }
}
