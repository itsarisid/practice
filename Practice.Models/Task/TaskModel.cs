using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice.Models.Task
{
    /// <summary>Task Model</summary>
    public class TaskModel
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Expiry Date")]
        public DateTime? ExpiryDate { get; set; }
        public bool? IsImportant { get; set; }
        public int? UserId { get; set; }
    }
}
