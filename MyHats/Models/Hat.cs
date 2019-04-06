using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHats.Models
{
    public class Hat
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal PriceUsd { get; set; }

        public string ImageLocation { get; set; }
    }
}
