using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_problem.Data.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }   

        [ForeignKey(nameof(Author))]
        public int Author_ID { get; set; }
        public Author Author { get; set; }

        [Required]
        public string Publisher {  get; set; }

        [Required]
        public double Price { get; set; }

    }
}
