using System;
using System.Collections.Generic;
using System.Windows;
using WPF.Template.DI.Service.Repositories;

namespace WPF.Template.DI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Overridden Application Methods

        /// <summary>
        /// Extend OnStartup application method
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ApplicationSetup();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Application IoC setup
        /// </summary>
        private void ApplicationSetup()
        {
            Dictionary<Type, Type> mappedTypes = new Dictionary<Type, Type>();

            mappedTypes.Add(typeof(ITestRepository), typeof(TestRepository));

            Core.Bootstrapping.IoC.Setup(mappedTypes);
        }

        #endregion
    }
}
