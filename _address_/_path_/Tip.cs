using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs._address_._path_
{
	/// <summary>
	/// the last segment of a path or empty 
	/// </summary>
	/// 


	public class Tip :
	
		
		nilnul.obj.TOpt<_path.Dst>
	{

		

		public Tip( ):base()
		{

		}

		public Tip(_path.Dst child):base(
			child	
		)
		{

		}

		public Tip(string s):this( new _path.Dst(s))
		{

		}

		public static Tip Parse(string v)
		{

			if (v == "")
			{
				return new Tip();

			}
			return new Tip(new _path.Dst(v));

			//throw new NotImplementedException();
		}


	}
}
