using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.shields_
{
	[Obsolete()]
	public class Disjoint : nilnul.fs.address_.shields.be_.disjoint.vow.En
	{
		public Disjoint(ShieldsI val) : base(val)
		{
		}

		public Disjoint(IEnumerable<ShieldI> _disjoint) : this(
			new Shields(_disjoint) as ShieldsI
		)
		{
		}
		public Disjoint() : this(new Shields())
		{
		}

		public nilnul.fs.address_.ShieldI sup(nilnul.fs.address_.ShieldI sub)
		{
			return this.en.FirstOrDefault(
				x => nilnul.fs.address_.shield.re_.Sup.Singleton.re(x, sub)
			);
		}

		

		static public Disjoint Fro(IEnumerable<string> folders)
		{
			return Fro(folders.Select(x => nilnul.fs.address_.Shield.Parse(x)));
		}

		static public Disjoint Fro(ShieldsI folders)
		{
			return Fro(folders as IEnumerable<ShieldI>);
		}

		static public IEnumerable<nilnul.fs.address_.ShieldI> _Fro(IEnumerable<nilnul.fs.address_.ShieldI> _disjoint,
			IEnumerable<
			nilnul.fs.address_.ShieldI> candidates)
		{

			var r = _disjoint;
			foreach (var item in candidates)
			{
				r = _Fro(r, item);
			}
			return r;

		}



		static public IEnumerable<nilnul.fs.address_.ShieldI> _Fro(
			IEnumerable<nilnul.fs.address_.ShieldI> _disjoint
			, 
			nilnul.fs.address_.ShieldI candidate
		)
		{

			var t = _disjoint.Where(x => nilnul.fs.address_.shield.re_.sub.Complement.Singleton.re(x, candidate));

			if (nilnul.obj.seq.be_._NoneX.None(_disjoint, x => nilnul.fs.address_.shield.re_.Sup.Singleton.re(x, candidate)))
			{
				return nilnul.obj.seq.convert_._AppendX.Append(
					t, candidate
				);
			}
			return t;

		}

		static public IEnumerable<nilnul.fs.address_.ShieldI> Enumerable(IEnumerable<nilnul.fs.address_.ShieldI> shields)
		{


			return _Fro(
				new nilnul.fs.address_.ShieldI[0]
				,

				shields

			);

		}


		static public Disjoint Fro(IEnumerable<ShieldI> folders)
		{
			return new Disjoint(
				Enumerable(
					folders
				)
			);
		}
	}
}
