﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AIChatApp.Models.ChatMessage;

namespace AIChatApp.Models
{
    public class Chat : Metadata
    {
        public int ID {  get; set; }

        public string Title { get; set; }

        public ChatModelSettings ModelSettings { get; set; }

        public List<ChatMessage> ChatHistory { get; set; }

        public Chat(string title, string createdBy)
        {
            Title = title;
            ChatHistory = new List<ChatMessage>();
            CreatedDate = DateTime.UtcNow;
            ModelSettings = new ChatModelSettings();
        }

        public void AddMessage(SenderRole sender, string message)
        {
            var chatMessage = new ChatMessage(sender, message);
            ChatHistory.Add(chatMessage);
        }

        public string GetChatSummary()
        {
            return $"Title: {Title} | Model: {nameof(ModelSettings.SelectedModel)} | Messages: {ChatHistory.Count}";
        }
    }

}
