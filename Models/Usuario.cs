public class Usuario{
    public string username {get;set;}
    public string contrasenia {get;set;}
    public string nombre {get;set;}
    public string apellido {get;set;}
    public string mail {get;set;}

    public Usuario(string user, string contra, string nom, string ape, string ma){
        username = user;
        contrasenia = contra;
        nombre = nom;
        apellido = ape;
        mail = ma;
    }
    public Usuario(){
        
    }
}
