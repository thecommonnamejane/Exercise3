using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Models
{
    // Event ------------------------------------------------------------------
    public class EventMetadata
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }

    [MetadataType(typeof(EventMetadata))]
    public partial class Event { }

}