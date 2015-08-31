using Sjh.Ioc.SampleDll.Ioc;

namespace Sjh.Ioc.SampleWpf.Ioc
{

    public class IocRegisterSampleWpf : IIocRegister
    {

        public void RegisterMappings(IIoc ioc)
        {
            var sampleDll = new IocRegisterSampleDll();
            sampleDll.RegisterMappings(ioc);

            ioc.Register<IHelperTool, HelperTool>();
        }

    }

}
