using nilnul.obj;

namespace nilnul.fs.address.be.anto_
{
	public class BeDefault<TBe>
		:
		nilnul.fs.address.be.Anto1<TBe>
		where TBe : nilnul.fs.address.BeI, new()
	{
		public BeDefault() : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		

		static public BeDefault<TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<BeDefault<TBe>>.Instance;
			}
		}

		

	}
}
