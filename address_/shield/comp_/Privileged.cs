using nilnul.fs.address_.shields.be_.disjoint.vow;
using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shield.comp_
{
	public class Privileged
		:
		nilnul.obj.Box<nilnul.fs.address_.shields.be_.disjoint.vow.En>
		,
		shield.CompI
		,
		nilnul.txt.CompI

	{
		public Privileged(En val) : base(val)
		{
		}

		public Privileged(IEnumerable<ShieldI> containers) : this(new En(containers))
		{

		}

		public Privileged(params string[] addresses) : this(
			addresses.Select(x => Shield.FroAddress(x) as ShieldI)
		)
		{

		}

		public int Compare(ShieldI x, ShieldI y)
		{
			if (
				nilnul.fs.address_.shields._CoverX.Cover(
					this.boxed.ee
					, x
				)
			)
			{
				if (
					nilnul.fs.address_.shields._CoverX.Cover(
						this.boxed.ee
						,
						y
					)

				)
				{

					return nilnul.obj.str._IndexOfX.IndexOf<ShieldI, nilnul.fs.address_.shield.Eq>(
						this.boxed.ee, x
					).CompareTo(
						nilnul.obj.str._IndexOfX.IndexOf<ShieldI, nilnul.fs.address_.shield.Eq>(
							this.boxed.ee, y
						)
					);

				}

				return -1;



			}

			if (
				nilnul.fs.address_.shields._CoverX.Cover(
					this.boxed.ee
					,
					y
				)

			)
			{

				return 1;

			}

			return nilnul.fs.address_.shield.Comp.Singleton.Compare(x, y);
		}

		public int Compare(string x, string y)
		{

			if (string.IsNullOrWhiteSpace(x))
			{
				if (string.IsNullOrWhiteSpace(y))
				{
					return 0;
				}
				return -1;

			}
			if (string.IsNullOrWhiteSpace(y))
			{
				return 1;
			}
			return Compare(
				nilnul.fs.address_.Shield.FroAddress(x)
				,
				nilnul.fs.address_.Shield.FroAddress(y)
			);
		}
	}
}
