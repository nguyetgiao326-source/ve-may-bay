using MySql.Data.MySqlClient;

namespace VeMayBay.DAO;

public class MyConnection
{
    private static readonly string ConnString =
        "Server=localhost;Port=3306;Database=VeMayBay;Uid=root;Pwd=;CharSet=utf8mb4";

    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(ConnString);
    }
}
