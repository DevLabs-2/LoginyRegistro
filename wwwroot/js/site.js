function VerifPass() {
  const password = document.getElementById('contrasenia')
  const ochoCaracteres = password.length >= 8;
  const caracterEspecial = /[!@#$&*]/.test(password);
  const mayuscula = /[A-Z]/.test(password);
  return ochoCaracteres && caracterEspecial && mayuscula;
}
