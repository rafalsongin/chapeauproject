using ChapeauDAL;
using ChapeauModel;
using BCryptNet = BCrypt.Net.BCrypt;

namespace ChapeauService
{
    public class VerifyingService
    {
        private EmployeeDao employeeDb;

        public VerifyingService()
        {
            employeeDb = new EmployeeDao();
        }

        public bool isCorrectPassword(string inputUsername, string inputPassword)
        {
            if (employeeDb.GetEmployeeByUsername(inputUsername) == null) 
            {
                return false;
            }

            // get hashed password from the database
            Employee employee = employeeDb.GetEmployeeByUsername(inputUsername);
            string hashedPassword = employee.LoginPassword;

            // check if the password is correct
            bool passwordMatch = BCryptNet.Verify(inputPassword, hashedPassword);

            return passwordMatch;
        }
    }
}