using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public  int Id { get; set; }
        public string Description { get; set; }
        [Display(Name = "DueDate")]
        [DataType(DataType.Date)]
        public string  Date { get; set; }
        public bool Done { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}