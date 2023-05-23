using Assessment2_MVC.Models;

namespace Assessment2_MVC
{
    public interface InterfaceUser
    {
        List<TrainingUser> GetUser();
        TrainingUser Create(TrainingUser user);
        TrainingUser GetUserById(int id);
        TrainingUser ValidateUser(string EmailAddress, string Password);
        int Edit(int id, TrainingUser user);
        int Delete(int id);

    }
}
