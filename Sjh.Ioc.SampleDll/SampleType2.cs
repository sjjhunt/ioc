
namespace Sjh.Ioc.SampleDll
{

    public interface ISampleType2
    {
        bool IsReallyTrue(bool input);
    }



    public class SampleType2 : ISampleType2
    {

        public ISampleType _sampleType;

        public SampleType2(ISampleType sampleType)
        {
            _sampleType = sampleType;
        }

        public bool IsReallyTrue(bool input)
        {
            return _sampleType.IsTrue(input);
        }

    }

}
