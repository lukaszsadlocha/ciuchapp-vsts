using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChiuchApp.WebApi.Core3.Entities
{
    public class Piece
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(1500)]
        public string Description { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public Guid CategoryId { get; set; }
    }
}