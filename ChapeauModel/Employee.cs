namespace ChapeauModel
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public EmployeeRole Role { get; set; }

        public override string ToString()
        {
            return $"";
        }
    }
}