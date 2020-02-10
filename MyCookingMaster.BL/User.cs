using System.Collections.Generic;
using MyCookingMaster.BL.Common;

namespace MyCookingMaster.BL
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}