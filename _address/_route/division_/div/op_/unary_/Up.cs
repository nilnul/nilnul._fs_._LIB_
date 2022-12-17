namespace nilnul.fs._address.container.div.convert_
{
#pragma warning disable CS0612 // 'ConvertI<DivI>' is obsolete
	public class Up : nilnul.obj.ConvertI<DivI>
#pragma warning restore CS0612 // 'ConvertI<DivI>' is obsolete
	{
		public DivI eval(DivI arg)
		{
			return new Div(
				nilnul.objs_.started.cast_._RemoveLastX.RemoveLast(arg.dirs)
			);

			//throw new NotImplementedException();
		}



		static public Up Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Up>.Instance;
			}
		}

	}
}
