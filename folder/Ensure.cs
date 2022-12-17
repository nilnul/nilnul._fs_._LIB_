namespace nilnul.fs.folder
{
	public class _EnsureX
	{

		public static void Void(nilnul.fs.address_.ShieldI realDir)
		{
			System.IO.Directory.CreateDirectory(realDir.ToString());
			//throw new NotImplementedException();
		}
		public static void Void_ofAddress(string realDir)
		{
			System.IO.Directory.CreateDirectory(realDir);
			//throw new NotImplementedException();
		}

		public static Folder Folder(nilnul.fs.address_.ShieldI shield)
		{
			Void(shield);
			//System.IO.Directory.CreateDirectory(shield.ToString());

			return new Folder(shield);
			//throw new NotImplementedException();
		}

		public static Folder Folder(nilnul.fs.AddressI shield)
		{
			return Folder(
				nilnul.fs.address_.Shield.FroAddress(shield)
			);
		}


		public static Folder Folder_ofAddress(string shield)
		{
			return Folder(
				nilnul.fs.address_.shield_._AddressX1.Create(shield)
			);
		}

		public static string Shield_ofAddress(string shield)
		{
			return Folder_ofAddress(shield).en.ToString();
		}


	}
}
