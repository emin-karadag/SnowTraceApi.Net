using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace SnowTraceApi.Net.Core.Utilities
{
    public static class Extensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
            if (memberInfo.Length > 0)
            {
                var displayAttribute = memberInfo[0].GetCustomAttribute<DisplayAttribute>();
                if (displayAttribute != null && !string.IsNullOrEmpty(displayAttribute.GetName()))
                {
                    return displayAttribute.GetName() ?? "";
                }
            }
            return enumValue.ToString();
        }

        public static decimal FromWei(this decimal value)
        {
            try
            {
                return value / 1000000000000000000;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public static decimal ToWei(this decimal value)
        {
            try
            {
                return value * 1000000000000000000;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
