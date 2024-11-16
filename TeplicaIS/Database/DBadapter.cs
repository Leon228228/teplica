using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeplicaIS.Database
{
    class DBadapter
    {
        string strConnect = "Persist Security Info=False;Trusted_Connection=True;database=Teplica;server=DESKTOP-PFVV43D;Encrypt=True;TrustServerCertificate=true;";


        public IDbConnection Connection
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
                var sqlQuery = "INSERT INTO person (name, email, pass) VALUES (@name, @email, @pass)";

                var parameters = new
                {
                    name = person.Name,
                    email = person.email,
                    pass = person.pass
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
