using FPT_Book.Models;

namespace FPT_Book.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScopee = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScopee.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();
                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            FullName = "Author 1",
                            Bio = "This is the Bio of the first author",
                            ProfilepictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Author()
                        {
                            FullName = "Author 2",
                            Bio = "This is the Bio of the second author",
                            ProfilepictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Author()
                        {
                            FullName = "Author 3",
                            Bio = "This is the Bio of the thirth author",
                            ProfilepictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Publishers
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>()
                    {
                        new Publisher()
                        {
                            FullName = "Publisher 1",
                            Bio = "This is the Bio of the first Publisher",
                            ProfilepictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Publisher()
                        {
                            FullName = "Publisher 2",
                            Bio = "This is the Bio of the second Publisher",
                            ProfilepictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Publisher()
                        {
                            FullName = "Publisher 3",
                            Bio = "This is the Bio of the thirth Publisher",
                            ProfilepictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                    });
                    context.SaveChanges();
                }
                //Bookstores
                if (!context.Bookstores.Any())
                {
                    context.Bookstores.AddRange(new List<Bookstore>()
                    {
                    new Bookstore()
                    {
                        Name = "Bookstore 1",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                        Description = "This is the description of the first bookstore"
                    },
                    new Bookstore()
                    {
                        Name = "Bookstore 2",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                        Description = "This is the description of the second bookstore"
                    },
                    new Bookstore()
                    {
                        Name = "Bookstore 3",
                        Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                        Description = "This is the description of the thirth bookstore"
                    },
                    });
                    context.SaveChanges();
                }
                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Name = "Life",
                            Description = "This is the Life book description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            PublicDate = DateTime.Now.AddDays(-10),
                            BookStoreId = 3,
                            PublisherID = 3,
                            BookCategory = BookCategory.Autobiography
                        },
                        new Book()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            PublicDate = DateTime.Now,
                            BookStoreId = 1,
                            PublisherID = 1,
                            BookCategory = BookCategory.ScienceFiction
                        },
                        new Book()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost Book description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            PublicDate = DateTime.Now.AddDays(-7),
                            BookStoreId = 2,
                            PublisherID = 2,
                            BookCategory = BookCategory.Mystery
                        },
                    });
                    context.SaveChanges();
                }
                //Authors_Books
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
                            AuthorId = 3,
                            BookId = 1
                        },

                         new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 2
                        },
                         new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 2
                        },

                        new Author_Book()
                        {
                            AuthorId = 1,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 2,
                            BookId = 3
                        },
                        new Author_Book()
                        {
                            AuthorId = 3,
                            BookId = 3
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
