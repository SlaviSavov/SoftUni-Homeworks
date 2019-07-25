using Logger.Models.Contracts;
using Logger.Models.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Appenders
{
    public class FileAppender : IAppender
    {
        private int messagesAppended;
        public FileAppender(ILayout layout, Level level, IFile file)
        {
            Layout = layout;
            Level = level;
            File = file;
        }
        public ILayout Layout { get; private set; }

        public Level Level { get; private set; }

        public IFile File { get;private set; }

        public void Append(IError error)
        {
            string formattedMessage = this.File
                .Write(this.Layout, error);

            System.IO.File.AppendAllText(this.File.Path,
                formattedMessage);
            this.messagesAppended++;
        }
    }
}
