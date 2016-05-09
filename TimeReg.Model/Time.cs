using System;

namespace TimeReg.Model
{
    public class Time
    {
        public Time(DateTime fromTime, DateTime toTime, TimeType timeType)
        {
            FromTime = fromTime;
            ToTime = toTime;
            TimeType = timeType;
        }

        public DateTime FromTime { get; }
        public DateTime ToTime { get; }
        public TimeType TimeType { get; }
    }
}
