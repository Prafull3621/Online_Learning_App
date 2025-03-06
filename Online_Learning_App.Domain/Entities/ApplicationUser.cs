﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Online_Learning_App.Domain.Entities
{
    public class ApplicationUser: IdentityUser<Guid>
    {

        public Guid? RoleId { get; set; }
    }
}
