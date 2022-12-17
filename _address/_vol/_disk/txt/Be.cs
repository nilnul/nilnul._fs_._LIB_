namespace nilnul.fs._address._vol_._name.txt
{
	public class Be : nilnul.txt.BeI
	{


		public bool be(string obj)
		{
			return nilnul.txt.be_.Id.Singleton.be(obj);
			//return Regex.IsMatch(obj, @"\A\[A-z]\w*\z",RegexOptions.IgnorePatternWhitespace);
			//throw new NotImplementedException();
		}


		static public Be Singleton
		{
			get
			{
#pragma warning disable CS0618 // 'SingletonByDefault<Be>' is obsolete: 'Singleton'
				return nilnul.obj.SingletonByDefault<Be>.Instance;
#pragma warning restore CS0618 // 'SingletonByDefault<Be>' is obsolete: 'Singleton'
			}
		}

	}
}
