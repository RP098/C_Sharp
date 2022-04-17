using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{
   public class Delete
    {
        IDelete delete;
        public Delete(IDelete delete)
        {
            this.delete = delete;
        }

        public void DeleteFile()
        {
            delete.DeleteFile();
        }
    }
}
