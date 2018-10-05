using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebApplication1.Models
{
    public class orderResponse
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Pizza { get; set; }
        [Required]
        public string Drink { get; set; }
        [Required]
        public string Snack { get; set; }
    }
}