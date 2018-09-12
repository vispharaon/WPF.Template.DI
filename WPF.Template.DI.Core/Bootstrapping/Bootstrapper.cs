using Autofac;
using WPF.Template.DI.Core.ViewModel.Application;
using WPF.Template.DI.Core.ViewModel.Login;
using WPF.Template.DI.Core.ViewModel.Test;

namespace WPF.Template.DI.Core.Bootstrapping
{
    /// <summary>
    /// Bootstrapper that provides container for the IoC module
    /// </summary>
    public class Bootstrapper : AutofacBootstrapper
    {
        #region Abstract Method Implementations

        /// <summary>
        /// Implementation of abstract method from <see cref="AutofacBootstrapper"/>
        /// </summary>
        /// <param name="container"></param>
        protected override void ConfigureApplication(IContainer container)
        {
            Container = container;
        }

        /// <summary>
        /// Implementation of abstract method from <see cref="AutofacBootstrapper"/>
        /// </summary>
        /// <param name="builder"></param>
        protected override void RegisterViews(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationViewModel>().SingleInstance();
            builder.RegisterType<TestViewModel>().SingleInstance();
            builder.RegisterType<LoginViewModel>().SingleInstance();
        }

        #endregion

        #region Public Properties

        public IContainer Container { get; set; }

        #endregion
    }
}
