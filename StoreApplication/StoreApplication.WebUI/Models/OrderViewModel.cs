using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.WebUI.Models
{
    public class OrderViewModel
    {
        // the HTML/tag helpers like "DisplayNameFor"
        // will use this instead of the property's name
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        //public IEnumerable<ReviewViewModel> Reviews { get; set; }
        [Display(Name = "Location")]
        public string LocationName { get; set; }

        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime? OrderTime { get; set; }

        public List<String> Products { get; set; }

        public int Price { get; set; }

        public int Drink { get; set; }

        public int Burger { get; set; }

        public int Fries { get; set; }

        //public string Name { get; set; }


    }
}
