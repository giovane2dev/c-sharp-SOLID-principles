using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Principles.SRP
{
    internal class Order
    {
        private SendMail sendMail;
        private ILogger ilogger;

        public Order()
        {
            sendMail = new SendMail();
            ilogger = new RegisterLog();
        }

        public void CreateOrder()
        {
            try
            {
                sendMail.From = "Giovane";
                sendMail.To = "Michelle";
                sendMail.Subject = ".NET";
                sendMail.Body = "Hello World!";
                sendMail.Send();

                ilogger.Info("Mail sent");
            } catch (Exception e)
            {

            }
        }

        public void DeleteOrder()
        {

        }
    }
}
