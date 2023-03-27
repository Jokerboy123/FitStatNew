using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class EnumHelper
    {
		public static string GetCurrentDescription(this Enum value)
        {
			return GetEnumDescription(value);

		} 

		public static string GetEnumDescription(Enum value)
		{
			FieldInfo fi = value.GetType().GetField(value.ToString());

			DescriptionAttribute[] attributes =
				(DescriptionAttribute[])fi.GetCustomAttributes(
				typeof(DescriptionAttribute),
				false);

			if (attributes != null &&
				attributes.Length > 0)
				return attributes[0].Description;
			else
				return value.ToString();
		}
        public static Dictionary<int, string> GetListOfEnumValues<T>()
            where T:Enum
        {
            try
            {
                var FullMarkTypeTypes = Enum.GetValues(typeof(T)).Cast<T>().ToList();
                Dictionary<int, string> DataList = new Dictionary<int, string>();
                foreach (var CurrentType in FullMarkTypeTypes)
                {
                    Enum CurrentEnum = Enum.Parse(typeof(T), CurrentType.ToString()) as Enum;
                    DataList.Add(Convert.ToInt32(CurrentEnum), CurrentType.GetCurrentDescription());
                }
                return DataList;
            }
            catch
            {
             
                return new Dictionary<int, string>();
            }
        }

    }
}
