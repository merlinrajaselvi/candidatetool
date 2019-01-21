using System;
using System.Collections.Generic;
using System.Text;

namespace LSC.Core
{
    public class User : BaseEntity
    {
        public int UserId { get; set; }

        public int Name { get; set; }
    }
}
