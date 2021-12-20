using System;
using System.Collections.Generic;
using System.Text;

namespace BookStorageBusinessLogic.Plugins.HelperModels
{
    public class SendStickerModel
    {
        public string UserId { get; set; }

        public int StickerId { get; set; }

        public string Media { get; set; }
    }
}
