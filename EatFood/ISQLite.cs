using System;
using System.Collections.Generic;
using System.Text;

namespace EatFood
{
    public interface ISQLite
    {
       string GetDatabasePath(string filename);
    }
}
