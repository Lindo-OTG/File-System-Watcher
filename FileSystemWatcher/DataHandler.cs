using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_take_2_LINDO
{
    class DataHandler
    {
        public delegate string MyDelegate(List<Changes> list, string path);
        public static MyDelegate call;

    }
}
