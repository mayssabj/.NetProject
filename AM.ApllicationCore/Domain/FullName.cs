using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace AM.ApllicationCore.Domain
{
    [Owned] //pour dire que cette classe est un type detenu (complex)
    public class FullName
    {
        [MaxLength(25, ErrorMessage = "longueur max est 25")]
        [MinLength(3, ErrorMessage = "longueur min est 3")]
        public string? FirstName { get; set; }
        [MaxLength(25, ErrorMessage = "longueur max est 25")]
        [MinLength(3, ErrorMessage = "longueur min est 3")]
        public string? LastName { get; set; }
    }
}
