using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entities
{
    public class Tag
    {

        private HashSet<Book> _books;
        [Key]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public IEnumerable<Book> Books => _books.ToList();

        public Tag(string name)
        {
            Name = Name;
        }
    }
}