using BlazorHybrid.Maui.Shared;

namespace MultiPlatform
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //添加初始化BlazorWebView组件 InitBlazorWebView 使用js权限.
            new InitBlazorWebView(blazorWebView);
        }
    }
}
