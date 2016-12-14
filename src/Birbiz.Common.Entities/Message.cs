namespace Birbiz.Common.Entities
{
    public class Message : BaseEntity
    {
        public string Text { get; set; }

        public int SenderId { get; set; }

        public MessageSenderType SenderType { get; set; }

        public int ReceiverId { get; set; }

        public MessageReceiverType ReceiverType { get; set; }

        public bool IsRead { get; set; }
    }
}