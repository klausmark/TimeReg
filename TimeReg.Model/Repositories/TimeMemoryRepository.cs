using System;
using System.Collections.Generic;

namespace TimeReg.Model.Repositories
{
    public class TimeMemoryRepository : ITimeRepository
    {
        public List<Time> GetAll()
        {
            return new List<Time>( new []
            {
                new Time(
                    fromTime:DateTime.Parse("2016-05-02 08:00:00"), 
                    toTime:DateTime.Parse("2016-05-09 16:00:00"),
                    timeType:TimeType.NormalHours
                    ),
                new Time(
                    fromTime:DateTime.Parse("2016-05-03 08:00:00"),
                    toTime:DateTime.Parse("2016-05-09 16:00:00"),
                    timeType:TimeType.NormalHours
                    ),
                new Time(
                    fromTime:DateTime.Parse("2016-05-04 08:00:00"),
                    toTime:DateTime.Parse("2016-05-09 16:00:00"),
                    timeType:TimeType.NormalHours
                    ),
                new Time(
                    fromTime:DateTime.Parse("2016-05-09 08:00:00"),
                    toTime:DateTime.Parse("2016-05-09 16:00:00"),
                    timeType:TimeType.NormalHours
                    )
            });
        }

        public Time Add(Time time)
        {
            throw new System.NotImplementedException();
        }

        public Time Update(int Id, Time time)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Time time)
        {
            throw new System.NotImplementedException();
        }
    }
}
