using nilnul.fs._address.route_;
using nilnul.fs.path_.contextual_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.path_.contextual_.rted_.tipped_
{
	public class DntEnded :
		nilnul.obj.Box1<path_.contextual_._route.division_.denotation_.DntAppended>
		,
		contextual_.IRted
	{
		public DntEnded(
			path_.contextual_._route.division_.denotation_.DntAppended val) : base(val)
		{
		}


		public path_.contextual_._route.division_.denotation_.DntAppended division
		{
			get { return boxed; }
			set { boxed = value; }
		}

		//public path_.contextual_.DivisionI division1
		//{
		//	get { return path_.contextual_.DivisionIX.Ov(boxed); }
		//	//set { boxed = value; }
		//}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		/// <exception cref="nameof(route_.xpn_.AboveRtException)">
		/// </exception>
		public nilnul.fs._address.route_.Sprig toSprig()
		{
			try
			{
				return new nilnul.fs._address.route_.Sprig(
					(
						(this.boxed)
					)._toLiteral1()
				);

			}
			catch (InvalidCastException e)
			{

				throw new route_.xpn_.AboveRtException($"{this}, even when shunk and converted to literal sprig, is invalid as the path exceeds negatively above the vol.",e);
			}
		}

		public static DntEnded Of(
			StemI stem
			,
			contextual_._route.division_.denotation_.DntAppended route
		)
		{

			return new DntEnded(
				path_.contextual_._route.division.co_.starT_.div_.enD_.denotation_._EndDntX.DntEnd(
					stem.div
					,
					route
				)
			);

			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{_address._route._SeparatorX.Default}{boxed}";
		}

		static public DntEnded Parse(string txt)
		{
			nilnul.txt.be_.fS_.sepBegin.Vow.Singleton.vow(
				txt
			);

			//nilnul.obj.aver_.True.Aver(txt.StartsWith(nilnul.fs._address.Separator.AsTxt));

			return new DntEnded(
				nilnul.fs.path_.contextual_._route.division_.denotation_.DntAppended.Parse(txt.Substring(1))
			);
		}

		public DntEnded toShrink()
		{
			return new DntEnded(
				this.division.toShrink()
			);
		}

	}
}
