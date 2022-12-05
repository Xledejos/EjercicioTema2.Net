﻿using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackendoReplica.Models.DataModels
{
    public class BaseEntity
    {
        [Required, Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime UpdateAt { get; set; } 
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
