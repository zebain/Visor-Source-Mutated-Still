using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public class json_wrapper
	{
		// Token: 0x0600001C RID: 28 RVA: 0x5FF0A07A File Offset: 0x5FEFEE7A
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x5FF0C214 File Offset: 0x5FF01014
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x5FF0C288 File Offset: 0x5FF01088
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.serializer.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x5FF0A0A6 File Offset: 0x5FEFEEA6
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x0400000E RID: 14
		private DataContractJsonSerializer serializer;

		// Token: 0x0400000F RID: 15
		private object current_object;
	}
}
