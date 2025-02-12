using AIChatApp.Blazor;
using AIChatApp.Views;
using DevExpress.XtraEditors;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;

namespace AIChatApp
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            webView.Services = serviceProvider;
            webView.RootComponents.Add<ChatBotView>("#app");
        }
    }
}