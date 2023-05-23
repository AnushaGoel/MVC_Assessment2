using Assessment2_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using static Assessment2_MVC.Models.TrainingUser;

namespace Assessment2_MVC.Controllers
{
    public class TrainingUserController1 : Controller
    {
        InterfaceUser _repo;
        public TrainingUserController1(InterfaceUser repo)
        {
            _repo = repo;
        }

        public IActionResult Validate()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Validate(string EmailAddress, string Password)
        {
            var user = _repo.ValidateUser(EmailAddress, Password);
            if (user != null)
            {
                if ((int)user.RoleId == 0)
                {
                    return RedirectToAction("Index");
                }
                else if ((int)user.RoleId== 1)
                {
                    return RedirectToAction("Manager Dashboard,Index");
                }
                else if((int)user.RoleId == 2)
                {
                    return RedirectToAction("Employee Dashboard,Index");
                }
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Validate");
            }
        }

       
        public IActionResult ManagerDashboard()
        {
            return View();
        }
        public IActionResult Employee()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View(_repo.GetUser());
        }

        public IActionResult Create()
        {
            ViewData["ManagerName"] =
            new SelectList(_repo.GetUser().Where(x => (int)x.RoleId == 1).ToList(),
            "Id", "FirstName","LastName");



            return View();
        }
       
            [HttpPost]
      public  IActionResult Create(TrainingUser user)
        {
            //var t = _repo.GetUser();

            _repo.Create(user);
            return RedirectToAction("Index");

        }


        public IActionResult Edit(int id)
        {
            TrainingUser obj = _repo.GetUserById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(int id, TrainingUser user)
        {
            TrainingUser obj = _repo.GetUserById(id);
            if (obj != null)
                _repo.Edit(id, user);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            TrainingUser obj = _repo.GetUserById(id);
            return View(obj);
        }



        [HttpPost]
        public IActionResult Deleted(int Id)
        {
            _repo.Delete(Id);
            return RedirectToAction("Index");
        }

    }
}
