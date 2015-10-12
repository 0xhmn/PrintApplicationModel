using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintApplication
{
    public class DbContext
    {
        public DbContext(string dbString, int appId)
        {
        }

        public string NAME_LAST { get; set; }
        public string NAME_FIRST { get; set; }

    }
}
