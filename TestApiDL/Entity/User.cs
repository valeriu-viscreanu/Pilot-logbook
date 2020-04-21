﻿using System.ComponentModel.DataAnnotations;

namespace Logbook.DataLayer
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PIN { get; set; }
    }
}
