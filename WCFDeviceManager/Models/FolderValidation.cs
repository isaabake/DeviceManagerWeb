using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WCFDeviceManager.Models
{
    [MetadataType(typeof(FolderMetadata))]
    public partial class Folder
    {
    }

    public class FolderMetadata
    {
        [Required(ErrorMessage = "Folder Name must be specified!")]
        [StringLength(128)]
        public string Name { get; set; }
    }
}