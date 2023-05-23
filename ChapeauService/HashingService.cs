using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class HashingService
    {
        private EmployeeDao employeeDb;

        public HashingService()
        {
            employeeDb = new EmployeeDao();
        }

        /*public List<Employee> GetEmployees()
        {
            List<Employee> employee = employeeDb.GetAllEmployees();

            return employee;
        }*/
    }
}