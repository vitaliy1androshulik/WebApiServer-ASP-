using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Dto
{
    public class MercedesDto
    {
        public int? Id { get; set; }
        public string? ImgUrl { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int Year { get; set; }
        public double Volume { get; set; }
        public int HorsePower { get; set; }
        public string? Description { get; set; }
        public int ClassId { get; set; }
        public string? MercedesClass { get; set; }
        public int BrandOfCarId { get; set; }
        public string? BrandOfCar { get; set; }
    }
}
