using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginyRegistro.Models;

namespace LoginyRegistro.Controllers;

public class AccountController : Controller{
    
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }
  
    [HttpPost] public IActionResult Registro(string username, string contrasenia, string nombre, string apellido, string mail){
        Usuario user = new Usuario(username,contrasenia,nombre,apellido,mail);
        BD.CreateUser(user);
        return RedirectToAction("Login");
    }

    [HttpPost] public IActionResult VerifLogin(string username, string contrasenia){
        Usuario user = BD.GetUserByUsername(username);
        if (user == null)
        {
            return RedirectToAction("Login", "Home",new {retry = true});
        }
        else
        {
            if(user.contrasenia == contrasenia) return RedirectToAction("Home","Home");
            else return RedirectToAction("Login", "Home",new {retry = true});
        }
        
    }
    [HttpPost] public IActionResult Recordado(string username, string mail){
        Usuario user = BD.GetUserByUsername(username);
        if(user == null){
            return RedirectToAction("Olvido", "Home", new {retry = true});
        }
        else{
            if(user.mail == mail){
            return RedirectToAction("Recordado","Home", new {contrasenia = user.contrasenia});
        }
        else {return RedirectToAction("Olvido", "Home", new {retry = true});}
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}