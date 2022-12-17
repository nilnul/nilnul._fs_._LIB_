using System.Collections.Generic;
using System.Linq;

namespace nilnul.fs.address_.shields_
{
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

		public nilnul.fs.address_.ShieldI supOf(nilnul.fs.address_.ShieldI sub)
		{
			return this.ee.FirstOrDefault(
				x => nilnul.fs.address_.shield.re_.Sup.Singleton.re(x, sub)
			);
		}

		public nilnul.fs.address_.ShieldI supOf(nilnul.fs.AddressI sub)
		{
			return this.ee.FirstOrDefault(
				x => nilnul.fs.address.co_.shieldAddress.be_.Sup.Singleton.be(x, sub)
			);
		}

		public nilnul.fs.address_.ShieldI supOf(nilnul.fs.AddressI1 sub)
		{
			return this.ee.FirstOrDefault(
				x => nilnul.fs.address.co_.shieldAddress.be_.Sup.Singleton.be(x, sub)
			);
		}




		public Disjoint(IEnumerable<string> folders) : this(
			folders.Select(x => nilnul.fs.address_.Shield.Parse(x))
		   )
		{

		}


		//[Obsolete(nameof(_Absorb) + "; see Transform of List" )]
		static public IEnumerable<nilnul.fs.address_.ShieldI> _Absorb(
			IEnumerable<nilnul.fs.address_.ShieldI> _disjoint
			,
			IEnumerable<
			nilnul.fs.address_.ShieldI> candidates
		)
		{
			var r = _disjoint.ToList();

			disjoint_._ListX._Absorb(r, candidates); ;
			return r;


			//var r = _disjoint;
			//foreach (var item in candidates)
			//{
			//	r = _Absorb(r, item);
			//}
			//return r;

		}
		public void Add(nilnul.fs.address_.ShieldI shield) {

		}
		static public IEnumerable<nilnul.fs.address_.ShieldI> _Absorb(
			IEnumerable<NotNull2<nilnul.fs.address_.ShieldI>> _disjoint
			,
			IEnumerable<NotNull2<
			nilnul.fs.address_.ShieldI>> candidates
		)
		{
			var r = _disjoint.Select(x => x.val).ToList();

			disjoint_._ListX._Absorb(r, candidates.Select(x => x.val)); ;
			return r;


			//var r = _disjoint;
			//foreach (var item in candidates)
			//{
			//	r = _Absorb(r, item);
			//}
			//return r;

		}

		static public IEnumerable<nilnul.fs.address_.ShieldI> _Absorb_addresses(
			IEnumerable<string> _disjoint,
			IEnumerable<
			string> candidates
		)
		{

			return _Absorb(
				_disjoint.Select(x => nilnul.fs.address_.shield_._AddressX1.Create(x))
				,
				candidates.Select(x => nilnul.fs.address_.shield_._AddressX1.Create(x))
			);

			//var t =
			//	_disjoint.Select(x => nilnul.fs.address_.shield_._AddressX1.Create(x)).ToList();

			//_Absorb(t, 
			//	candidates.Select(y=>nilnul.fs.address_.shield_._AddressX1.Create(y))
			//);


			//return t;




		}



		//[Obsolete()]

		static public IEnumerable<nilnul.fs.address_.ShieldI> _Absorb(
			IEnumerable<nilnul.fs.address_.ShieldI> _disjoint
			,
			nilnul.fs.address_.ShieldI candidate
		)
		{
			var r = _disjoint.ToList();
			disjoint_._ListX._Absorb(r, candidate);
			return r;

			/////all those that are not sub of candidate.
			/////
			//var t = _disjoint.Where(x => nilnul.fs.address_.shield.re_.sub.Complement1.Singleton.re(x, candidate));

			//if (nilnul.obj.seq.be_._NoneX.None(_disjoint, x => nilnul.fs.address_.shield.re_.Sup1.Singleton.re(x, candidate)))
			//{
			//	return nilnul.obj.seq.convert_._AppendX.Append(
			//		t, candidate
			//	);
			//}
			//return t;

		}





		static public IEnumerable<nilnul.fs.address_.ShieldI> ToDisjoin(IEnumerable<nilnul.fs.address_.ShieldI> shields)
		{


			return _Absorb(
				new nilnul.fs.address_.ShieldI[0]
				,

				shields

			);

		}

		static public IEnumerable<nilnul.fs.address_.ShieldI> ToDisjoin(IEnumerable<NotNull2<nilnul.fs.address_.ShieldI>> shields)
		{


			return _Absorb(
				new nilnul.fs.address_.ShieldI[0]
				,

				shields.Select(x => x.val)

			);

		}


		static public Disjoint FroUnsured(IEnumerable<ShieldI> folders)
		{
			return new Disjoint(
				ToDisjoin(
					folders
				)
			);
		}

		static public Disjoint FroUnsured(IEnumerable<NotNull2<ShieldI>> folders)
		{
			return new Disjoint(
				ToDisjoin(
					folders
				)
			);
		}


	}
}
