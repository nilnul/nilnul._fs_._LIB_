using System;

namespace nilnul.fs._address.div.be_
{
	[Obsolete(nameof(Rt))]
	public class Empty : BeI
	{
		public bool be(DivI obj)
		{
			return nilnul.objs.be_._NoneX.None(obj.dirs);
			//throw new NotImplementedException();
		}



		static public Empty Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Empty>' is obsolete
				return nilnul._obj.Singleton<Empty>.Instance;
#pragma warning restore CS0612 // 'Singleton<Empty>' is obsolete
			}
		}

	}
}
