using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_manager
{
   public class Create
    {
        ICreate create;
        public Create(ICreate create)
        {
            this.create = create;
        }

        public void CreateFile()
        {
            create.CreateFile();
        }
    }
}
