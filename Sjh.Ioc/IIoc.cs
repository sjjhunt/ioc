
namespace Sjh.Ioc
{

    public interface IIoc
    {

        void BuildContainer();

        void Register<Interface, Concrete>()
            where Interface : class
            where Concrete : Interface;

        void Register<Interface, Concrete>(string name)
            where Interface : class
            where Concrete : Interface;

        void RegisterSingleton<Interface, Concrete>()
            where Interface : class
            where Concrete : Interface;

        Interface Resolve<Interface>();

        void Register<Interface>(Interface instance, string name)
            where Interface : class;

        void Register<Interface>(Interface instance)
            where Interface : class;

        Interface Resolve<Interface>(string name);

    }

}
