using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationPassword.Infrastructure.Messages
{
    public interface IMessageService
    {
        string GetErrorMessage(string key);
    }
}
