namespace nilnul.fs._address.container.div.convert_
{


#pragma warning disable CS0612 // 'ConvertI<DivI>' is obsolete
	public class UpN : nilnul.obj.ConvertI<DivI>
#pragma warning restore CS0612 // 'ConvertI<DivI>' is obsolete
	{

		static public DivI _Eval(DivI arg, uint n)
		{
			return new Div(

				nilnul.objs_.started.cast_._RemoveLastNX.RemoveLastN(arg.dirs, n)
			);
		}

		private uint _n;

		public uint n
		{
			get { return _n; }
			set { _n = value; }
		}

		public UpN(uint n)
		{
			_n = n;
		}
		public DivI eval(DivI arg)
		{
			return new Div(

				nilnul.objs_.started.cast_._RemoveLastNX.RemoveLastN(arg.dirs, _n)
			);

			//throw new NotImplementedException();
		}





	}
}
