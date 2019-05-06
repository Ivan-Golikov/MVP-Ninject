using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dependencyinjectiontest.services
{
    class SmsService : ISmsService
    {
        public SmsService()
        {
        }

        public void Send(string to, string text)
        {
            Console.WriteLine("Sms успешно отправлено");
        }
    }
}
