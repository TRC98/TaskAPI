﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public DateTime Due { get; set; }
        [Required]
        public TodoStatus Status { get; set; } // Now, Inprogress, Completed
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
