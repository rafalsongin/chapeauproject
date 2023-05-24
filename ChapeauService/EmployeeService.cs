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
            List<Employee> employees = employeeDb.GetAllEmployees();

            return employees;
        }

        public Employee GetEmployeeByUsername(string username)
        {
            Employee employee = employeeDb.GetEmployeeByUsername(username);

            return employee;
        }
    }
}