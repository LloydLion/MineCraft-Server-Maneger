using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MineCraft_Server_Maneger.Remote
{
	class RequestHandler
	{
		private static readonly MethodInfo[] availableMethods = typeof(HostClientInteractor).GetMethods().Where((s) => s.GetCustomAttribute(typeof(RemoteInteractAttribute)) != null).ToArray();
		private static readonly PropertyInfo[] availableProperties = typeof(HostClientInteractor).GetProperties().Where((s) => s.GetCustomAttribute(typeof(RemoteInteractAttribute)) != null).ToArray();

		private HostClientInteractor interactor;

		public RequestHandler(HostClientInteractor interactor)
		{
			this.interactor = interactor;
		}


		[RemoteInteract]
		public Responce GetProperty(string[] args)
		{
			try 
			{
				var property = availableProperties.Where((s) => s.Name == args[0]);

				if(property.Count() == 0) return Responce.Create(ResponceCode.InvalidMemberName, "\u4321");

				var value = property.First().GetValue(interactor);

				return Responce.Create(ResponceCode.OK, JsonConvert.SerializeObject(value));
			}
			catch(Exception ex)
			{
				return Responce.Create(ResponceCode.UnknownError, JsonConvert.SerializeObject(ex));
			}
		}


		[RemoteInteract]
		public Responce Invoke(string[] args)
		{
			try
			{
				var methodName = args[args.Length - 1];
				var methods = availableMethods.Where((s) => s.Name == methodName);
				var inArgs = new string[args.Length - 1];

				if (methods.Count() == 0) return Responce.Create(ResponceCode.InvalidMemberName, "\u4321");

				if (args.Length != 1)
					Array.Copy(args, inArgs, args.Length - 1);
				else
					args = new string[0];

				var input = inArgs.Select((s) =>
				{
					var model = JsonConvert.DeserializeObject<RemoteMethodArgumentContainer.RemoteMethodArgumentContainerJSONModel>(s);
					return JsonConvert.DeserializeObject(model.Value, Type.GetType(model.TypeLocation));
				}).ToArray();

				var method = methods.First();

				var result = method.Invoke(interactor, input);

				if (method.ReturnType == typeof(void)) return Responce.Create(ResponceCode.OK, "\u4321");
				else return Responce.Create(ResponceCode.OK, JsonConvert.SerializeObject(result));
			}
			catch(Exception ex)
			{
				return Responce.Create(ResponceCode.UnknownError, JsonConvert.SerializeObject(ex));
			}
		}
	}
}
