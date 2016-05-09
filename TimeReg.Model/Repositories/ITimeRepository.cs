using System.Collections.Generic;

namespace TimeReg.Model.Repositories
{
    public interface ITimeRepository
    {
        List<Time> GetAll();
        Time Add(Time time);
        Time Update(int Id, Time time);
        void Delete(Time time);
    }
}
