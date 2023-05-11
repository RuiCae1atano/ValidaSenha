using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace ValidationPassword.Infrastructure.Messages
{
    public class MessageService : IMessageService
    {
        private readonly ResourceManager _resourceManager;

        public MessageService()
        {
            _resourceManager = new ResourceManager(typeof(Resources));
        }

        public string GetErrorMessage(string key)
        {
            return _resourceManager.GetString(key);
        }
    }
}
