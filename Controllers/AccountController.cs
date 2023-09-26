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
    public IActionResult Registrarse(){
        
        return View();
    }
    public IActionResult Login(string username, string contraseña){
        Usuario user = GetUserByUsername(username)
        if (contraseña = user.contraseña)
        {
            
        }
        else
        {
            
        }
        RedirectToAction("Index")
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}