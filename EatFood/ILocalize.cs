using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EatFood
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
