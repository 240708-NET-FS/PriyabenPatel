namespace ExpanseTrackerApp.Entities;

public class Login
{
    public int LoginId {get;set;}
    public string UserName{get;set;}
    public string Password {get;set;}

    public int UserId{get;set;}

    public Expanse Expanse {get;set;}

    public override string ToString()
    {
        return $"{LoginId} {UserName} {Password} {UserId} {Expanse}";
    }
}