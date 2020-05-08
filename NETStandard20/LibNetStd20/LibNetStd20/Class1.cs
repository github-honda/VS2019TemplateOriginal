using System;

namespace LibNetStd20
{
    public class Class1
    {
        public void SampleCodeTFM()
        {
            // Target Framework Monikers (TFMs)
#if NET40
            Console.WriteLine("Target framework: .NET Framework 4.0");
#elif NET46
            Console.WriteLine("Target framework: .NET Framework 4.5");
#else
            Console.WriteLine("Target framework: .NET Standard 2.0");
#endif
        }
    }
}
