using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataModels
{
    public class Cuisine
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public virtual List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

        public override string ToString()
        {
            return Type;
        }

    }
    //public enum CuisineType
    //{
    //    Italian = 1,
    //    American = 2,
    //    Mexican = 3,
    //    Korean = 4,
    //    Chinese = 5,
    //    Unassigned = 6
    //}
}
