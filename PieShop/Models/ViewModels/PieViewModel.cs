using PieShop.Models;
using System.Collections.Generic;


namespace PieShop.Models.ViewModels
{
    public class PieViewModel
    {
        public IEnumerable<Pie> Pies { get; set; } = new List<Pie>();
        public string CurrentCategory { get; set; }
    }
}
