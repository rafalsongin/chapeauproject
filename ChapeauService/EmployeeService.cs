using ChapeauDAL;
using ChapeauModel;

namespace ChapeauService
{
    public class EmployeeService
    {
        private EmployeeDao employeeDb;

        public EmployeeService()
        {
            employeeDb = new EmployeeDao();
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employee = employeeDb.GetAllEmployees();

            return employee;
        }
    }
}