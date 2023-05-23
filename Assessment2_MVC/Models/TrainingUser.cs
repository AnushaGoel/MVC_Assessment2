namespace Assessment2_MVC.Models
{
    public class TrainingUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }

        public string EmailAddress { get; set; }
        public string Password{get;set;}
        public Boolean IsActive { get; set; }

        public int ManagerId { get; set; }
        public Role RoleId { get; set; }

        public enum Role
        {
            Manager=1,
            Employee=2
        }
        

       

    }
}
