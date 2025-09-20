using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourism_2._0.Domain.Entities
{
    public abstract class EntityBase
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Заполнение названия обязательно")]
        [Display(Name ="Название")]
        [MaxLength(200)]
        public string? Title { get; set; }

        public DateTime DataCreated { get; set; } = DateTime.UtcNow;
    }
}
