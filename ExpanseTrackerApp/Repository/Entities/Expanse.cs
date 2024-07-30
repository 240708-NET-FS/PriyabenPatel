namespace ExpanseTrackerApp.Entities;

public class Expanse
{
    public int ExpanseId {get;set;}
    public int Grocery {get;set;}
    public int HouseRant {get;set;}
    public int Utility {get;set;}

    public Login Login {get;set;}

    public override string ToString()
    {
        return $"{ExpanseId} {Grocery} {HouseRant} {Utility}";
    }

    
}