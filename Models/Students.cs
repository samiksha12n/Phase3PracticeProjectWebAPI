﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PracticeProjectWebAPI.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Subject1Marks { get; set; }
        public int Subject2Marks { get; set;
        }
    }
}