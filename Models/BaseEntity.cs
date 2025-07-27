namespace PRELIM_LAB3_BSIT31A2_LORENE_VALENCIA.Models
{
    public abstract class BaseEntity : IDescribable
    {
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public DateTime birthDay { get; set; }

        //Computation for Age Based on birthDay
        public int getAge()
        {
            var today = DateTime.Today;
            var age = today.Year - birthDay.Year;
            if (birthDay > today.AddYears(-age)) age--;
            return age;
        }

        //Concantinate Full Name
        public string getFullName()
        {
            return $"{lastName}, {firstName} {middleName}";
        }

        public virtual string Description()
        {
            return $"Name: {getFullName()}, Age: {getAge()}";
        }


    }
}
