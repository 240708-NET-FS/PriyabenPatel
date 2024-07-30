using ExpanseTrackerApp.DAO;
using ExpanseTrackerApp.Entities;
using ExpanseTrackerApp.Utility.Exceptions;
using ExpanseTrackerApp.Utility;



namespace ExpanseTrackerApp.Service;

public class LoginService : IService<Login>
{
    private readonly LoginDAO _loginDAO;
    public LoginService(LoginDAO loginDAO)
    {
        _loginDAO = loginDAO;
    }

    public Login Login(string username, string password)
    {
        if (username.Length == 0 || password.Length == 0)
        {
            throw new LoginException("Invalid Input");
        }


        Login login = _loginDAO.GetLoginByUsernameAndPassword(username,password);
       
        if (login != null)
        {
            State.currentLogin = login;
            return login;
        }
        throw new LoginException("Invalid Login");
    }


    public void Create(Login item)
    {
        throw new NotImplementedException();
    }
    public void Delete(Login item)
    {
        throw new NotImplementedException();
    }

    public ICollection<Login> GetAll()
    {
        throw new NotImplementedException();
    }

    public Login GetById(int Id)
    {
        throw new NotImplementedException();
    }

    public void Update(Login item)
    {
        throw new NotImplementedException();
    }
    
}

