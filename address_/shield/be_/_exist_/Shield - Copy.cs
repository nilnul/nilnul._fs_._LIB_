using System;

namespace nilnul.fs.address_.shield.be_._exist_
{
	[Obsolete()]
	public class Shield2<TShield>
		: nilnul.fs.address_.shield._be_.ShieldI<TShield>

		where TShield : nilnul.fs.address_.ShieldI
	{
		public bool be(TShield obj)
		{
			return nilnul.fs.address_.shield.be_.Folder.Singleton.be_ofAddress(obj.ToString());
			//return System.IO.Directory.Exists(obj.ToString());

		}



		static public Shield2<TShield> Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Shield2<TShield>>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Shield2<TShield>>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Shield2<TShield>>' is obsolete: 'nilnul.obj_.'
			}
		}



	}
}
