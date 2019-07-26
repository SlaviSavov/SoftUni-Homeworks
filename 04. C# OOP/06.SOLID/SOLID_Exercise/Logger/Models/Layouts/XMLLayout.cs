using Logger.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format => GetForamt();

        private string GetForamt()
        {
            var sb = new StringBuilder();
            sb.AppendLine("<log>")
                .AppendLine("\t<date>{0}</date>")
                .AppendLine("\t<level>{1}</level>")
                .AppendLine("\t<message>{2}</message>")
                .AppendLine("</log>");

            return sb.ToString().TrimEnd();
        }
    }
}
