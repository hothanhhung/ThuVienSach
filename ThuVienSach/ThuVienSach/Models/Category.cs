using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVienSach.Models
{
    public class Category
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDisplay { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
