using nilnul.fs._location_;

namespace nilnul.fs.location
{
	/*extern alias obj;*/
	public interface BeI
		:/*obj::*/nilnul.obj.BeI1<nilnul.fs.LocationI>
	{
	}

	public abstract class BeA : BeI
		,
		nilnul.obj.BeI1<nilnul.fs._location_.BlankI>
	{
		public abstract bool be(BlankI obj);
		public bool be(LocationI obj) { 
  			return be(
				(BlankI)(obj)
			);
  	//		return be(
			//	nilnul.fs.location_.File0FolderA.Parse(obj)
			//);

		}
	}
}
