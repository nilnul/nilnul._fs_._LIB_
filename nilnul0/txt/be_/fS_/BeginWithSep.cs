namespace nilnul.txt.be_.fs_
{
	public class BeginWithSep : nilnul.txt.BeI
	{
		public bool be(string route)
		{
			return route.StartsWith(nilnul.fs._address._route_._SeparatorX.AsTxt) || route.StartsWith(nilnul.fs._address._route_._SeparatorX.AltAsTxt);

			//throw new NotImplementedException();
		}


		static public BeginWithSep Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<EndWithDirSep>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<BeginWithSep>.Instance;
#pragma warning restore CS0618 // 'Singleton1<EndWithDirSep>' is obsolete: 'nilnul.obj_.'
			}
		}

	}
}
