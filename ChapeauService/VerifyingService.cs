using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    // fix
    public class VerifyingService
    {
        private EmployeeDao verifyingDb;

        public VerifyingService()
        {
            verifyingDb = new EmployeeDao();
        }

        /*public List<Employee> GetEmployees()
        {
            List<Employee> verifyings = employeeDb.GetAllEmployees();

            return employee;
        }*/
    }
}