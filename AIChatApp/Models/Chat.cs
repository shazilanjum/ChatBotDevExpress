using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AIChatApp.Models.ChatMessage;

namespace AIChatApp.Models
{
    public class Chat : Metadata
    {
        public string Title { get; set; }
        public ChatModelSettings ModelSettings { get; set; }
        public List<ChatMessage> ChatHistory { get; set; }

        public Chat(string title, string createdBy)
        {
            Title = title;
            CreatedBy = createdBy;
            ChatHistory = new List<ChatMessage>();
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
            ModelSettings = new ChatModelSettings();
        }

        public void AddMessage(SenderRole sender, string message)
        {
            var chatMessage = new ChatMessage(sender, message);
            ChatHistory.Add(chatMessage);
            UpdateModifiedDate();
        }

        public string GetChatSummary()
        {
            return $"Title: {Title} | Model: {nameof(ModelSettings.SelectedModel)} | Messages: {ChatHistory.Count}";
        }
    }

}
