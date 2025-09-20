using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism_2._0.Models
{
    public class ServiceDTO
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public string? Title { get; set; }
        public string? ShortDesc { get; set; }
        public string? Desc { get; set; }
        public string? PhotoFileName { get; set; }
        public string? Type { get; set; }
    }
}
