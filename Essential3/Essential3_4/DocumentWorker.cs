using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential3.Essential3_4
{
    class DocumentWorker
    {
        public void OpenDocument()
        {
            Console.WriteLine("Document is open");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Editing a document is available in the Pro version");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Saving a document is available in the Pro version");
        }
    }
}
