﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormsApp.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле \"UserName\" должно быть установлено")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Поле \"Пароль\" должно быть заполнено")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
