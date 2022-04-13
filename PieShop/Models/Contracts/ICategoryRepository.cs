using System.Collections.Generic;

namespace PieShop.Models.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<CategoryViewModel> Categories { get; }
    }
}
