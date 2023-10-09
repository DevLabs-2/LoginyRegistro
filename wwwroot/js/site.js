function VerifPass() {
  const password = document.getElementById('contrasenia')
  const ochoCaracteres = password.length >= 8;
  const caracterEspecial = /[!@#$&*]/.test(password);
  const mayuscula = /[A-Z]/.test(password);
  if (ochoCaracteres && caracterEspecial && mayuscula){return true;}
  else {
    alert("La contraseña debe tener 8 caracteres o más, uno especial y una mayúscula");
    return false;
    }
}
