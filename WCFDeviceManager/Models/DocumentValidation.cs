using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCFDeviceManager.Models
{
    [MetadataType(typeof(DocumentMetadata))]
    public partial class Document
    {
    }

    public class DocumentMetadata
    {
        [Required(ErrorMessage = "Document must have a name!")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}