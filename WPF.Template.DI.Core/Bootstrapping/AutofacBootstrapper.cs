using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using WPF.Template.DI.Core.Bootstrapping.Modules;

namespace WPF.Template.DI.Core.Bootstrapping
{
    /// <summary>
    /// Abstract layer for bootstrapper that will handle Autofac modules
    /// </summary>
    public abstract class AutofacBootstrapper
    {
        #region Private Fields

        private Dictionary<Type, Type> _mappedTypes;

        #endregion

        #region Public Methods

        /// <summary>
        /// Method for registering and configuring Autofac module inside app scope
        /// </summary>
        /// <param name="mappedTypes"></param>
        public void RunWithTypes(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;
            var builder = new ContainerBuilder();

            RegisterViews(builder);

            ConfigureContainer(builder);

            var container = builder.Build();
            ConfigureApplication(container);
        }

        #endregion

        #region Virtual Methods

        /// <summary>
        /// Helper method for configuring Autofac container
        /// </summary>
        /// <param name="builder"></param>
        protected virtual void ConfigureContainer(ContainerBuilder builder)
        {
            if(_mappedTypes != null && _mappedTypes.Any())
            {
                builder.RegisterModule(new MappedTypeModule(_mappedTypes));
            }
        }

        #endregion

        #region Abstract Methods

        /// <summary>
        /// Signature of method that will register views in the app
        /// </summary>
        /// <param name="builder"></param>
        protected abstract void RegisterViews(ContainerBuilder builder);

        /// <summary>
        /// Signature of method that will configure Autofac container in app scope
        /// </summary>
        /// <param name="container"></param>
        protected abstract void ConfigureApplication(IContainer container);

        #endregion
    }
}
