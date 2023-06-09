﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreApp.Models
{
    public partial class Game
    {
        public Game()
        {
            Statistics = new HashSet<Statistics>();
            BuyingGames = new HashSet<BuyingGame>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(300)]
        public string Name { get; set; }
        public int GenreId { get; set; }
        public string Mode { get; set; }
        [Column(TypeName = "date")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [StringLength(50)]
        public string Developer { get; set; }
        [Column(TypeName = "date")]
        public DateTime RegistrationDate { get; set; }
        [StringLength(200)]
        public string? ImageLink { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }
        [Required]
        public float Rating { get; set; }
        [Required]
        public int NumberRatings { get; set; }
        public virtual ICollection<Statistics> Statistics { get; set; }
        public virtual ICollection<BuyingGame> BuyingGames { get; set;}
        [ForeignKey ("GenreId")]
        public virtual Genre Genre { get; set; }
    }
}
