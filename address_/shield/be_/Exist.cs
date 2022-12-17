namespace nilnul.fs.address_.shield.be_
{
	public class Exist<TShield>
		: nilnul.fs.address_.shield.BeI<TShield>

		where TShield : nilnul.fs.address_.ShieldI1
	{
		public bool be(TShield obj)
		{
			return nilnul.fs.address_.shield.be_.Folder.Singleton.be_ofAddress(obj.ToString());
			//return System.IO.Directory.Exists(obj.ToString());

		}



		static public Exist<TShield> Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<Shield2<TShield>>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<Exist<TShield>>.Instance;
#pragma warning restore CS0618 // 'Singleton1<Shield2<TShield>>' is obsolete: 'nilnul.obj_.'
			}
		}



	}
}
