// Class Fixtures
using System;
using Xunit;

namespace Fixtures.Examples.Tests.csproj;

public class DatabaseFixture : IDisposable
{
    public DatabaseFixture()
    {
        Db = new SqlConnection("MyConnectionString");

        // ... initialize data in the test database ...
    }

    public void Dispose()
    {
        // ... clean up test data from the database ...
    }

    public SqlConnection Db { get; private set; }
}

public class SqlConnection
{
    public string v;

    public SqlConnection(string v)
    {
        this.v = v;
    }
}

public class MyDatabaseTests : IClassFixture<DatabaseFixture>
{
    DatabaseFixture fixture;

    public MyDatabaseTests(DatabaseFixture fixture)
    {
        this.fixture = fixture;
    }

    [Fact]
    public void Fixture_Dummy_Test()
    {
        string myConnectionString = fixture.Db.v;
        Assert.Equal("MyConnectionString", myConnectionString);
        // more test logic
    }

    // ... write tests, using fixture.Db to get access to the SQL Server ...
}