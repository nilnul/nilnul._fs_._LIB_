namespace nilnul.fs._address.container.div.convert_.join_
{
	public class _DirX
	{
		static public DivI Eval(DivI arg, DirI arg1)
		{
			return new Div(

				nilnul.objs_.enumerable.convert_._AppendX.Append(arg.dirs, arg1)
			);

			//throw new NotImplementedException();
		}


		static public DivI Eval(DivI arg, DstI arg1)
		{
			return Eval(arg, new Dir(arg1));

			//throw new NotImplementedException();
		}



	}
}
