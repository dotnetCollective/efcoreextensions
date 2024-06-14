using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Extensions.Tests.Models
{
    public class NullSemanticsEntity
    {
        public int Id { get; set; }
        public int Int { get; set; }
        public int? NullableInt { get; set; }
        public string String1 { get; set; } = string.Empty;
        public string String2 { get; set; } = string.Empty;
    }
}
