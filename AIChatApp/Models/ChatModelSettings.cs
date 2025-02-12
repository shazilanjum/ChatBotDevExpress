using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIChatApp.Models
{
    public class ChatModelSettings
    {
        public ChatModel SelectedModel { get; set; }
        public ModelParameters Parameters { get; set; }

        public ChatModelSettings()
        {
            SelectedModel = ChatModel.gpt3_5;
            Parameters = new ModelParameters();
        }
    }

}
