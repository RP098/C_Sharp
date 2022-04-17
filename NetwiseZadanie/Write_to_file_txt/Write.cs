using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{
   public class Write
    {
        IWrite write;
        public Write(IWrite write)
        {
            this.write = write;
        }
        public void WriteToFile(string catInfo)
        {
            write.WriteToFile(catInfo);
        }
    }
}
