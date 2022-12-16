using System.Collections.Generic;
using System.Threading.Tasks;
using DevPortfolio.Models.Entety;
using Microsoft.AspNetCore.Mvc;

namespace DevPortfolio.ViewComponents
{
    public class AboutSiteViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        public  IViewComponentResult Invoke()
        {
            var about = new List<AboutMe>
            {
                new AboutMe(1,"تاریخ تولد","1377"),
                new AboutMe(2,"وبسایت","-"),
                new AboutMe(3,"تلفن","09168467533"),
                new AboutMe(4,"شهر","خرم اباد"),
                new AboutMe(8,"سن","25"),
                new AboutMe(6,"درجه","Sinior"),
                new AboutMe(7,"ایمیل","Alirasty1997@gmail.com")
             
            };
            return View("AboutSite",about);
        }
    }
}