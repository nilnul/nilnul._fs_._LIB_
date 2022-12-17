namespace nilnul.fs._address.route.be_
{
	/// <summary>
	/// end is not separator
	/// </summary>
	public class Open : BeI
	{
		public bool be(RouteI obj)
		{
			return division.be_.Document.Singleton.be(obj.division);
			//throw new NotImplementedException();
		}

		static public Open Singleton
		{
			get
			{
#pragma warning disable CS0612 // 'Singleton<Open>' is obsolete
				return nilnul._obj.Singleton<Open>.Instance;
#pragma warning restore CS0612 // 'Singleton<Open>' is obsolete
			}
		}

	}
}
