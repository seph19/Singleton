using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ElectricKettle
{
    public enum Status
    {
        //public string status { get; set; }
        [Description("Empty")]
        Empty = 1,
        [Description("InProgress")]
        Inprogress = 2,
        [Description("Boiled")]
        Boiled = 3
    }
}
