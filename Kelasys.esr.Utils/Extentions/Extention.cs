using System;
using System.ComponentModel;
using System.Reflection;

namespace Kelasys.esr.Utils.Extentions {
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
