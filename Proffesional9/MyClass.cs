using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proffesional9
{
    class MyClass : IDisposable
    {
        private bool disposed = false;

        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }

        ~MyClass()
        {
            Console.WriteLine("Finalise");
            CleanUp(false);
        }

        private void CleanUp(bool clean)
        {
            if (!this.disposed)
            {
                if (clean)
                {
                    Console.Write("Release of resources");

                    for (int i = 0; i < 40; i++)
                    {
                        Console.Write("F");
                    }
                }
                Console.WriteLine("Finalized");
            }
            this.disposed = true;
        }
    }
}
