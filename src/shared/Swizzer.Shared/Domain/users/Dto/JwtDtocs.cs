using Swizzer.Shared.Providers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Swizzer.Shared.Domain.users.Dto
{
    public class JwtDto : IIdProvider
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        public UserDto User { get; set; }
        public DateTime Expires { get; set; }
     
    }
}
