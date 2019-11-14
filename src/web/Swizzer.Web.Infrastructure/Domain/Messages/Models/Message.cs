using Swizzer.Shared.Providers;
using Swizzer.Web.Infrastructure.Domain.Users.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Web.Infrastructure.Domain.Messages.Models
{
   public class Message : IIdProvider, ICreatedAtProvider
    {
        public DateTime CreateAt { get; set ; }
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public Guid SenderId {get; set;}
        public Guid ReceiverId {get; set;}
        public User Sender {get; set;}
        public User Receiver { get; set;}





    }
}
