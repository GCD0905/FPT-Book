using System.ComponentModel.DataAnnotations;

namespace FPT_Book.Models
{
    public class Bookstore
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Image")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships
        public List<Book> Books { get; set; } 
    }
}
