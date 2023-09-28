public class Usuario{
    string Username {get;set;}
    string Contrasenia {get;set;}
    string Nombre {get;set;}
    string Apellido {get;set;}
    string Mail {get;set;}

    public Usuario(string username, string contrasenia,  string nombre, string apellido, string mail){
        Username = username;
        Contrasenia = contrasenia;
        Nombre = nombre;
        Apellido = apellido;
        Mail = mail;
    }
}
