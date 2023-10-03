using System.Data.SqlClient;
using Dapper;

public static class BD
{
    private static string ConnectionString = @"Server=localhost;DataBase=LoginRegistro;Trusted_Connection=True;";

    public static Usuario GetUserByUsername(string username){
        Usuario user = null;
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "SELECT * FROM Usuario WHERE username = @username";
                user = db.QueryFirstOrDefault<Usuario>(sql, new {username = username});
            }
            return user;
    }

    public static void UpdateUser(string usernameAnterior, Usuario user){
        using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "UPDATE Usuario SET username = @username, contrasenia = @contrasenia, nombre = @nombre, apellido = @apellido, mail = @mail WHERE username = @usernameAnterior";
                db.Execute(sql, new {usernameAnterior = usernameAnterior, username = user.username, contrasenia = user.contrasenia, nombre = user.nombre, apellido = user.apellido, mail = user.mail});
            }
    }

    public static void CreateUser(Usuario user){
         using (SqlConnection db = new SqlConnection(ConnectionString))
            {
                string sql = "INSERT INTO Usuario (username, contrasenia, nombre, apellido, mail) VALUES (@username, @contrasenia, @nombre, @apellido, @mail)";
                db.Execute(sql, new {username = user.username, contrasenia = user.contrasenia, nombre = user.nombre, apellido = user.apellido, mail = user.mail});
            }
    }


}