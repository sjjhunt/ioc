using Sjh.Ioc.SampleDll;
using Sjh.Ioc.SampleWpf.Ioc;
using System.Collections.Generic;
using System.Windows;

namespace Sjh.Ioc.SampleWpf
{

    public partial class MainWindow : Window, IIocRegister
    {

        private IIoc _ioc;

        private ISampleType2 _sampleType2;
        private IConfigData _configData;

        public MainWindow()
        {
            InitializeComponent();

            _ioc = IocMaker.NewIocWith(new List<IIocRegister>
                {
                    new IocRegisterSampleWpf(),
                    this
                });

            _sampleType2 = _ioc.Resolve<ISampleType2>();
            _configData = _ioc.Resolve<IConfigData>();
        }


        public void RegisterMappings(IIoc ioc)
        {
            ioc.Register<IConfigData>(new ConfigData { ANumber = 1 });
        }

    }

}
