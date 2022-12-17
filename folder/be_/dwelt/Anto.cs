namespace nilnul.fs.folder.be_.dwelled
{
	public class Anto
		: nilnul.obj.be.Anto<nilnul.fs.FolderI, Dwelled>
		,
		nilnul.fs.folder.BeAI
	{


		static public bool _Be(string folder)
		{
			return Singleton.be(
				 Folder.FroAddress(folder)
			);
		}

		public bool be_ofAddress(string txt)
		{
			return be(nilnul.fs.AddressA.Parse(txt));
		}

		public bool be_ofShield(string txt)
		{
			return be(
				nilnul.fs.address_.Shield.Parse(txt)
			);
		}

		public bool be_ofSpear(string txt)
		{
			return be(
				nilnul.fs.address_.Spear.Parse(txt)
			);

		}

		public bool be(AddressI obj)
		{
			return be(new nilnul.fs.Folder(obj));
		}


#pragma warning disable CS0108 // 'Anto.Singleton' hides inherited member 'Anto<FolderI, Dwelled>.Singleton'. Use the new keyword if hiding was intended.
		static public Anto Singleton
#pragma warning restore CS0108 // 'Anto.Singleton' hides inherited member 'Anto<FolderI, Dwelled>.Singleton'. Use the new keyword if hiding was intended.
		{
			get
			{
				return nilnul.obj_.Singleton<Anto>.Instance;
			}
		}

	}
}
