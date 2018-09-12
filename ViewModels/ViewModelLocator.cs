using WPF.Template.DI.Core.ViewModel.Application;

namespace WPF.Template.DI.ViewModels
{
    /// <summary>
    /// Locates view models from the IoC for use in binding in Xaml files
    /// </summary>
    public class ViewModelLocator
    {
        #region Public Properties

        /// <summary>
        /// Singleton instance of the locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// The application view model
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => Core.Bootstrapping.IoC.Application;

        /// <summary>
        /// The settings view model
        /// </summary>
        //public static SettingsViewModel SettingsViewModel => Core.Bootstrapping.IoC.Settings;

        #endregion
    }
}
