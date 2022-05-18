namespace ServiceBook.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static ServiceBook.Data.DataConstants;

    public class Car
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(CarBrandMaxLength)]
        public string Make { get; set; }

        [Required]
        [MaxLength(CarModelMaxLength)]
        public string Model { get; set; }

        [Required]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int Year { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; init; }
    }
}
