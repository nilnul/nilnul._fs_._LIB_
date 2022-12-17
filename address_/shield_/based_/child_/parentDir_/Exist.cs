namespace nilnul.fs.address_.shield_.parentDir_
{
	public class Exist :
		nilnul.fs.address_.shield.be_.exist.vow._en_.Shield<BaseDir>

	{
		public Exist(BaseDir val) : base(val)
		{
		}

		static public implicit operator shield_.Exist(Exist me)
		{
			return new shield_.Exist(me.en);
		}
	}
}
