using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGraphQL.Application.Interfaces
{
    public interface IDateTimeService
    {
        DateTime NowUtc { get; }
    }
}
