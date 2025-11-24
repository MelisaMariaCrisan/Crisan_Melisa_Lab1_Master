using Microsoft.AspNetCore.Mvc;

namespace Crisan_Melisa_Lab1_Master.Controllers
{
    public class MelisaController : Controller
    {
        
        public string Index()
        {
            return "Bine ai venit pe pagina!";
        }

        public string Despre()
        {
            return "Aceasta este o pagina dezvoltata la modulul Medii de programare avansate.";
        }

        public string Detalii(string nume, int varsta)
        {
            return $"Salut {nume}! Ai {varsta} ani. Mesaj generat din controller-ul Melisa.";
        }

    }
}
