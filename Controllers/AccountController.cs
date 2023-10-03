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
   
    public IActionResult Registro(string username, string contrasenia, string nombre, string apellido, string mail){
        Usuario user = new Usuario(username,contrasenia,nombre,apellido,mail);
        BD.CreateUser(user);
        return RedirectToAction("Login");
    }

    public IActionResult VerifLogin(string username, string contrasenia){
        Usuario user = BD.GetUserByUsername(username);
        if (contrasenia == user.contrasenia)
        {
            return RedirectToAction("Home");
        }
        else
        {
            return RedirectToAction("Login", new {retry = true});
        }
        
    }
    public IActionResult Recordado(string username, string mail){
        Usuario user = BD.GetUserByUsername(username);
        if(user.mail == mail){
            ViewBag.contrasenia = user.contrasenia;
            return View();
        }
        else
        {
            return RedirectToAction("Olvido", new {retry = true});
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}