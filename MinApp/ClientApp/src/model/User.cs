using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinApp.ClientApp.src.model
{
    public class User : IEntityBase
    {
        private string id { get; set; }
        private string userName { get; set; }
        private string email { get; set; }
        private string password { get; set; }
    }
}
