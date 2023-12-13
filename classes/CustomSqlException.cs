using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartSetll_Analytics_V2.classes
{
    public class CustomSqlException : Exception
    {
        public CustomSqlException(string message, Exception innerException)
        : base(message, innerException)
        {
        }
    }
}