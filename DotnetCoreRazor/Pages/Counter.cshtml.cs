namespace DotnetCoreRazor.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class CounterModel : PageModel
    {
        public int Number { get; set; }

        public void OnPost()
        {
            int number = int.Parse(Request.Form["number"]);
            Number = number + 1;
        }
    }
}