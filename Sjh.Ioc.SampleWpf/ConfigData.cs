
namespace Sjh.Ioc.SampleWpf
{

    public interface IConfigData
    {
        int ANumber { get; }
    }



    public class ConfigData : IConfigData
    {

        public int ANumber { get; set; }

    }

}
