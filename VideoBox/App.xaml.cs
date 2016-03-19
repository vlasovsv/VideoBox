using System.Windows;

namespace VideoBox
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            VideoBoxBootstrapper bootStrapper = new VideoBoxBootstrapper();
            bootStrapper.Run();
        }
    }
}
