using System.IO;
using System.Windows;

using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using Prism.Unity;

namespace VideoBox
{
    /// <summary>
    /// An application bootstrapper that provides all magic.
    /// </summary>
    public class VideoBoxBootstrapper : UnityBootstrapper
    {
        /// <summary>
        /// Creates a module catalog where prism will be finding modules.
        /// </summary>
        /// <returns>
        /// Returns the module catatlog.
        /// </returns>
        protected override IModuleCatalog CreateModuleCatalog()
        {
            var modulePath = Path.Combine(Directory.GetCurrentDirectory(), "Modules");
            if (!Directory.Exists(modulePath))
                Directory.CreateDirectory(modulePath);
            return new DirectoryModuleCatalog() { ModulePath = modulePath };
        }

        /// <summary>
        /// Creates a main form of the application.
        /// </summary>
        /// <returns>
        /// Returns the main form <see cref="DependencyObject"/>.
        /// </returns>
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<Shell>();
        }

        /// <summary>
        /// Initialize the main form of the application.
        /// </summary>
        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Shell)Shell;
            Application.Current.MainWindow.DataContext = ServiceLocator.Current.GetInstance<ShellViewModel>();
            Application.Current.MainWindow.Show();
        }
    }
}
