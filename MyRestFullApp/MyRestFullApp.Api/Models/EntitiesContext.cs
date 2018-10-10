using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyRestFullApp.Api.Models
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base(nameOrConnectionString:ConnectionString())
        {
        }
        private static string ConnectionString()
        {
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();
            sqlBuilder.DataSource = "DEVELOPER-PC";
            sqlBuilder.InitialCatalog = "MyRestFullApp.Db";
            sqlBuilder.PersistSecurityInfo = true;
            sqlBuilder.IntegratedSecurity = true;
            sqlBuilder.MultipleActiveResultSets = true;

            EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
            entityBuilder.ProviderConnectionString = sqlBuilder.ToString();
            entityBuilder.Metadata = "res://*/";
            entityBuilder.Provider = "System.Data.SqlClient";

            return entityBuilder.ToString();
        }

        public HashSet<User> Users { get; set; }
    }
}