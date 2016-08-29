﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormsApp.ViewModel
{
   public class PhoneNumberViewModel
    {
        public string PhoneNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Неверный формат номера телефона(нужны 10 цифр)")]
        [StringLength(32)]
        public string NewPhoneNumber { get; set; }
    }
}
