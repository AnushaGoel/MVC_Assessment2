using Assessment2_MVC.Context;
using Assessment2_MVC.Models;

namespace Assessment2_MVC.Repository
{
    public class UserRepository: InterfaceUser
    {
        TrainingDbContext _db;

        public UserRepository(TrainingDbContext db)
        {
            _db = db;
        }

        public List<TrainingUser> GetUser()
        {
            return _db.TrainingUsers.ToList();
        }
        public TrainingUser GetUserById(int id)
        {
            return _db.TrainingUsers.FirstOrDefault(x => x.Id == id);
        }
        public TrainingUser ValidateUser(string uname, string password)
        {
            return _db.TrainingUsers.FirstOrDefault(x => x.EmailAddress.Equals(uname) && x.Password.Equals(password));
        }
        public TrainingUser Create(TrainingUser user)
        {
            _db.TrainingUsers.Add(user);
            _db.SaveChanges();
            return user;
        }

        public int Delete(int id)
        {
            TrainingUser obj = GetUserById(id);
            if (obj != null)
            {
                _db.TrainingUsers.Remove(obj);
                _db.SaveChanges();
                return 0;
            }
            else
            {
                return 1;
            }
        }

       
        
        
        
        
        
        
        public int Edit(int id, TrainingUser user)
        {
            TrainingUser obj = GetUserById(id);
            if (obj != null)
            {
                foreach (TrainingUser temp in _db.TrainingUsers)
                {
                    if (temp.Id == id)
                    {
                        temp.EmailAddress = user.EmailAddress;
                        temp.FirstName = user.FirstName;
                        temp.LastName=  user.LastName;
                        temp.ContactNo = user.ContactNo;
                        temp.EmailAddress = user.EmailAddress;
                        temp.ManagerId=user.ManagerId;

                    }
                }
                _db.SaveChanges();
                return 0;
            }
            else
            {
                return 1;
            }
        }




    }


}
