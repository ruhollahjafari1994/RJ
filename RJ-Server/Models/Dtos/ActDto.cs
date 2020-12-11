using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using static RJ_Server.Models.Act;

namespace RJ_Server.Models.Dtos
{
    public class ActDto
    {
        [Key]
        public Guid ActId { get; set; }
        [Required]
        public string ActName { get; set; }

        [Required]
        public string ActPropertise { get; set; }


 
        public ActType actType { get; set; }

        [ForeignKey("UserId")]
        public UserDetailsDto UserDetails { get; set; }
        
        [Required]
        public DateTime ActDateCreated { get; set; }

        public DateTime ActDateEnded{ get; set; }

    }
}
