
using System.Collections.Generic;


namespace PieShop.Models.ViewModels
{
    public class PieViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
