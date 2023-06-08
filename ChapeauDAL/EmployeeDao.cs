using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetAllEmployees()
        {
            string query =  "SELECT id, first_name, last_name, login_username, hashed_password, date_of_birth, phone_number, email, role FROM [employee]";

            return ReadTables(ExecuteSelectQuery(query));
        }

        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employees = new List<Employee>();

            foreach (DataRow datarow in dataTable.Rows)
            {
                Employee employee = new Employee()
                {
                    Id = (int)datarow["id"],
                    FirstName = (string)datarow["first_name"],
                    LastName = (string)datarow["last_name"],
                    LoginUsername = (string)datarow["login_username"],
                    LoginPassword = (string)datarow["hashed_password"],
                    DateOfBirth = (DateTime)datarow["date_of_birth"],
                    PhoneNumber = (int)datarow["phone_number"],
                    Email = (string)datarow["email"],
                    role = (string)datarow["role"]
                };

                employees.Add(employee);
            }
            return employees;
        }

        public Employee GetEmployeeByUsername(string username)
        {
            string query = "SELECT id, first_name, last_name, login_username, hashed_password, date_of_birth, phone_number, email, role FROM [employee] WHERE login_username = @Username";
            // prevents from SQL injection
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@Username", username)
            };

            DataTable dataTable = ExecuteSelectQueryWithParameters(query, sqlParameters);

            // if no records found based on the username - user with given username doesn't exist
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return ReadEmployee(dataTable);
            }
        }

        private Employee ReadEmployee(DataTable dataTable)
        {
            DataRow datarow = dataTable.Rows[0];
            Employee employee = new Employee()
            {
                Id = (int)datarow["id"],
                FirstName = (string)datarow["first_name"],
                LastName = (string)datarow["last_name"],
                LoginUsername = (string)datarow["login_username"],
                LoginPassword = (string)datarow["hashed_password"],
                DateOfBirth = (DateTime)datarow["date_of_birth"],
                PhoneNumber = (int)datarow["phone_number"],
                Email = (string)datarow["email"],
                role = (string)datarow["role"]
            };

            return employee;
        }
    }
}