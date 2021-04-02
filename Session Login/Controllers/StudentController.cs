using Session_Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Session_Login.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> lst = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                Student st = new Student();
                st.ID = (i + 1);
                st.Name = "Sinh Vien " + (i + 1);
                st.Age = 20;
                lst.Add(st);
            }
            return View(lst);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student st)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id )
        {
            Student st = new Student();
            st.ID = (id);
            st.Name = "Sinh Vien " + (id);
            st.Age = 20;
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(Student st)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Student st = new Student();
            st.ID = (id);
            st.Name = "Sinh Vien " + (id);
            st.Age = 20;
            return View(st);
        }
        [HttpPost]
        public ActionResult Details(Student st)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int  id)
        {
            Student st = new Student();
            st.ID = (id);
            st.Name = "Sinh Vien " + (id);
            st.Age = 20;
            return View(st);
        }
        [HttpPost]
        public ActionResult Delete(Student st)
        {
            return RedirectToAction("Index");
        }
    }
}