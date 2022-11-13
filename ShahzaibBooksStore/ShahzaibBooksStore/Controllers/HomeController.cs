using Microsoft.AspNetCore.Mvc;
namespace ShahzaibBooksStore.Controllers

{
    public class HomeController : Controller
    {
        //public string Index() //Action Method
        //{
        //    return "ShahzaibBookStore";
        //}

        public ViewResult Index() //Name of Action Method should be same as the View you want to return
        {
            return View();  //If name of View is different than the name of Action Method, then
                            //you have to pass the View File Name as a Parameter inside View();
                            //e.g View(myViewFile); 
        }

        public ViewResult AboutUS()
        {
            return View();
        }

        public ViewResult ContactUs()  //The view file corresponding to this action method is in shared folder not in Home Folder.
        {
            return View();
        }
    }
}
