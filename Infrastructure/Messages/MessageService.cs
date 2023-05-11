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
            _resourceManager = new ResourceManager(typeof(CustomMessages));
        }

        public string GetErrorMessage(string key)
        {
            string? errorMessage = _resourceManager.GetString(key);
            return errorMessage ?? $"Mensagem de erro não encontrada para a chave '{key}'";
        }
    }
}
