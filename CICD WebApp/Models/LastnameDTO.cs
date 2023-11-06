using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CICD_WebApp.Models
{
    public class LastnameDTO
    {
        [NotNull]
        public string Lastname { get; set; }
    }
}
