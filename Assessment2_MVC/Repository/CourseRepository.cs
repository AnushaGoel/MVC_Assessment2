using Assessment2_MVC.Context;
using Assessment2_MVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assessment2_MVC.Repository
{
    public class CourseRepository:InterfaceCourse
    {
        TrainingDbContext __db;

        public CourseRepository(TrainingDbContext db1)
        {
            __db = db1;
        }

        public List<Course> GetCourse()
        {
            return __db.Courses.ToList();
        }
        public Course GetCourseById(int id)
        {
            return __db.Courses.FirstOrDefault(x => x.CourseId == id);
        }
        public Course Create(Course course)
        {
            __db.Courses.Add(course);
            __db.SaveChanges();
            return course;
        }

        public int Delete(int id)
        {
            Course obj = GetCourseById(id);
            if (obj != null)
            {
                __db.Courses.Remove(obj);
                __db.SaveChanges();
                return 0;
            }
            else
            {
                return 1;
            }
        
    }



        public int Edit(int id, Course course)
        {
            Course obj = GetCourseById(id);
            if (obj != null)
            {
                foreach (Course temp in __db.Courses)
                {
                    if (temp.CourseId == id)
                    {
                        
                        temp.CourseName = course.CourseName;
                        temp.Description = course.Description;
                        temp.Duration = course.Duration;
                       

                    }
                }
                __db.SaveChanges();
                return 0;
            }
            else
            {
                return 1;
            }
        }

        //List<Course> InterfaceCourse.GetCourse()
        //{
        //    throw new NotImplementedException();
        //}

        //Course InterfaceCourse.GetCourseById(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
