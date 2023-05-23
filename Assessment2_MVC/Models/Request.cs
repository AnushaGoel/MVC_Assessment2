using System.ComponentModel.DataAnnotations;

namespace Assessment2_MVC.Models
{
        public class Request
        {
            [Key]
            public int RequestId { get; set; }
            public int Id { get; set; }
            public int BatchId { get; set; }
            public string Status { get; set; } = "pending";
            public string? Comments { get; set; }
            public int CourseId { get; set; }
            public Course course { get; set; }
        }
    
}
