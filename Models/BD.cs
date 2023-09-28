using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string ConnectionString = @"Server=localhost;DataBase=LoginRegistro;Trusted_Connection=True;";

    public static Usuario GetUserByUsername(string username){
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Usuario WHERE Username = @username";
                return db.QueryFirstOrDefault<Usuario>(sql, new {username = username});
            }
    }

    public static void UpdateUser(string usernameAnterior, Usuario user){
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "UPDATE Usuario SET Username = @username, Contrasenia = @contrasenia, Nombre = @nombre, Apellido = @apellido, Mail = @mail WHERE Username = @usernameAnterior";
                db.Execute(sql, new {usernameAnterior = usernameAnterior, username = user.username, contrasenia = user.contrasenia, nombre = user.nombre, apellido = user.apellido, mail = user.mail});
            }
    }

    public static void CreateUser(Usuario user){
         using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "INSERT INTO Usuarios (Username, Contrasenia, Nombre, Apellido, Mail) VALUES (@username, @contrasenia, @nombre, @apellido, @mail)";
                db.Execute(sql, new {username = user.username, contrasenia = user.contrasenia, nombre = user.nombre, apellido = user.apellido, mail = user.mail});
            }
    }


}