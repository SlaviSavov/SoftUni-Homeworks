using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : IAppender    
    {
        private const string dateFormat = "M/dd/yyyy H:mm:ss tt";


        private int messagesAppended;
        public ConsoleAppender(ILayout layout, Level level)
        {
            Layout = layout;
            Level = level;
        }
        public ILayout Layout { get; private set; }

        public Level Level { get; private set; }

        public void Append(IError error)
        {
            string format = this.Layout.Format;

            DateTime dateTime = error.DateTime;
            Level level = error.Level;
            string message = error.Message;

            string formattedMessage = String.Format(format,
                dateTime.ToString(dateFormat, CultureInfo.InvariantCulture),
                level.ToString(),
                message);

            Console.WriteLine(formattedMessage);

            messagesAppended++;
        }
    }
}
