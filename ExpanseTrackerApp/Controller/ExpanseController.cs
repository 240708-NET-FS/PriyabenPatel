using ExpanseTrackerApp.DAO;
using ExpanseTrackerApp.Entities;
using ExpanseTrackerApp.Service;

namespace ExpanseTrackerApp;

public class ExpanseController
{
    private ExpanseService expanseService;
    public ExpanseController(ExpanseService service)
    {
        expanseService = service;
    }
}