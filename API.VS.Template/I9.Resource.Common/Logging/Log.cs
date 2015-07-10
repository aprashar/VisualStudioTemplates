using I9.$resource$.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talx.DomainModel;

namespace I9.$resource$.Infrastructure.Logging
{
    public class Log :ILog
    {
        private EmployerCode employerCode;
        private string locationCode;
        private string userId;
        private Guid transactionId;
        private string logMessage;

        public EmployerCode ErCode
        {
            get { return employerCode; }
        }

        public string LocationCode
        {
            get { return locationCode;}
        }

        public string UserId
        {
            get { return userId; }
        }

        public Guid TransactionId
        {
            get { return transactionId;}
        }

        public string LogMessage
        {
            get { return logMessage; }
        }

        public Log(EmployerCode employerCode, string locationCode, string userId, Guid transactionId, string logMessage)
        {
            this.employerCode = employerCode;
            this.locationCode = locationCode;
            this.userId = UserId;
            this.transactionId = transactionId;
            this.logMessage = logMessage;
        }
                

        public override string ToString()
        {

            return string.Format("EmployerCode:{0}, LocationCode:{1}, UserId:{2}, TransactionId:{3}, LogMessage:{4}",
                employerCode, locationCode, userId, transactionId, logMessage);
        }


        
    }
}
