using Microsoft.AspNetCore.Mvc;

namespace Birbiz.WebServices.Common.Results
{
    public class MessageResultValue : IResultValue
    {
        public string Message { get; set; }

        public MessageType Type { get; set; }

        public MessageResultValue(string message) : this(message, MessageType.Info)
        {
        }

        public MessageResultValue(string message, MessageType type)
        {
            Type = type;
            Message = message;
        }

        public object Execute(ActionContext context)
        {
            return this;
        }
    }
}