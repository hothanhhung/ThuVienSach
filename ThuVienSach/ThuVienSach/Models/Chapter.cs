using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSach.Models
{
    public class Chapter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string BookId { get; set; }
        public Book Book { get; set; }

        [NotMapped]
        public string NextChapterUrl { get; set; }

        override public string ToString()
        {
            return Name;
        }
    }
}
