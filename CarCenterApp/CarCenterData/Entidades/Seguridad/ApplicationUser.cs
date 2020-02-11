using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarCenterCore.Entidades.Seguridad
{
    public class ApplicationUser : IdentityUser<Guid>
    {
    }

    public class UserRole : IdentityRole<Guid>
    {
    }
}
