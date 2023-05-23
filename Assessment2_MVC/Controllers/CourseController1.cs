using Assessment2_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assessment2_MVC.Controllers
{
    public class CourseController1 : Controller
    {

        InterfaceCourse _repo1;
        public CourseController1(InterfaceCourse repo1)
        {
            _repo1 = repo1;
        }


        public IActionResult Index()
        {
            return View(_repo1.GetCourse());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course course)
        {
            _repo1.Create(course);
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            Course obj = _repo1.GetCourseById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(int id, Course course)
        {
            Course obj = _repo1.GetCourseById(id);
            if (obj != null)
                _repo1.Edit(id, course);
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            Course obj = _repo1.GetCourseById(id);
            return View(obj);
        }



        [HttpPost]
        public IActionResult Deleted(int courseId)
        {
            _repo1.Delete(courseId);
            return RedirectToAction("Index");
        }


    }
}
