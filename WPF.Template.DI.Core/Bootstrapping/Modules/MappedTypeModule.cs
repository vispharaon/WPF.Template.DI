using Autofac;
using System;
using System.Collections.Generic;

namespace WPF.Template.DI.Core.Bootstrapping.Modules
{
    /// <summary>
    /// Autofac module helper
    /// </summary>
    public class MappedTypeModule : Module
    {
        #region Private Fields

        private Dictionary<Type, Type> _mappedTypes;

        #endregion

        #region Constructor

        /// <summary>
        /// Creating instance of <see cref="MappedTypeModule"/>
        /// </summary>
        /// <param name="mappedTypes"></param>
        public MappedTypeModule(Dictionary<Type, Type> mappedTypes)
        {
            _mappedTypes = mappedTypes;
        }

        #endregion

        #region Module implementation

        /// <summary>
        /// Registering types in app scope provided as Dictionary of KeyValuePair
        /// </summary>
        /// <param name="builder"></param>
        protected override void Load(ContainerBuilder builder)
        {
            foreach(var keyValuePair in _mappedTypes)
            {
                builder.RegisterTypes(keyValuePair.Value).As(keyValuePair.Key);
            }
        }

        #endregion
    }
}
