using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeplicaIS.Database
{
    class DBadapter
    {
        string strConnect = "Persist Security Info=False;Trusted_Connection=True;database=Teplica;server=DESKTOP-PFVV43D;Encrypt=True;TrustServerCertificate=true;";


        IDbConnection Connection
        {
            get
            {
                return new SqlConnection(strConnect);
            }
        }

        public void Conn()
        {
            new SqlConnection(strConnect);
        }

        public void InsertPerson(Person person)
        {
            using (IDbConnection conn = Connection)
            {
                var sqlQuery = "INSERT INTO person (name, surname, patronymic, login, password, role_id)" +
                    " VALUES (@name, @surname, @patronymic, @login, @password, @role_id)";

                var parameters = new
                {
                    name = person.name,
                    surname = person.surname,
                    patronymic = person.patronymic,
                    login = person.login,
                    password = person.password,
                    role_id = person.role_id
                };


                conn.Execute(sqlQuery, parameters);

            }
        }

        public List<Person> GetPersonList()
        {
            using (IDbConnection conn = Connection)
            {
                var list = conn.Query<Person>("SELECT * FROM person").ToList();
                return list;
            }
        }
    }
}
