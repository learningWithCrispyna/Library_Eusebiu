using System.Collections.Generic;

namespace Library.DLL.DataModels {
    public class Author {
        public Author()
        {
            Books = new List<Book>();
        }
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
