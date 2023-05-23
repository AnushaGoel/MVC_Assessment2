using Assessment2_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Assessment2_MVC.Controllers
{
    public class BatchController1 : Controller
    {
        InterfaceBatch _repo2;
        InterfaceCourse _repo3;
        public BatchController1(InterfaceBatch repo2, InterfaceCourse repo3)
        {
            _repo2 = repo2;
            _repo3 = repo3;
        }

        public IActionResult Index()
        {
            return View(_repo2.GetBatches());
        }

        public IActionResult Create()
        {

            ViewData["Courses"] = new SelectList(_repo3.GetCourse(), "CourseId", "CourseName");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Batch batch)
        {
            _repo2.Create(batch);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Batch obj = _repo2.GetBatchById(id);
            return View(obj);
        
        }

        [HttpPost]
        public IActionResult Edit(int id,Batch batch) {
            Batch obj = _repo2.GetBatchById(id);
            if (obj != null)
                _repo2.Edit(id, batch);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Batch obj = _repo2.GetBatchById(id);
            return View(obj);
        }



        [HttpPost]
        public IActionResult Deleted(int batchId)
        {
            _repo2.Delete(batchId);
            return RedirectToAction("Index");
        }

    }
}
