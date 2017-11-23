using System;
using System.ComponentModel.DataAnnotations;

namespace SampleMvc.Db.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Вам надо заполнить {0}.")]
        [MaxLength(64)]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [MaxLength(1024)]
        public string Description { get; set; }
        [Required]
        [MaxLength(256)]
        public string Genre { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
