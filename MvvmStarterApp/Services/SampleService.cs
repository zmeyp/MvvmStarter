using MVVMbasics.Attributes;
using MVVMbasics.Services;

namespace MvvmApp1.Services
{
    [MvvmService]
    public class SampleService : IService
    {
        public int MyProperty { get; set; }

    }
}
