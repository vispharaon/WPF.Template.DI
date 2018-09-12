using WPF.Template.DI.Core.Base;
using WPF.Template.DI.Core.Enums;

namespace WPF.Template.DI.Core.ViewModel.Application
{
    /// <summary>
    /// The application state as a view mdoel
    /// </summary>
    public class ApplicationViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;

        /// <summary>
        /// The view model to use fot the current page when the CurrentPage changes
        //// NOTE: This is not a live up-to-date view model of the current page
        ///       it is simply used to set the view model of the current page 
        ///       at the time it changes 
        /// </summary>
        public BaseViewModel CurrentPageViewModel { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Navigated to the specified page
        /// </summary>
        /// <param name="page">specified application page</param>
        /// <param name="viewModel">View model that will be used on specified application page</param>
        public void GoToPage(ApplicationPage page, BaseViewModel viewModel = null)
        {
            // Set the view model
            CurrentPageViewModel = viewModel;

            // Set the current page
            CurrentPage = page;

            // Invoke CurrentPage on property changed event
            OnPropertyChanged(nameof(CurrentPage));
        }

        #endregion
    }
}
