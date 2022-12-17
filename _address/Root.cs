namespace nilnul.fs._address
{
	/// <summary>
	/// origin + "/"
	/// </summary>
	public class Root : RootI
	{
		private nilnul.fs._address.Vol _vol;
		public const char _charEnd = '\\';

		public nilnul.fs._address.Vol vol
		{
			get { return _vol; }
			set { _vol = value; }
		}

		public Root(nilnul.fs._address.Vol vol)
		{
			_vol = vol;
		}

		public override string ToString()
		{
			return _vol.ToString() + "\\";
		}
		static public Root Parse_trimmed(string s)
		{
#pragma warning disable CS0612 // 'AssertX' is obsolete
			nilnul.obj.AssertX.True(s.EndsWith(_charEnd.ToString()));
#pragma warning restore CS0612 // 'AssertX' is obsolete

			return new Root(
				nilnul.fs._address.Vol.Parse_fromTrimmed(s.Substring(0, s.Length - 1))
			);
		}

	}
}
