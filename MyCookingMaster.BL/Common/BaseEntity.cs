using System.ComponentModel.DataAnnotations;

namespace MyCookingMaster.BL.Common
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}