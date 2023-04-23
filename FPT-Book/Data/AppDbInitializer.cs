using FPT_Book.Models;

namespace FPT_Book.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                // Bookstores
                if (!context.Bookstores.Any())
                {
                    context.Bookstores.AddRange(new List<Bookstore>()
                    {
                        new Bookstore()
                        {
                            Name = "Bookstore Hanoi",
                            Logo = "https://previews.123rf.com/images/korara/korara1604/korara160400311/54644040-bookstore-or-library-vector-logo-template-in-vintage-style.jpg",
                            Description = "This is the description of the Bookstore Hanoi"
                        },
                        new Bookstore()
                        {
                            Name = "Bookstore Danang",
                            Logo = "https://previews.123rf.com/images/korara/korara1604/korara160400311/54644040-bookstore-or-library-vector-logo-template-in-vintage-style.jpg",
                            Description = "This is the description of the Bookstore Danang"
                        },
                        new Bookstore()
                        {
                            Name = "Bookstore Ho Chi Minh",
                            Logo = "https://previews.123rf.com/images/korara/korara1604/korara160400311/54644040-bookstore-or-library-vector-logo-template-in-vintage-style.jpg",
                            Description = "This is the description of the Bookstore Ho Chi Minh"
                        }                     
                    });
                    context.SaveChanges();
                }

                // Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Stephen King",
                            Bio = "This is the Bio of Stephen King",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/e/e3/Stephen_King%2C_Comicon.jpg"

                        },
                        new Author()
                        {
                            FullName = "Peter Straub",
                            Bio = "This is the Bio of Peter Straub",
                            ProfilePictureURL = "https://static.wikia.nocookie.net/stephenking/images/e/ee/4-Peter-at-ICFA-2014.jpg/revision/latest?cb=20170604232126"
                        },
                        new Author()
                        {
                            FullName = "Harper Lee",
                            Bio = "This is the Bio of Harper Lee",
                            ProfilePictureURL = "https://s.abcnews.com/images/US/GTY_harper_Lee_as_160219_4x3t_992.jpg"
                        },
                        new Author()
                        {
                            FullName = "Jane Austen",
                            Bio = "This is the Bio of Jane Austen",
                            ProfilePictureURL = "https://ychef.files.bbci.co.uk/976x549/p058hxty.jpg"
                        },
                        new Author()
                        {
                            FullName = "Dan Brown",
                            Bio = "This is the Bio of Dan Brown",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/3/30/Dan_Brown_November_2015.jpg"
                        },
                        new Author()
                        {
                            FullName = "Keigo Higashino",
                            Bio = "This is the Bio of Keigo Higashino",
                            ProfilePictureURL = "https://images.mubicdn.net/images/cast_member/154538/cache-282897-1511561033/image-w856.jpg?size=800x"

                        },
                        new Author()
                        {
                            FullName = "William Gibson",
                            Bio = "This is the Bio of William Gibson",
                            ProfilePictureURL = "https://laspirale.org/picto/651@2x.jpg"
                        },
                        new Author()
                        {
                            FullName = "H.G. Wells",
                            Bio = "This is the Bio of H.G. Wells",
                            ProfilePictureURL = "https://images.gr-assets.com/authors/1588944685p8/880695.jpg"
                        },
                        new Author()
                        {
                            FullName = "Ken Blanchard",
                            Bio = "This is the Bio of Ken Blanchard",
                            ProfilePictureURL = "https://www.umass.edu/magazine/sites/default/files/styles/medium_scaled_no_crop/public/ken-blanchard.jpg?itok=jVaRhpKP"
                        },
                        new Author()
                        {
                            FullName = "Spencer Johnson",
                            Bio = "This is the Bio of Spencer Johnson",
                            ProfilePictureURL = "https://static01.nyt.com/images/2017/07/08/obituaries/08johnson-web/08johnson-web-superJumbo.jpg"
                        },
                        new Author()
                        {
                            FullName = "Napoleon Hill",
                            Bio = "This is the Bio of Napoleon Hill",
                            ProfilePictureURL = "https://cafebiz.cafebizcdn.vn/162123310254002176/2023/2/23/napoleon-hill-1677119216732-16771192171401744424230.jpg"

                        },
                        new Author()
                        {
                            FullName = "Paulo Coelho",
                            Bio = "This is the Bio of Paulo Coelho",
                            ProfilePictureURL = "https://i.scdn.co/image/ab6761610000e5eb6ad95d8390611f07ff34a0ee"
                        },
                        new Author()
                        {
                            FullName = "Michelle Obama",
                            Bio = "This is the Bio of Michelle Obama",
                            ProfilePictureURL = "https://epmgaa.media.clients.ellingtoncms.com/img/photos/2022/05/26/Michelle_Obama_t750x550.jpg?d885fc46c41745b3b5de550c70336c1b382931d2"
                        },
                        new Author()
                        {
                            FullName = "Nelson Mandela",
                            Bio = "This is the Bio of Nelson Mandela",
                            ProfilePictureURL = "https://hips.hearstapps.com/hmg-prod/images/_photo-by-per-anders-petterssongetty-images.jpg"
                        },
                        new Author()
                        {
                            FullName = "Anne Frank",
                            Bio = "This is the Bio of Anne Frank",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Anne_Frank_passport_photo%2C_May_1942.jpg/640px-Anne_Frank_passport_photo%2C_May_1942.jpg"
                        }
                    });
                    context.SaveChanges();
                }

                // Publishers
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            FullName = "Publisher 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Publishers/Publisher-1.jpeg"

                        },
                        new Publisher()
                        {
                            FullName = "Publisher 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Publishers/Publisher-2.jpeg"
                        },
                        new Publisher()
                        {
                            FullName = "Publisher 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Publishers/Publisher-3.jpeg"
                        },
                        new Publisher()
                        {
                            FullName = "Publisher 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Publishers/Publisher-4.jpeg"
                        },
                        new Publisher()
                        {
                            FullName = "Publisher 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/Publishers/Publisher-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                // Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        // Novel
                        new Book()
                        {
                            Name = "The Talisman",
                            Description = "This is the Life Book description",
                            Price = 39.50,
                            ImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781501192272/the-talisman-9781501192272_hr.jpg",                       
                            BookstoreId = 1,
                            PublisherId = 1,
                            BookCategory = BookCategory.Novel
                        },
                        new Book()
                        {
                            Name = "To Kill a Mockingbird",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "https://cdn.britannica.com/21/182021-050-666DB6B1/book-cover-To-Kill-a-Mockingbird-many-1961.jpg",
                            BookstoreId = 1,
                            PublisherId = 2,
                            BookCategory = BookCategory.Novel
                        },
                        new Book()
                        {
                            Name = "Pride and Prejudice",
                            Description = "This is the Ghost Book description",
                            Price = 39.50,
                            ImageURL = "https://kbimages1-a.akamaihd.net/4a05951e-7fba-475b-8f35-9663dfcf0f6f/353/569/90/False/pride-and-prejudice-363.jpg",
                            BookstoreId = 1,
                            PublisherId = 2,
                            BookCategory = BookCategory.Novel
                        },
                        
                        //Mystery
                        new Book()
                        {
                            Name = "The Da Vinci Code",
                            Description = "This is the Race Book description",
                            Price = 39.50,
                            ImageURL = "https://www.qbbooks.com/pictures/50614.jpg?v=1364840703",
                            BookstoreId = 1,
                            PublisherId = 4,
                            BookCategory = BookCategory.Mystery
                        },
                        new Book()
                        {
                            Name = "Malice",
                            Description = "This is the Scoob Book description",
                            Price = 39.50,
                            ImageURL = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1497270264i/20613611.jpg",
                            BookstoreId = 1,
                            PublisherId = 5,
                            BookCategory = BookCategory.Mystery
                        },                     
                        new Book()
                        {
                            Name = "A Death in Tokyo",
                            Description = "This is the Cold Soles Book description",
                            Price = 39.50,
                            ImageURL = "https://mpd-biblio-covers.imgix.net/9781250767509.jpg",
                            BookstoreId = 2,
                            PublisherId = 1,
                            BookCategory = BookCategory.Mystery
                        },
                        
                        // Science Fiction
                        new Book()
                        {
                            Name = "Neuromancer",
                            Description = "This is the Race Book description",
                            Price = 39.50,
                            ImageURL = "https://pbs.twimg.com/media/D1ExIGKUcAAQFxy.jpg",
                            BookstoreId = 1,
                            PublisherId = 4,
                            BookCategory = BookCategory.ScienceFiction
                        },
                        new Book()
                        {
                            Name = "The Time Machine",
                            Description = "This is the Scoob Book description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/61ZPzLlTaCL._AC_UF1000,1000_QL80_.jpg",
                            BookstoreId = 1,
                            PublisherId = 5,
                            BookCategory = BookCategory.ScienceFiction
                        },


                        new Book()
                        {
                            Name = "The War of the Worlds",
                            Description = "This is the Cold Soles Book description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51poES9PfEL.jpg",
                            BookstoreId = 2,
                            PublisherId = 1,
                            BookCategory = BookCategory.ScienceFiction
                        },

                        // Self-help
                        new Book()
                        {
                            Name = "The One Minute Manager",
                            Description = "This is the Race Book description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/513RrFGNeiL.jpg",
                            BookstoreId = 1,
                            PublisherId = 4,
                            BookCategory = BookCategory.SelfHelp
                        },
                        new Book()
                        {
                            Name = "Think and Grow Rich",
                            Description = "This is the Scoob Book description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/71UypkUjStL._AC_UF1000,1000_QL80_.jpg",
                            BookstoreId = 1,
                            PublisherId = 5,
                            BookCategory = BookCategory.SelfHelp
                        },
                        new Book()
                        {
                            Name = "The Alchemist",
                            Description = "This is the Cold Soles Book description",
                            Price = 39.50,
                            ImageURL = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1654371463i/18144590.jpg",
                            BookstoreId = 2,
                            PublisherId = 1,
                            BookCategory = BookCategory.SelfHelp
                        },

                        //Autobiography
                        new Book()
                        {
                            Name = "Becoming",
                            Description = "This is the Race Book description",
                            Price = 39.50,
                            ImageURL = "https://salt.tikicdn.com/ts/product/fe/9b/d6/f1986394b787e8fb1146d1f4914c2261.jpg",
                            BookstoreId = 1,
                            PublisherId = 4,
                            BookCategory = BookCategory.Autobiography
                        },
                        new Book()
                        {
                            Name = "Long Walk to Freedom",
                            Description = "This is the Scoob Book description",
                            Price = 39.50,
                            ImageURL = "https://ecx.images-amazon.com/images/I/51R0Em%2B1pCL.jpg",
                            BookstoreId = 1,
                            PublisherId = 5,
                            BookCategory = BookCategory.Autobiography
                        },
                        new Book()
                        {
                            Name = "The Diary of a Young Girl",
                            Description = "This is the Cold Soles Book description",
                            Price = 39.50,
                            ImageURL = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1560816565i/48855.jpg",
                            BookstoreId = 2,
                            PublisherId = 1,
                            BookCategory = BookCategory.Autobiography
                        }
                    });
                    context.SaveChanges();
                }

                // Authors & Books
                if (!context.Authors_Books.Any())
                {
                    context.Authors_Books.AddRange(new List<Author_Book>()
                    {
                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 1
                        },
                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 1
                        },

                         new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 2
                        },
                         new Author_Book()
                        {
                            AuthorId = 4,
                            BookId = 3
                        },

                        new Author_Book()
                        {
                            AuthorId = 5,
                            BookId = 4
                        },

                        //6
                        new Author_Book()
                        {
                            AuthorId = 6,
                            BookId = 5
                        },
                        new Author_Book()
                        {
                            AuthorId = 6,
                            BookId = 6
                        },
                        new Author_Book()
                        {
                            AuthorId = 7,
                            BookId = 7
                        },
                        new Author_Book()
                        {
                            AuthorId = 8,
                            BookId = 8
                        },
                        new Author_Book()
                        {
                            AuthorId = 8,
                            BookId = 9
                        },

                        //11
                        new Author_Book()
                        {
                            AuthorId = 9,
                            BookId = 10
                        },
                         new Author_Book()
                        {
                            AuthorId = 10,
                            BookId = 10
                        },

                        new Author_Book()
                        {
                            AuthorId = 11,
                            BookId = 11
                        },
                        new Author_Book()
                        {
                            AuthorId = 12,
                            BookId = 12
                        },
                        new Author_Book()
                        {
                            AuthorId = 13,
                            BookId = 13
                        },
                        new Author_Book()
                        {
                            AuthorId = 14,
                            BookId = 14
                        },
                        new Author_Book()
                        {
                            AuthorId = 15,
                            BookId = 15
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
