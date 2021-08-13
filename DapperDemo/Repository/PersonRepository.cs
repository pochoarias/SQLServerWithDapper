using Dapper;
using DapperDemo.DataModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo.Repository
{
    public class PersonRepository
    {

        public IEnumerable<Person> GetPeople()
        {
            using IDbConnection connection = new SqlConnection(ConnectionStringHelper.GetConnectionString("SampleDB"));
            return connection.Query<Person>("SELECT * FROM Person");
        }

        public IEnumerable<Person> GetByLastName(string lastName)
        {
            using IDbConnection connection = new SqlConnection(ConnectionStringHelper.GetConnectionString("SampleDB"));
            return connection.Query<Person>("SELECT * FROM Person WHERE Person.LastName = @LastName", new { LastName = lastName});
        }

        public IEnumerable<Person> GetByLastNameByStoreProcedure(string lastName)
        {
            using IDbConnection connection = new SqlConnection(ConnectionStringHelper.GetConnectionString("SampleDB"));
            return connection.Query<Person>("dbo.spPerson_FilterByLastName @LastName", new { LastName = lastName });
        }

        public void InsertNewPerson(string firstName, string lastName)
        {
            using IDbConnection connection = new SqlConnection(ConnectionStringHelper.GetConnectionString("SampleDB"));
            connection.Execute("INSERT INTO Person(FirstName,LastName) VALUES (@FirstName,@LastName)", new { FirstName = firstName, LastName = lastName });
        }

    }
}
