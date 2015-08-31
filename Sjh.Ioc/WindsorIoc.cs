using Castle.MicroKernel.Registration;
using Castle.Windsor;
using System;

namespace Sjh.Ioc
{

    public class WindsorIoc : IIoc
    {

        private WindsorContainer _windsorContainer;

        public void BuildContainer()
        {
            _windsorContainer = new WindsorContainer();
        }

        public void Register<Interface, Concrete>()
            where Interface : class
            where Concrete : Interface
        {
            if (_windsorContainer == null)
            {
                throw new InvalidOperationException("Container not built");
            }

            _windsorContainer.Register(Component.For<Interface>()
                                                .ImplementedBy<Concrete>());
        }

        public void Register<Interface, Concrete>(string name)
            where Interface : class
            where Concrete : Interface
        {
            if (_windsorContainer == null)
            {
                throw new InvalidOperationException("Container not built");
            }

            _windsorContainer.Register(Component.For<Interface>()
                                                .ImplementedBy<Concrete>()
                                                .Named(name));
        }

        public void RegisterSingleton<Interface, Concrete>()
            where Interface : class
            where Concrete : Interface
        {
            if (_windsorContainer == null)
            {
                throw new InvalidOperationException("Container not built");
            }

            _windsorContainer.Register(Component.For<Interface>()
                                                .ImplementedBy<Concrete>()
                                                .LifestyleSingleton());
        }

        public Interface Resolve<Interface>()
        {
            if (_windsorContainer == null)
            {
                throw new InvalidOperationException("Container not built");
            }

            var result = _windsorContainer.Resolve<Interface>();

            return result;
        }

        public void Register<Interface>(Interface instance, string name)
            where Interface : class
        {
            if (_windsorContainer == null)
            {
                throw new InvalidOperationException("Container not built");
            }

            _windsorContainer.Register(Component.For<Interface>()
                                                .Instance(instance)
                                                .Named(name));
        }

        public void Register<Interface>(Interface instance)
            where Interface : class
        {
            if (_windsorContainer == null)
            {
                throw new InvalidOperationException("Container not built");
            }

            _windsorContainer.Register(Component.For<Interface>()
                                                .Instance(instance));
        }

        public Interface Resolve<Interface>(string name)
        {
            if (_windsorContainer == null)
            {
                throw new InvalidOperationException("Container not built");
            }

            var result = _windsorContainer.Resolve<Interface>(name);

            return result;
        }

    }

}
