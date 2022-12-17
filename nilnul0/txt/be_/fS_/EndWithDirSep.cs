namespace nilnul.txt.be_.fs_
{
	public class EndWithDirSep : nilnul.txt.BeI
	{
		public bool be(string route)
		{
			return route.EndsWith(nilnul.fs._address._route_._SeparatorX.AsTxt) || route.EndsWith(nilnul.fs._address._route_._SeparatorX.AltAsTxt);

			//throw new NotImplementedException();
		}


		static public EndWithDirSep Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'Singleton1<EndWithDirSep>' is obsolete: 'nilnul.obj_.'
				return nilnul.Singleton1<EndWithDirSep>.Instance;
#pragma warning restore CS0618 // 'Singleton1<EndWithDirSep>' is obsolete: 'nilnul.obj_.'
			}
		}

	}
}
