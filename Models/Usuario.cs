public class Usuario{
    string Username {get;set;}
    string Contraseña {get;set;}
    string Nombre {get;set;}
    string Apellido {get;set;}
    string Mail {get;set;}

    public Usuario(string username, string contraseña,  string nombre, string apellido, string mail){
        Username = username;
        Contraseña = contraseña;
        Nombre = nombre;
        Apellido = apellido;
        Mail = mail;
    }
}
