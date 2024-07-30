using ExpanseTrackerApp.Entities;
using ExpanseTrackerApp.Entities;
using ExpanseTrackerApp.Entities;

namespace ExpanseTrackerApp.DAO;

public class ExpanseDAO : IDAO<Expanse>
{

    private ExpanseDbContext _context;

    public ExpanseDAO(ExpanseDbContext context)
    {
        _context = context;
    }



    public void Create(Expanse item)
    {
        _context.Expanses.Add(item);
        _context.SaveChanges();

    }

    public void Delete(Expanse item)
    {
       _context.Expanses.Remove(item);
       _context.SaveChanges();
    }

    public ICollection<Expanse> GetAll()
    {
        List<Expanse> expanses= _context.Expanses.ToList();
        return expanses;

    }

    public Expanse GetById(int ID)
    {
        Expanse expanse = _context.Expanses.FirstOrDefault(e => e.ExpanseId == ID);
        return expanse;
    }

    public void Update(Expanse newItem)
    {
       Expanse originalExpanse = _context.Expanses.FirstOrDefault(e => e.ExpanseId == newItem.ExpanseId);

       if(originalExpanse != null)
       {
        originalExpanse.ExpanseId = newItem.ExpanseId;
        originalExpanse.Grocery = newItem.Grocery;
        originalExpanse.HouseRant = newItem.HouseRant;
        originalExpanse.Utility = newItem.Grocery;
        _context.Expanses.Update(originalExpanse);
        _context.SaveChanges();
        
       }

    }

}
