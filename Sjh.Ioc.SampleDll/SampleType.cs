
namespace Sjh.Ioc.SampleDll
{

    public interface ISampleType
    {
        bool IsTrue(bool input);
    }



    public class SampleType : ISampleType
    {

        public bool IsTrue(bool input)
        {
            return input;
        }

    }

}
