using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Base
    {
        public static AdesEntities ctx { get; set; }
        public IBaseRepository()
        {
            if (ctx == null)
            {
                ctx = new AdesEntities();
            }
        }
    }
}
