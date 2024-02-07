using Chempionat.DataBaseFolder;
using Chempionat.Tools;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Chempionat.Pages.Pacients
{
    public class RegistrationModel : PageModel
    {
        public SelectList Genders { get; } = new SelectList(DataBase.instanse.Genders, "Id", "GendersName");

        public List<InsurancyCompany> InsurancyCompaniesFirst { get; } = DataBase.instanse.InsurancyCompanies.ToList();
        public SelectList InsurancyCompanies { get; } = new SelectList(DataBase.instanse.InsurancyCompanies.ToList(), "Id", "InsurancyCompaniesTitle");

        [BindProperty] 
		public int GenderId { get; set; }
		[BindProperty]
		public int InsuranceCompanyId { get; set; }

        [BindProperty]  
        public Pacient NewPacient { get; set; }

        [BindProperty]
        public InsurancePolicy NewInsurancePolicy { get; set; }

        public record class Vaslues(string jobName, string PasportSeries, string PasportNumber);

		public void OnGet()
        {

        }
        public void OnPost(Vaslues values)
        {
            Job job = DataBase.instanse.Jobs.FirstOrDefault(s => s.JobsCompanyName == values.jobName);

            if (job == null)
            {
				DataBase.instanse.Jobs.Add(job);
                DataBase.instanse.SaveChanges();
			}

            NewPacient.PacientsJobId = DataBase.instanse.Jobs.First(s => s.JobsCompanyName == job.JobsCompanyName).Id;

		}
    }
}
