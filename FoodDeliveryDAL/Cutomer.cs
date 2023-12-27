﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryDAL
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [Index("IX_UniqueEmpUserEmail", IsUnique = true)]
        [MaxLength(255)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(255)]
        [Index("IX_UniqueEmpUserName", IsUnique = true)]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        [MaxLength(255)]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }

}
