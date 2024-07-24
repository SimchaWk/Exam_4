using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiefRabbinateQueries.Model
{
    internal record DateModel(
        string Day,
        string DayMonth,
        string Month,
        string Year,
        string Result
        );
}
