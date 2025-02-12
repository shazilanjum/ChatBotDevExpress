using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AIChatApp.Models;
using static AIChatApp.Models.ChatMessage;

namespace AIChatApp.ViewModels
{
    public class ChatMessageViewModel : INotifyPropertyChanged
    {
        public SenderRole Sender { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }

        public ChatMessageViewModel(SenderRole sender, string message)
        {
            Sender = sender;
            Message = message;
            Timestamp = DateTime.UtcNow;
        }

        public ChatMessageViewModel(ChatMessage chatMessage)
        {
            Sender = chatMessage.Sender;
            Message = chatMessage.Message;
            Timestamp = chatMessage.Timestamp;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
