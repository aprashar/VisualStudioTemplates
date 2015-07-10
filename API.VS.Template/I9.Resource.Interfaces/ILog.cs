using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talx.DomainModel;

namespace I9.$resource$.Interfaces
{
    public interface ILog
    {
        EmployerCode ErCode { get; }

        string LocationCode { get; }

        string UserId { get; }

        Guid TransactionId { get; }

        string LogMessage { get; }
    }
}
