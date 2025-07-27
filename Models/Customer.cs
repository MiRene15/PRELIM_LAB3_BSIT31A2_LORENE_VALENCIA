
namespace PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Models
{
    public class Customer : BaseEntity
    {
        public int customerId { get; set; }

        public override string Description()
        {
            return $"Regular Customer: {customerId}, " +
                   $"Name: {getFullName()}, " +
                   $"Age: {getAge()}";
        }
    }
}
        
