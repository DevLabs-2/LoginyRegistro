using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string ConnectionString = @"Server=localhost;DataBase=LoginRegistro;Trusted_Connection=True;";

    public static Usuario GetUserByUsername(string username){
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Usuario WHERE Username = @username";
                Usuario = db.QueryFirstOrDefault<Usuario>(sql, new {username = username});
            }
    }

    public static UpdateUsuario(string usernameAnterior, string username, string contraseña, string nombre, string apellido, string mail){
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "UPDATE Usuario SET Username = @username, Contraseña = @contraseña, Nombre = @nombre, Apellido = @apellido, Mail = @mail WHERE Username = @usernameAnterior";
                Usuario = db.QueryFirstOrDefault<Usuario>(sql, new {usernameAnterior = usernameAnterior, username = username, contraseña = contraseña, nombre = nombre, apellido = apellido, mail = mail});
            }
    }


}