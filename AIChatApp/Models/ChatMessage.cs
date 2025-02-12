namespace AIChatApp.Models
{
    public class ChatMessage
    {
        public SenderRole Sender { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public MessageType Type { get; set; }  // Optional: System/User/Bot

        public ChatMessage(SenderRole sender, string message, MessageType type = MessageType.User)
        {
            Sender = sender;
            Message = message;
            Type = type;
            Timestamp = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"[{Timestamp}] {Sender}: {Message}";
        }

        public enum SenderRole
        {
            User,
            Bot
        }

        public enum MessageType
        {
            User,
            Bot,
            System
        }
    }

}