using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;

namespace Kelasys.ESR.Utils.Extentions {
    public static class Extention {

        public static string GetEnumDescription(this Enum value) {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            if(fieldInfo == null)
                return null;
            var attribute = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return attribute.Description;
        }

    }
}
