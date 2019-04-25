using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSach.Models
{
    public class Book
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Author { get; set; }
        public string Introduction { get; set; }
        public bool IsDisplay { get; set; }
        public int NumberOfChapters { get; set; }
        public bool IsFull { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public string ImageUrl { get; set; }
        [NotMapped]
        public string ReadContentUrl { get; set; }
    }
}
