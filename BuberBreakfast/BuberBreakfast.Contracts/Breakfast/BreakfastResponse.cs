using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberBreakfast.Contracts.Breakfast
{
    public record BreakfastResponse(
        Guid Id,
        string Name, 
        string Description,
        DateTime StartDateTime,
        DateTime EndDateTime,
        DateTime LastModifiedDateTime,
        List<string> Savory,
        List<String> Sweet
    );
}