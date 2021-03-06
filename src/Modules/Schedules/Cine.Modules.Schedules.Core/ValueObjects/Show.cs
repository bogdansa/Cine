using System;
using Cine.Shared.BuildingBlocks;
using Cine.Shared.Kernel.ValueObjects;

namespace Cine.Modules.Schedules.Core.ValueObjects
{
    public sealed class Show : ValueObject
    {
        public HallId HallId { get; }
        public DateTime Date { get; }
        public Time Time { get; }

        public Show(HallId hallId, DateTime date, Time time)
        {
            HallId = hallId;
            Date = date;
            Time = time;
        }
    }
}
