using WPF.Template.DI.Core.Base;

namespace WPF.Template.DI.Core.ViewModel.Login
{
    /// <summary>
    /// Login view model type
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Constructor

        /// <summary>
        /// Default login view model
        /// </summary>
        public LoginViewModel()
        {
            // This can be removed
            var testVm = Bootstrapping.IoC.Get<Test.TestViewModel>();
            testVm.SetTestString();            
            TestString = testVm.TestString;
        }

        #endregion

        #region Test Values (can be removed)

        private string _testString;

        public string TestString
        {
            get { return _testString; }
            set
            {
                _testString = value;
                OnPropertyChanged(nameof(TestString));
            }
        }

        #endregion
    }
}
