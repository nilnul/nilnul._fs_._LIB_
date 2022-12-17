using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.file._address_.doc_._dotted_._ext.txt.be_
{
	public class Valid :
		nilnul.txt.be_.Exclude
	//	nilnul.txt.BeI
	{

		public Valid() : base(
			
			System.IO.Path.GetInvalidPathChars().Concat(new[] { '.' })
		)
		{

		}


		static public readonly Valid Singleton = nilnul.obj.SingletonByDefault<Valid>.Instance;

	}
}
