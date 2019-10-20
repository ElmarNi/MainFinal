using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MainFinalBack.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        public int ModelId { get; set; }

        public virtual Model Model { get; set; }

        [Required]
        public int CarClassId { get; set; }
        public CarClass CarClass { get; set; }

        [Required]
        public int ManufactureYear { get; set; }

        [Required]
        [Range(1, 16)]
        public decimal Engine { get; set; }

        [Required]
        [Range(0, double.PositiveInfinity)]
        public int Milage { get; set; }

        [Required]
        public int BodyTypeId { get; set; }
        public virtual BodyType BodyType { get; set; }

        [Required]
        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }

        [Required]
        public int TransmissionId { get; set; }
        public Transmission Transmission { get; set; }

        [Required]
        public int WheelDriveId { get; set; }
        public WheelDrive WheelDrive { get; set; }

        [Required]
        [Range(1, double.PositiveInfinity)]
        public decimal Price { get; set; }

        [Required]
        public int CityId { get; set; }
        public City City { get; set; }

        public bool IsVip { get; set; }

        [Required, StringLength(1500, MinimumLength = 20)]
        public string Description { get; set; }

        [Required]
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }

        public string MainImageUrl { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }

        public virtual ICollection<CarDetailImage> CarDetailImages { get; set; }

        [NotMapped]
        public ICollection<IFormFile> DetailPhotos { get; set; }

        public virtual Advertisement Advertisement { get; set; }
    }
}
