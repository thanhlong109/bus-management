using Microsoft.EntityFrameworkCore;
using Services.Models;
using Services.Repository;

public class BusServices : ServiceBase<TblBu>
{
    public List<TblBu> GetAllWithRoutes()
    {
        return _dbSet.Include(p => p.Routes).ToList();
    }

}
