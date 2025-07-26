using System.Reflection.Metadata;

namespace PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Models
{
    public class Customer : BaseEntity, IDescribable
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual string Describe()
        {
            return $"Customer: {Name}, Email: {Email}";
        }
    }
}
        
