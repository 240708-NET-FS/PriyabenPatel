using ExpanseTrackerApp.Entities;
using ExpanseTrackerApp.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;


namespace ExpanseTrackerApp.DAO;

public class LoginDAO : IDAO<Login>
{
    //CRUD
    private ExpanseDbContext _context;

    public LoginDAO(ExpanseDbContext context)
    {
        _context = context;
    }


    public void Create(Login item)
    {
        _context.Logins.Add(item);
        _context.SaveChanges();

    }

    public void Delete(Login item)
    {
        _context.Logins.Remove(item);
        _context.SaveChanges();
    }

    public ICollection<Login> GetAll()
    {
        List<Login> logins = _context.Logins.Include(l => l.Expanse).ToList();
        return logins;
    }

    public Login GetById(int ID)
    {
        Login login = _context.Logins
                            .Include(l => l.Expanse)
                            .FirstOrDefault(l => l.LoginId == ID);
        return login;
    }

    public void Update(Login newItem)
    {
        Login originalLogin = _context.Logins
                                        .Include(l => l.Expanse)
                                        .FirstOrDefault(l => l.LoginId == newItem.LoginId);

        if (originalLogin != null)
        {
            originalLogin.UserName = newItem.UserName;
            originalLogin.Password = newItem.Password;
            _context.Logins.Update(originalLogin);
            _context.SaveChanges();

        }
    }

    public Login GetLoginByUsernameAndPassword(string username, string password)
    {
        Login login = _context.Logins
                                .Include(l => l.Expanse)
                                .FirstOrDefault(l => l.UserName == username && l.Password == password);
        return login;

    }
}
