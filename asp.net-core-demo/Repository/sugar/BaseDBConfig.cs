using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.sugar
{
    public class BaseDBConfig
    {
        public static string ConnectionString = "User ID=root; Password=root; Host=localhost; Port=5432; Database=testdb; Pooling=true; Min Pool Size=0; Max Pool Size=100; Connection Lifetime=0"; 
    }
}
