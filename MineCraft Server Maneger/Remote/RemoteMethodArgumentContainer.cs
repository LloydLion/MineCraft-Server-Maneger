using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class RemoteMethodArgumentContainer
	{
		public object Value { get; }
		public Type TypeInfo { get; }


		public RemoteMethodArgumentContainer(object value)
		{
			Value = value;
			TypeInfo = value.GetType();
		}

		
		public RemoteMethodArgumentContainerJSONModel ToJSONModel()
		{
			return new RemoteMethodArgumentContainerJSONModel(this);
		}


		public class RemoteMethodArgumentContainerJSONModel
		{
			public string Value { get; set; }
			public string TypeLocation { get; set; }

			public RemoteMethodArgumentContainerJSONModel(RemoteMethodArgumentContainer container)
			{
				TypeLocation = container.TypeInfo.FullName;
				Value = JsonConvert.SerializeObject(container.Value);
			}

			public RemoteMethodArgumentContainerJSONModel()
			{

			}
		}
	}
}
