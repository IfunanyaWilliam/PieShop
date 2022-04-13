using PieShop.Models;
using System.Collections.Generic;

namespace PieShop.Models.Contracts
{
    public interface IPieRepository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById(int id);
    }
}
