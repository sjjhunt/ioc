using Sjh.Ioc;

namespace Sjh.Ioc.SampleDll.Ioc
{

    public class IocRegisterSampleDll : IIocRegister
    {

        public void RegisterMappings(IIoc ioc)
        {
            ioc.Register<ISampleType, SampleType>();
            ioc.Register<ISampleType2, SampleType2>();
        }

    }

}
