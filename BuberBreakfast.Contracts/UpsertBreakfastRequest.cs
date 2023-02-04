using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberBreakfast.Contracts
{
    public record  UpsertBreakfastRequest(
        string Name,
        string description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        List<string> Savory,
        List<string> Sweet
    );
}
