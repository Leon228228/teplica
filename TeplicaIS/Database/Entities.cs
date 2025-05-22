using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeplicaIS.Database
{
    internal class Entities

    {
    }
    public class role
    {
        public int id { get; set; }
        public string name { get; set; }
    }

    public class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string patronymic { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int role_id { get; set; }
    }

    public class teplica
    {
        public int id { get; set; }
        public int type_id { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public string lenght { get; set; }
    }

    public class heat
    {
        public int id { get; set; }
        public string pressure { get; set; }
        public string temperature { get; set; }
        public string time { get; set; }
        public int teplica_id { get; set; } 
    }

    public class type
    {
        public int id { get; set; }
        public string name { get; set; }
    }










}
