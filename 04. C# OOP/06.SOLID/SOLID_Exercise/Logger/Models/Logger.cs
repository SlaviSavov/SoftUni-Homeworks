using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models
{
    public class Logger : ILogger
    {
        private ICollection<IAppender> appenders;

        public Logger(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }

        public IReadOnlyCollection<IAppender> Appenders => (IReadOnlyCollection <IAppender>)this.appenders;

        public void Log(IError error)
        {
            foreach (IAppender appender in appenders)
            {
                if (appender.Level<=error.Level)
                {
                    appender.Append(error);
                }
            }
        }
    }
}
