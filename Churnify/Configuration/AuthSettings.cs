using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Churnify.Web.Api.Configuration
{
    public class AuthSettings
    {
        public string SecretKey { get; set; }

        public string EncryptionKey { get; set; }

        public string GuestUserPassword { get; set; }
    }
}
