using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF.Template.DI.Core.Base;
using WPF.Template.DI.Core.ViewModel.Login;

namespace WPF.Template.DI.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : BasePage<LoginViewModel>, IHavePassword
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor with specific view model
        /// </summary>
        /// <param name="specificViewModel"></param>
        public LoginPage(LoginViewModel specificViewModel) : base(specificViewModel)
        {
            InitializeComponent();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Implementing secure password on login page
        /// NOTE: Need to add password field in UI and connect with this property
        /// </summary>
        //public SecureString SecurePassword => PasswordText.SecurePassword;
        SecureString IHavePassword.SecurePassword { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        #endregion
    }
}
