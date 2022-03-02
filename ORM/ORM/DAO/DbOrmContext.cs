
using MySql.Data.EntityFramework;
using ORM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ORM.DAO
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DbOrmContext:DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbOrmContext() : base("url")
        {

        }
    }
}