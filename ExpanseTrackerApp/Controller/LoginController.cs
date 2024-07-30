using ExpanseTrackerApp.DAO;
using ExpanseTrackerApp.Entities;
using ExpanseTrackerApp.Service;
using ExpanseTrackerApp.Utility;

namespace ExpanseTrackerApp.Controller;

public class LoginController
{
    // Login
    // UI for logging in
    private LoginService loginService;
    public LoginController(LoginService service)
    {
        loginService = service;
    }
    public void Login()
    {
        Console.WriteLine("ATTEMPTING TO LOGIN");
        Console.WriteLine("Please Enter Your UserName: ");

        string username = Console.ReadLine();

        Console.WriteLine("Please Enter Your Password: ");

        string password = Console.ReadLine();

        // Console.WriteLine(username);
        // Console.WriteLine(password);

        try 
        {
            Login login = loginService.Login(username,password);
            Console.WriteLine(login);

            Console.WriteLine("Do you want to quit? type YES or NO");

            string input = Console.ReadLine();

            switch(input)
            {
                case "YES":
                    State.isActive = false;
                    break;
                case "NO":
                    break;
                default:
                    break;
            }
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

}