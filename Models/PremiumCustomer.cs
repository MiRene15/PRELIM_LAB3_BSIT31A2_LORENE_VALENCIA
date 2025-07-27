namespace PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Models
{
    public class PremiumCustomer : Customer
    {
        public bool isVIP { get; set; }

        public override string Description()
        {
            return $"VIP Customer: {customerId}, " +
                   $"Name: {getFullName()}, " +
                   $"Age: {getAge()} ";
        }
    }
}
