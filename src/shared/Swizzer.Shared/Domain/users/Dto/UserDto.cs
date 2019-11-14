using Swizzer.Shared.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Shared.Domain.users.Dto
{
    public class UserDto : 
        IIdProvider,
        ICreatedAtProvider
    {

        public Guid Id { get; set; }
        public DateTime CreateAt { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

    }
}
