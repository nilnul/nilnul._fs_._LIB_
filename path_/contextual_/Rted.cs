using nilnul.fs._address.route_;
using nilnul.fs.path_.contextual_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.contextual_
{
	public class Rted :
		nilnul.obj.Box1<path_.contextual_.IDivision>
		,
		contextual_.IRted
	{
		public Rted(IDivision val) : base(val)
		{
		}


		public path_.contextual_.IDivision division
		{
			get { return boxed; }
			set { boxed = value; }
		}

		public path_.contextual_.DivisionI division1
		{
			get { return path_.contextual_.DivisionIX.Ov(boxed); }
			//set { boxed = value; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="nameof(route_.xpn_.AboveRtException)">
		/// </exception>
		public nilnul.fs._address.RouteI toRoute()
		{
			try
			{
				return nilnul.fs._address.RouteA.Ov(
					(
						(DivisionI)DivisionIX.Ov(this.boxed)
					).toLiteral()
				);

			}
			catch (InvalidCastException e)
			{

				throw new route_.xpn_.AboveRtException($"{this}, even when shunk and converted to literal route, is invalid as the path exceeds negatively above the vol.",e);
			}
		}

		public static Rted Ov(StemI stem, DivisionI route)
		{

			return new Rted(
				path_.division.co_._DivDivisionX.Division(
					stem.div
					,
					route
				)
			);

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{_address._route._SeparatorX.Default}{boxed}";
		}

		static public Rted Parse(string txt)
		{
			nilnul.txt.be_.fS_.sepBegin.Vow.Singleton.vow(
				txt
			);

			//nilnul.obj.aver_.True.Aver(txt.StartsWith(nilnul.fs._address.Separator.AsTxt));

			return new Rted(
				nilnul.fs.path_.division._ParseX.Parse(txt.Substring(1))
			);
		}

		public Rted toShrink()
		{
			return new Rted(
				this.division1.ToShrink()
			);
		}

	}
}
