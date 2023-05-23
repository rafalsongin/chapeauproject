using System.Data;
using System.Data.SqlClient;
using ChapeauModel;

namespace ChapeauDAL
{
    public class EmployeeDao : BaseDao
    {
        public List<Employee> GetAllEmployees()
        {
            // sql query
            string query =  "SELECT id, first_name, last_name, login_username, login_password, date_of_birth, phone_number, email, role FROM [employee]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
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
                    LoginPassword = (string)datarow["login_password"],
                    DateOfBirth = (DateOnly)datarow["date_of_birth"],
                    PhoneNumber = (int)datarow["phone_number"],
                    Email = (string)datarow["email"],
                    Role = (EmployeeRole)datarow["role"]
                };

                employees.Add(employee);
            }
            return employees;
        }

        public List<Employee> GetEmployeeById(int id)
        {
            string query = "SELECT id, first_name, last_name, login_username, login_password, date_of_birth, phone_number, email, role FROM [employee] WHERE id = @id";
            // to prevent sql injection
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", id);

            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
    }
}