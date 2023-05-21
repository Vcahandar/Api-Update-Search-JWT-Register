using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public class AuthResponse
    {
        public string StatusMessage { get; set; }
        public List<string> Errors { get; set; } = null;
    }
}
