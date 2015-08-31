using System.Collections.Generic;

namespace Sjh.Ioc
{

    public class IocMaker
    {

        public static IIoc NewIoc()
        {
            var result = new WindsorIoc();
            result.BuildContainer();

            return result;
        }

        public static IIoc NewIocWith(IIocRegister iocRegister)
        {
            var result = new WindsorIoc();
            result.BuildContainer();

            iocRegister.RegisterMappings(result);

            return result;
        }

        public static IIoc NewIocWith(IList<IIocRegister> iocRegisters)
        {
            var result = new WindsorIoc();
            result.BuildContainer();

            foreach (var iocRegister in iocRegisters)
            {
                iocRegister.RegisterMappings(result);
            }

            return result;
        }

    }

}
