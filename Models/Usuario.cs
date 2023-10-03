public class Usuario{
    public string username {get;set;}
    public string contrasenia {get;set;}
    public string nombre {get;set;}
    public string apellido {get;set;}
    public string mail {get;set;}

    public Usuario(string username, string contrasenia,  string nombre, string apellido, string mail){
        username = username;
        contrasenia = contrasenia;
        nombre = nombre;
        apellido = apellido;
        mail = mail;
    }
}
