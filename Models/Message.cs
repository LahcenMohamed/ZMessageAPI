using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }
        [ForeignKey("Sender")]
        public int SenderId { get; set; }
        [ForeignKey("Recipient")]
        public int RecipientId { get; set; }
        public User Sender { get; set; }
        public User Recipient { get; set; }

    }
}
