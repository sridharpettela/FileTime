using FileTime.IDAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace FileTime.DapperDAL.Test
{
	[TestClass]
	public class FilerDALTest
	{
		private readonly IFilerDAL _filerDal;

		public FilerDALTest()
		{
			_filerDal = new FilerDAL();
		}

		[TestMethod]
		public async Task GetAndUpdateFiler()
		{
			var result = await _filerDal.GetAndUpdateFiler("", "", "");
		}
	}
}
