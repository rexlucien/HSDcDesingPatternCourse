using System;
using System.ComponentModel.DataAnnotations;

namespace hsdc.dpt.Control.DTO.Creational.Builder
{
    public class OverTime
    {
        public string OverTimeId { get; set; }

        [Required]
        public string Applier { get; set; }

        [Required]
        public DateTime ApplyDateTime { get; set; }

        public int OverTimeHour { get; set; } = 1;
    }
}