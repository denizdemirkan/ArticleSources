using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace article.n_plus_one.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }

        // Author Mapping
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
