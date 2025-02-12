using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIChatApp.Models
{
    public class Metadata
    {
        public string CreatedBy { get; set; }  // Username or ID of the creator
        public DateTime CreatedDate { get; set; }  // When the conversation was created
        public DateTime ModifiedDate { get; set; }  // Last modified timestamp

        public Metadata()
        {
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
        }

        public void UpdateModifiedDate()
        {
            ModifiedDate = DateTime.UtcNow;
        }
    }

}
