using System;

namespace nilnul.fs.address_.shield.be_
{
	[Obsolete(nameof(folder.Anto))]
	public class NotFolder
		: nilnul.fs.address_.shield.BeI1
	{
		public bool be(ShieldI obj)
		{
			return !nilnul.fs.address_.shield.be_.Folder.Singleton.be(obj);

			//throw new NotImplementedException();
		}
		public bool be(string obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}


		public bool be_ofAddress(string obj)
		{
			return be(nilnul.fs.address_.Shield.Parse(obj));
		}


		static public NotFolder Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<NotFolder>' is obsolete
				return nilnul._obj.Singleton<NotFolder>.Instance;
#pragma warning restore CS0612 // 'Singleton<NotFolder>' is obsolete
			}
		}



	}
}
