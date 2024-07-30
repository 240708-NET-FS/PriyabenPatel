using ExpanseTrackerApp.DAO;
using ExpanseTrackerApp.Entities;


namespace ExpanseTrackerApp.Service;

public class ExpanseService : IService<Expanse>
{
    
    private readonly ExpanseDAO _expanseDao;
    public ExpanseService(ExpanseDAO expanseDao)
    {
        _expanseDao = expanseDao;
    }
    public Expanse GetById(int Id)
    {
        return new Expanse();
    }
    public ICollection<Expanse> GetAll()
    {
        return new List<Expanse>();
    }
    public void Create(Expanse e)
    {
        
    }
    public void Delete(Expanse e)
    {

    }
    public void Update(Expanse e)
    {

    }

}
