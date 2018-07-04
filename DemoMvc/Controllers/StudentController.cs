using DemoMvc.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace DemoMvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            //El resultado del metodo Estudiantes lo asigno al ListadoEst que es de tipo list que acepta valor tipo student
            List<Student> ListadoEst = Estudiantes();


            return View(ListadoEst);
        }

        public List<Student> Estudiantes()
        {    
            //Creo una lista 
            List<Student> Est = new List<Student>();

            //Asigno valores a la lista
            Est.Add(new Student { Name = "Alex", Semester = 8 });
            Est.Add(new Student { Name = "B", Semester = 38 });
            Est.Add(new Student { Name = "C", Semester = 85 });

            //Regreso la lista con los valores
            return Est;
        }
        
    }
}