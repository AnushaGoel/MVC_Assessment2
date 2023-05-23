using Assessment2_MVC.Models;

namespace Assessment2_MVC
{
    public interface InterfaceCourse
    {
        List<Course> GetCourse();
        Course Create(Course course);
        Course GetCourseById(int id);
        int Edit(int id, Course course);
        int Delete(int id);

    }
}
