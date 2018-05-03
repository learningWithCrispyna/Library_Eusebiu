using System;

namespace Library.DLL.DataModels {

    public class Book {
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Author Author { get; set; }
    }
}
