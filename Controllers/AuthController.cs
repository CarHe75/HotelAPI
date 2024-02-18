using HotelAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost(Name = "LoginHotelApp")]
        public SignInModel LoginHotelApp(SignInModel model)
        {
            SignInModel signInModel = new SignInModel();
            if (!string.IsNullOrEmpty(model.UserName) || !string.IsNullOrEmpty(model.Password))
            {
                //Valores no son nulos o no estan vacios

                if (model.UserName == "Administrador" && model.Password == "Admin2024.")
                {
                    //Paso la prueba, el login es valido
                    signInModel.UserName = model.UserName;
                }
                else
                {
                    signInModel.Errors = new List<string> { "El usuario o la contraseña son incorrectos, revise los datos o comuniquese con el administrador." };
                }
            }
            else
            {
                signInModel.Errors = new List<string> { "El usuario y la contraseña son obligatorios." };
            }

            return signInModel;
        }
    }
}
