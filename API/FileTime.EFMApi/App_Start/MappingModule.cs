using FileTime.EFMApi.Wrappers;
using FileTime.EFMApi.Wrappers.Interface;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileTime.EFMApi.App_Start
{
	public class MappingModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IUserServiceWrapper>().To<UserServiceWrapper>();
		}
	}
}