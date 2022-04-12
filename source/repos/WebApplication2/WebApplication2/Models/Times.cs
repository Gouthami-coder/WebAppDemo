using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    [ComplexType]
    public class Times
    {
        public int val { get; set; }
        public int txt { get; set; }
    }
}