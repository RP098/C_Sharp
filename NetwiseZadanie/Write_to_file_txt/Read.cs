using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{
   public class Read
    {
        IRead read;
        public Read(IRead read)
        {
            this.read = read;
        }

        public string ReadFile()
        {
            return read.ReadFile();
        }
    }
}
