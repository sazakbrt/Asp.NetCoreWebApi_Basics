using bookDemo.Models;

namespace bookDemo.Data
{
    public static class ApplicationContext
    {
        public static List<Book> Books { get; set; }
        static ApplicationContext()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Test",
                    Price = 10,
                },
                new Book() 
                {
                    Id = 2,
                    Title = "Test2",
                    Price = 15,
                },
                new Book()
                {
                    Id= 3,
                    Title = "Test3",
                    Price = 20,
                }
            };
        }
    }
}
