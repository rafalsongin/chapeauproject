namespace ChapeauModel
{
    public class Employee
    {
        public string role = "";

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginUsername { get; set; }
        public string LoginPassword { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public EmployeeRole Role
        {
            get
            {
                if (role == "Waiter")
                {
                    return EmployeeRole.Waiter;
                }
                else if (role == "Chef")
                {
                    return EmployeeRole.Chef;
                }
                else if (role == "Bartender")
                {
                    return EmployeeRole.Bartender;
                }
                else if (role == "Manager")
                {
                    return EmployeeRole.Manager;
                }
                else
                {
                    return EmployeeRole.Undefined;
                }
            }
        }

        public override string ToString()
        {
            return $"";
        }
    }
}