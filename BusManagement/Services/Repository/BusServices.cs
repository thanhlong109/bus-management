using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;

public class BusServices : ServiceBase<TblBu>
{
    public List<TblBu> GetAllWithRoutes()
    {
        return _dbSet.Include(p => p.Routes).ToList();
    }
    public bool GetBusStatus(string busId)
    {
        
        var bus = _dbSet.FirstOrDefault(b => b.BusId == busId);//

        if (bus != null)
        {
            return bus.IsActive;   // true hoat dong, false khong hoat dong
        }
        return false;
    }

}
