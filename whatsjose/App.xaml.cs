using whatsjose.Pages;

namespace whatsjose
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new ChatsPage());
        }
    }
}
