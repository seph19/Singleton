using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ElectricKettle
{
    public static class GetStatus
    {
        public static string GetDescription(Status enumerationValue)
        {
            var type = enumerationValue.GetType();
            var memberInfo = type.GetMember(enumerationValue.ToString());

            var attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

            return ((DescriptionAttribute)attrs[0]).Description;
            
        }
    }
}
