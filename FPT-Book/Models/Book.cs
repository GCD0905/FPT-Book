using FPT_Book.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FPT_Book.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime PublicDate { get; set; }
        public BookCategory BookCategory { get; set; }

        //Relationships
        public List<Author_Book> Authors_Books { get; set; }

        //Bookstore
        public int BookStoreId { get; set; }
        [ForeignKey("BookStoreId")]
        public Bookstore Bookstore { get; set; }

        //Publisher
        public int PublisherID { get; set; }
        [ForeignKey("PublisherID")]
        public Publisher Publisher { get; set; }
    }
}
