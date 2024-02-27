using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Posto.Identidade.API.Models
{
    public class RoleModel : IdentityRole
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public Guid EmpresaId { get; set; }
    }
}
