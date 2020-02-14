using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional9
{
    class MonitorMemory
    {
        readonly int memoryLimit;

        public MonitorMemory(int memoryLimit)
        {
            this.memoryLimit = memoryLimit;
        }

        bool IsMemoryLimitExceeded()
        {
            return this.memoryLimit < GC.GetTotalMemory(false);
        }

        public void WarnIfMemoryLimitExceeded(object errorMessage)
        {
            if (IsMemoryLimitExceeded())
            {
                Console.WriteLine("{0}", errorMessage);
            }
        }
    }

    class LargeObject
    {
        int[] array = new int[100000000]; 

        public void Method(int i)
        {
            Console.WriteLine(i);
        }
    }
}
