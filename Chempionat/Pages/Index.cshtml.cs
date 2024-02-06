using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Chempionat.Pages
{
    [IgnoreAntiforgeryToken]
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		public string Message { get; set; } = "";

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
			
		}

        //OnGet должен быть только один!
        //public void OnGet(string name, int age)
        //      {
        //          Message = $"ID {age}, Name: {name}";
        //      }
        //public void OnGet(Person person)
        //      {
        //          Message = $"ID {person.Age}, Name: {person.Name}";
        //      }
        //public void OnGet(string[] people)
        //{
        //    string result = "";
        //    foreach (var person in people)
        //        result = $"{result}{person}; ";
        //    Message = result;
        //}
        //public void OnGet(Person[] person)
        //{
        //    string result = "";
        //    foreach (var people in person)
        //        result = $"{result}{people}; ";
        //    Message = result;
        //}
        //public void OnGet()
        //{
        //    Message = $"{Request.Query["name"]}";
        //}
        //public List<string> Values { get; set; }
        //public void OnGet()
        //{
        //    Message = $"Введите свое имя";
        //}
        //public void OnPost(string username) //поля форм (их атрибут name) должны называться также, как и параметры методов OnPost или OnGet. 
        //{
        //    Message = $"Ваше имя {username}";
        //}
        //public string PrintMessage()
        //{
        //    return "Message by method PrintMessage";
        //}
        //public void OnGet()
        //{
        //}

        [BindProperty(SupportsGet = true)]
        public string? Name { get; set; }

        [BindProperty]
        public int Age { get; set; }

        public object? Id { get; private set; }

        public void OnGet(int id)
        {
            Id = id;
        }

    }
}