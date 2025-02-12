using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using AIChatApp.Models;
using static AIChatApp.Models.ChatMessage;

namespace AIChatApp.ViewModels
{
    public class ChatViewModel : INotifyPropertyChanged
    {
        private Chat _chat;

        public string Title => _chat.Title;
        public string CreatedBy => _chat.CreatedBy;
        public DateTime CreatedDate => _chat.CreatedDate;
        public DateTime ModifiedDate => _chat.ModifiedDate;

        public ChatModelSettingsViewModel ModelSettings { get; set; }
        public ObservableCollection<ChatMessageViewModel> ChatHistory { get; set; }

        public ChatViewModel(Chat chat)
        {
            _chat = chat;
            ModelSettings = new ChatModelSettingsViewModel(chat.ModelSettings);
            ChatHistory = new ObservableCollection<ChatMessageViewModel>(
                chat.ChatHistory.Select(m => new ChatMessageViewModel(m))
            );
        }

        public void AddMessage(SenderRole sender, string message)
        {
            _chat.AddMessage(sender, message);
            ChatHistory.Add(new ChatMessageViewModel(sender, message));
            OnPropertyChanged(nameof(ChatHistory));
        }

        public string GetChatSummary() => _chat.GetChatSummary();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
