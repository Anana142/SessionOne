using Chempionat.DataBaseFolder;
using Chempionat.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Chempionat.Pages.Pacients
{
    public class RegistrationModel : PageModel
    {
        static List<Gender> genders { get; } = new List<Gender>
        {
            new Gender{GendersName="Мужской"},
            new Gender{GendersName="Женский"},
            new Gender{GendersName="Боевой вертолётик"},
        };
        public SelectList Genders { get; } = new SelectList(genders, "Id", "GendersName");
		
        public SelectList Jobs { get; } = new SelectList(DataBase.instanse.InsurancePolicies.ToList(), "Id", 

		public int GenderId { get; set; }

        public void OnGet()
        {
        }
    }
}
