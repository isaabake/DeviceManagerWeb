using System;
using System.ComponentModel.DataAnnotations;

namespace WCFDeviceManager.Models
{
    [MetadataType(typeof(ConnectionMetadata))]
    public partial class Connection
    {
    }

    public class ConnectionMetadata
    {
        [Range(0,1, ErrorMessage = "XON/XOFF can only be 0 or 1!")]
        public Nullable<int> XonXoff { get; set; }

        [Range(7, 8, ErrorMessage = "Data Bits can only be 7 or 8!")]
        public Nullable<int> DataBits { get; set; }

        [Range(1, 2, ErrorMessage = "Stop Bits can only be 0 or 1!")]
        public Nullable<int> StopBits { get; set; }
    }
}