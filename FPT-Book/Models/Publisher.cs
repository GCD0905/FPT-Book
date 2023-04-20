using System.ComponentModel.DataAnnotations;

namespace FPT_Book.Models
{
    public class Publisher
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Image")]
        public string ProfilepictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
