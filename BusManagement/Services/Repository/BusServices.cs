using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;

<<<<<<< HEAD
public class BusServices : BaseRepository<TblBu>
=======
public class BusServices : ServiceBase<TblBu>
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
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
<<<<<<< HEAD
            return (bool)bus.IsActive;   // true hoat dong, false khong hoat dong
=======
            return bus.IsActive;   // true hoat dong, false khong hoat dong
>>>>>>> b5478df7ccf23b2a79a411bcb39af457155b9311
        }
        return false;
    }

}
