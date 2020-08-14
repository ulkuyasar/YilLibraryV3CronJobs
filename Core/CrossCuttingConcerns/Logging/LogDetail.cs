using Core.Utilities.DefaultValues;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Logging
{
    public class LogDetail
    {
        public LogDetail()
        {
            CurrentlyTime = DefaultValue.Today;
        }

        public string MethodName { get; set; }
        public List<LogParameter> LogParameters { get; set; }
        public DateTime CurrentlyTime { get; set; }
    }
}
