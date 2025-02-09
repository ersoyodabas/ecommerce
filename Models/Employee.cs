namespace ecommerce.Models
{
    public class Employee
    {
        public int Id {get; set;}
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string FullName => $"{FirstName} {LastName.ToUpper()}";
        public int Age {get; set;} =0;

    }
}