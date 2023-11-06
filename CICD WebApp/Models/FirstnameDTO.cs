using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CICD_WebApp.Models
{
    public class FirstnameDTO
    {
        [NotNull]
        public string Firstname { get; set; }
    }
}

