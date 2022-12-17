using nilnul.fs.address_.shield_.based_;
using System;

namespace nilnul.fs.address_.shield.be_
{
	public class Folder
		:
		nilnul.fs.address_.shield.BeI1
		,
		nilnul.fs.address_.shield.BeI2

	{
		public bool be(ShieldI obj)
		{
			return _FolderX_prefixIfNeed.Be(obj);

			//throw new NotImplementedException();
		}
		public bool be(ShieldI1 obj)
		{
			return _FolderX_prefixIfNeed.Be(obj);

			//throw new NotImplementedException();
		}

		public bool be(nilnul.fs.AddressI obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}

		public bool be(string obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}


		public bool be_ofAddress(string obj)
		{
			return be(nilnul.fs.address_.Shield.Parse(obj));
		}





		static public Folder Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Folder>.Instance;
			}
		}


		
	}
}
