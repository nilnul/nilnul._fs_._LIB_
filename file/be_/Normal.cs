using nilnul.fs.address_;
using System.IO;

namespace nilnul.fs.file.be_
{
	/// <summary>
	/// </summary>
	public class Normal : nilnul.fs.file.BeI
	{
		public bool be(FileI obj)
		{
			return !nilnul.fs.file.be_.link_.Sym.Singleton.be(obj) && !nilnul.fs.file.be_.link_._ReparseX.Be(obj);

			//throw new NotImplementedException();
		}

		public bool be(FileInfo x)
		{
			return be((nilnul.fs.address_.Spear)x);
			//throw new NotImplementedException();
		}

		private bool be(SpearI x)
		{
			return be(new nilnul.fs.File(x));
			//throw new NotImplementedException();
		}

		public bool be(string address)
		{
			return be(new nilnul.fs.File(address));
		}


		static public Normal Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Normal>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Normal>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Normal>' is obsolete: 'nilnul.obj_.'
			}
		}

	}

}
