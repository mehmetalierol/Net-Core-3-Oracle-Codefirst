using Net_Core_3_Oracle_Codefirst.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_3_Oracle_Codefirst.Entities
{
    [Table("Users")]
    public class EntityUser : BaseEntity
    {
        public EntityUser()
        {
        }

        public int? Age { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
