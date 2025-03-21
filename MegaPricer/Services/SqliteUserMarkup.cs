using System.Data;
using MegaPricer.Data;
using Microsoft.Data.Sqlite;

namespace MegaPricer.Services;

public class SqliteUserMarkup : IUserMarkup
{
  public decimal GetUserMarkup(string userName)
  {
    decimal userMarkup = 0;
    using (var conn = new SqliteConnection(ConfigurationSettings.ConnectionString))
    {
      var cmd = conn.CreateCommand();
      cmd.CommandText = "SELECT * FROM UserMarkups WHERE UserName = @userName";
      cmd.Parameters.AddWithValue("@userName", userName);
      conn.Open();
      using (SqliteDataReader dr = cmd.ExecuteReader())
      {
        if (dr.HasRows && dr.Read())
        {
          userMarkup = dr.GetDecimal("MarkupPercent");
        }
      }
    }
    return userMarkup;
  }
}
