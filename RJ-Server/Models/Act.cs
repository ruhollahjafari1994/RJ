using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RJ_Server.Models
{
    public class Act
    {
        [Key]
        public Guid ActId { get; set; } 
        [Required]
        public string ActName { get; set; }

        [Required]
        public string ActPropertise { get; set; }


        public enum ActType {Easy ,Moderate , Difficult ,Expert  }

        public ActType actType { get; set; }

        [ForeignKey("UserId")]
        public UserDetails UserDetails { get; set; }

        [Required]
        public DateTime ActDateCreated { get; set; }

        public DateTime ActDateEnded { get; set; }
    }
}
