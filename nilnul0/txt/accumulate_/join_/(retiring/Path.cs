using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;

namespace nilnul.txts.accumulate_.join_
{
	[Obsolete()]
	public class Path : nilnul.txts.accumulate_.Join
	{
		public Path() : base(System.IO.Path.DirectorySeparatorChar)
		{
		}

		static public readonly Path Singleton = nilnul.obj.SingletonByDefault<Path>.Instance;

		public string accumulate(Started _dsts)
		{

			return accumulate(_dsts.Select(x=>x.ToString()));
			//throw new NotImplementedException();
		}

		public string accumulate(params string[] v1)
		{
			return accumulate(v1 as IEnumerable<string>);

			throw new NotImplementedException();
		}

		public string accumulate(fs._address.Dsts dsts)
		{
			return accumulate(dsts.Select(x=>x.ToString()));
			throw new NotImplementedException();
		}

		public string accumulate(fs._address_._path. DstsI1 _dsts)
		{
			return accumulate(_dsts.Select(x=>x.ToString()));
			throw new NotImplementedException();
		}
	}
}
