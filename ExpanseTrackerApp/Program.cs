using ExpanseTrackerApp.Entities;
using ExpanseTrackerApp.DAO;
using ExpanseTrackerApp.Service;
using ExpanseTrackerApp.Controller;
using ExpanseTrackerApp.Utility;


namespace ExpanseTrackerApp;

public class Program
{
    public static void Main(string[] args)
    {
        
        using (var context = new ExpanseDbContext())
        {
            ExpanseDAO expanseDao = new ExpanseDAO(context);
            LoginDAO loginDao = new LoginDAO(context);

            ExpanseService expanseService = new ExpanseService(expanseDao);
            LoginService loginService = new LoginService(loginDao);

            ExpanseController expanseController = new ExpanseController(expanseService);
            LoginController loginController = new LoginController(loginService);

            State.isActive = true;

            while (State.isActive)
            {
                loginController.Login();
            }
           


            // expanseDao.Create(new Expanse{Grocery = 450, HouseRant = 1200, Utility = 250});
            // ICollection<Expanse> expanses = expanseDao.GetAll();
            // foreach (var expanse in expanses)
            // {
            //     Console.WriteLine(expanse);
            // }

            // loginDao.Create(new Login{UserName = "Isha", Password = "Isha1234", UserId = 2});
            // ICollection<Login> logins = loginDao.GetAll();
            // foreach (var login in logins)
            // {
            //     Console.WriteLine(login);
            // }

            // var expanse = new Expanse {Grocery = 120, HouseRant = 1050, Utility = 210};

            // context.Expanses.Add(expanse);

            // var login = new Login {UserName = "Jiya", Password = "Jiya1234",UserId = 4};
            // context.Logins.Add(login);
            // context.SaveChanges();
        }
    }
}
