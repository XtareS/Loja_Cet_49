using System;
using System.ComponentModel.DataAnnotations;


namespace Loja_Cet_49.Dados.Entidades
{
    public class User
    {

        public int Id { get; set; }


        [Display(Name = "User name")]
        public string User_Name { get; set; }


        [Display(Name = "Name")]
        public string Name { get; set; }


        [Display(Name = "Surname")]
        public string SurName { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "BirthDay")]
        public DateTime Birth { get; set; }






    }
}
