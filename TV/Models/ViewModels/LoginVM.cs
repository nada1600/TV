using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TV.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Fyll i rätt användarnamn.")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Fyll i rätt lösenord.")]

        //För att det ska bli stjärnor när man fyller i lösenordet
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}