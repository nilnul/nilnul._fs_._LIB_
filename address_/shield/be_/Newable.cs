namespace nilnul.fs.address_.shield.be_
{
	/// <summary>
	/// if it's root, it cannot be created as new.
	/// if it's nonroot, then we check whether the spear is not occumpied by file, nor fold, and if so it can be created
	/// </summary>
	public class Newable
		: nilnul.fs.address_.shield.BeI1
	{
		public bool be(ShieldI obj)
		{
			if (be_.root.Anto.Singleton.be(obj))
			{
				return shield_.nonRt.be_.Newable.Singleton.be(
					new shield_.NonRt(obj)
				);
			}
			return false;   //root folder cannot be created.


		}


		public bool be_ofAddress(string obj)
		{
			return be(nilnul.fs.address_.Shield.FroAddress(obj));
		}



		static public Newable Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Newable>' is obsolete
				return nilnul._obj.Singleton<Newable>.Instance;
#pragma warning restore CS0612 // 'Singleton<Newable>' is obsolete
			}
		}



	}
}
