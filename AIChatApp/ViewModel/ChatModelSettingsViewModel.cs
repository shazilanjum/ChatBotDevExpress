using System.ComponentModel;
using System.Runtime.CompilerServices;
using AIChatApp.Models;
using AIChatApp.Models.Enum;

namespace AIChatApp.ViewModels
{
    public class ChatModelSettingsViewModel : INotifyPropertyChanged
    {
        private ChatModelSettings _modelSettings;

        public ChatModel SelectedModel
        {
            get => _modelSettings.SelectedModel;
            set
            {
                _modelSettings.SelectedModel = value;
                OnPropertyChanged();
            }
        }

        public ModelParameters Parameters
        {
            get => _modelSettings.Parameters;
            set
            {
                _modelSettings.Parameters = value;
                OnPropertyChanged();
            }
        }

        public ChatModelSettingsViewModel(ChatModelSettings modelSettings)
        {
            _modelSettings = modelSettings;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
