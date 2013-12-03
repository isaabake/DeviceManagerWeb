using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace WCFDeviceManager.Models
{
    //the general tutorials used are:
    //http://codetunnel.com/blog/post/validation-with-entity-framework
    //http://msdn.microsoft.com/en-us/library/ee256141%28v=vs.100%29.aspx

    [MetadataType(typeof(DeviceMetadata))]
    public partial class Device
    {
    }

    public class DeviceMetadata
    {
        public int ID;

        [Required(ErrorMessage = "Device Name must be specified!")]
        [StringLength(128)]
        public string Name { get; set; }
        
        [Editable(false)]
        public int DeviceTypeID { get; set; }
        

        public Nullable<int> ConnectionID { get; set; }
        
        //no restrictions on Description in data_fields spec
        public string Description { get; set; }
        
        [StringLength(64)]
        public string SerialNumber { get; set; }

        [StringLength(64)]
        public string FirmwareRevision { get; set; }

        [StringLength(64)]
        public string PartNumber { get; set; }

        [StringLength(64)]
        public string FIDString { get; set; }
    }
}