using nilnul.fs._address;
using nilnul.fs._address._dst;
using nilnul.fs._address.doc_._exted;
using nilnul.fs._address.route_;
using System;
using System.IO;
using System.Linq;

namespace nilnul.fs.address_.shield_.based_
{
	public class Child : ShieldI1
	{
		private ShieldI1 _parent;

		public ShieldI1 parent
		{
			get { return _parent; }
			set { _parent = value; }
		}

		private nilnul.fs._address._route.division_._div.DirI _child;

		public nilnul.fs._address._route.division_._div.DirI child
		{
			get { return _child; }
			set { _child = value; }
		}


		public VolI vol => _parent.vol;

		public RouteI1 route => stem;
		public StemI1 stem => new nilnul.fs._address.route_.stem_.ParentDir1(

				_parent.stem
				,
				_child

		);
		public static Child Create_dirDenote(DirectoryInfo tmpSub, string v)
		{
			return new Child(tmpSub, nilnul.fs._address._route.division_._div.Dir.OfDnt(v));
			//throw new NotImplementedException();
		}

		public Child(ShieldI1 container, nilnul.fs._address._route.division_._div.DirI div)
		{
			_parent = container;
			_child = div;
		}
		public Child(ShieldI1 parent, nilnul.fs._address._route.division_._div._dir.Dnt newName)
			:
			this(
				parent, new nilnul.fs._address._route.division_._div.Dir(newName)
		)
		{

		}
		public Child(ShieldI1 shield, nilnul.fs._address._route.division_._div.Dir name) : this(shield, (nilnul.fs._address._route.division_._div.DirI)name)
		{

		}


		public Child(ShieldI1 shield, _address._route.division_._div._dir.DntI doc) : this(
			shield, new nilnul.fs._address._route.division_._div.Dir(doc)
		)
		{

		}

		public Child(DirectoryInfo tmpSub, nilnul.fs._address._route.division_._div.Dir dir2) : this((nilnul.fs.address_.Shield1)tmpSub, dir2)
		{

		}
		

		public Child(AddressI1 shield, _address._route.division_._div._dir.Dnt name):this(nilnul.fs.address_.shield.op_.of_._AddressX.Create(shield),name)
		{
		}

		public Child(AddressI1 shield, nilnul.fs._address._route.division_._div.DirI name):this( nilnul.fs.address_.shield.op_.of_._AddressX.Create(shield),name)
		{
		}


		public static Child Create_dirDenote(ShieldI1 shield, string name)
		{
			return new Child(shield, nilnul.fs._address._route.division_._div.Dir.OfDnt(name));
			//throw new NotImplementedException();
		}

		public static Child Create_dirOfDenote(AddressI1 shield, string name)
		{
			return new Child(
				shield
				,
				(nilnul.fs._address._route.division_._div.DirI)nilnul.fs._address._route.division_._div.Dir.OfDnt(name)
			);
			//throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{_parent}{_child}";
		}


		public static Child Create_ofDirInDst(ShieldI1 sourceParent, string sourceDir)
		{
			return new Child( sourceParent, nilnul.fs._address._route.division_._div.Dir.OfDst(sourceDir));
		}

		//internal static Child Of_dirOfDenote(ShieldI1 parent, Main dnt)
		//{
		//	throw new NotImplementedException();
		//}


		public static Child Create__parentAddress_dirName(string tmpSub, string v)
		{
			return new Child(
				nilnul.fs.address_.shield.op_.of_._AddressX.Create(tmpSub)
				,
				 nilnul.fs._address._route.division_._div.Dir.OfDnt(v)
			);
			//throw new NotImplementedException();
		}



		static public Child OfContainerAddress_DirDst(string containerAddress, string dst)
		{
			return new Child(
				 nilnul.fs.address_.Shield1.FroAddress(containerAddress)
				 ,
				 nilnul.fs._address._route.division_._div.Dir.OfDst(dst)
			);
		}

		static public Child OfContainerAddress(string containerAddress, nilnul.fs._address._route.division_._div.DirI dst)
		{
			return new Child(
				 nilnul.fs.address_.Shield1.FroAddress(containerAddress)
				 ,
				 (dst)
			);
		}


		static public Child _Of(ShieldI1 shield)
		{
			var stem = shield.stem;

			return new Child(
				 new Shield1(shield.vol, stem.div.Take(stem.div.Count() - 1))
				 ,
				 stem.div.Last()
			);
		}
		



		static public Child OfAddress(string shield)
		{

#pragma warning disable CS0618 // 'BaseDir._Fro(ShieldI)' is obsolete: '_Ov'
			return _Of(nilnul.fs.address_.shield.op_.of_._AddressX.Create(shield));
#pragma warning restore CS0618 // 'BaseDir._Fro(ShieldI)' is obsolete: '_Ov'
		}



	}
}
