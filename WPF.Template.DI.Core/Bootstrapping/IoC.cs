using Autofac;
using System;
using System.Collections.Generic;
using WPF.Template.DI.Core.ViewModel.Application;

namespace WPF.Template.DI.Core.Bootstrapping
{
    /// <summary>
    /// The IoC container for the application
    /// </summary>
    public static class IoC
    {
        #region Public Properties

        /// <summary>
        /// The kernel of our IoC container
        /// </summary>
        public static Bootstrapper Kernel { get; private set; }

        /// <summary>
        /// A shortcut to access instance of the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static ApplicationViewModel Application => IoC.Get<ApplicationViewModel>();

        #endregion

        #region Construction

        /// <summary>
        /// Sets up the IoC container, binds all information required and is ready for use
        /// NOTE: Must be called as soon as your application starts up to ensure all 
        ///       services can be found 
        /// </summary>
        /// <param name="mappedTypes"></param>
        public static void Setup(Dictionary<Type, Type> mappedTypes)
        {
            Kernel = new Bootstrapper();

            // Binding all required view models
            BindViewModels(mappedTypes);
        }

        /// <summary>
        /// Bind all singleton view models
        /// </summary>
        /// <param name="mappedTypes"></param>
        private static void BindViewModels(Dictionary<Type, Type> mappedTypes)
        {
            Kernel.RunWithTypes(mappedTypes);
        }

        #endregion

        #region Generic Methods

        /// <summary>
        /// Get's a service from the IoC, of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernel.Container.Resolve<T>();
        }

        #endregion
    }
}
