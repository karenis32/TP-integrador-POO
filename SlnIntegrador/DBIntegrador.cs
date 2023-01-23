using System;
using System.Data.Entity;
public class DBIntegrador: DbContext
{
    public DBIntegrador() : base("KeyDB") { }

}
