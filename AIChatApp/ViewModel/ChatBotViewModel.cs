using AIChatApp.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AIChatApp.ViewModels
{
    public class ChatBotViewModel : INotifyPropertyChanged
    {
        private ChatViewModel _selectedChat;

        public ObservableCollection<ChatViewModel> Chats { get; set; }
        public ChatViewModel SelectedChat
        {
            get => _selectedChat;
            set
            {
                _selectedChat = value;
                OnPropertyChanged();
            }
        }

        public ChatBotViewModel()
        {
            Chats = new ObservableCollection<ChatViewModel>();
        }

        public void StartNewChat(string title, string createdBy)
        {
            var newChat = new ChatViewModel(new Chat(title, createdBy));
            Chats.Add(newChat);
            SelectedChat = newChat;
        }

        public void LoadChats(List<Chat> savedChats)
        {
            Chats.Clear();
            foreach (var chat in savedChats)
            {
                Chats.Add(new ChatViewModel(chat));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
