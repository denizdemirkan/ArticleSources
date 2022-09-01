using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace article.n_plus_one.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }

        // Books Mapping
        public List<Book> Books { get; set; }
    }
}
