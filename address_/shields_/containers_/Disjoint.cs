using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.address_.containers_
{
	[Obsolete()]
	public class Disjoint :
		nilnul.fs.address_.containers.be_.disjoint.vow.En
		,
		nilnul.fs.address_.ContainersI
	{

		public Disjoint(ContainersI val) : base(val)
		{
		}

		public Disjoint(IEnumerable<ContainerI1> _disjoint):this(
			new Containers(_disjoint) as ContainersI
		)
		{
		}
		public Disjoint():this(new Containers())
		{

		}


		public ContainerI1[] toArr()
		{
			return en.ToArray();
			//throw new NotImplementedException();
		}

		static public Disjoint Fro(IEnumerable<ContainerI1> folders) {
			//if (nilnul.obj.seq.be_._NoneX.None( folders ))
			//{
			//	return new Disjoint( );
			//}

			


			return new Disjoint( 


				_Fro(
					folders
				)
			);
			
		}

		static public Disjoint Fro(IEnumerable<string> folders) {
			return Fro(folders.Select(x=>  nilnul.fs.address_.Container1.Parse(x)));
			
		}


		static public Disjoint Fro(ContainersI folders) {
			return Fro(folders as IEnumerable<ContainerI1>);
		}




		//static public void Absorb(List<nilnul.fs.FolderI1> _disjoint, nilnul.fs.FolderI1 candidate) {

		//	var t=_disjoint.RemoveAll( x => nilnul.fs.folder.re_.Sub.Singleton.re(x, candidate ));

		//	if (nilnul.obj.seq.be_._NoneX.None( _disjoint, x=> nilnul.fs.folder.re_.Sup.Singleton.re(x,candidate) ) )
		//	{
		//		_disjoint.Add(candidate);
		//	}

		//}

		static public IEnumerable<nilnul.fs.address_.ContainerI1> _Fro(IEnumerable<nilnul.fs.address_.ContainerI1> _disjoint, 
			IEnumerable<
			nilnul.fs.address_.ContainerI1> candidates) {

			var r = _disjoint;
			foreach (var item in candidates)
			{
				r = _Fro(r, item);
			}
			return r;

		}



		static public IEnumerable<nilnul.fs.address_.ContainerI1> _Fro(IEnumerable<nilnul.fs.address_.ContainerI1> _disjoint, nilnul.fs.address_.ContainerI1 candidate) {

			var t=_disjoint.Where( x => nilnul.fs.address_.container.re_.sub.Complement.Singleton.re(x, candidate ));

			if (nilnul.obj.seq.be_._NoneX.None( _disjoint, x=> nilnul.fs.address_.container.re_.Sup.Singleton.re(x,candidate) ) )
			{
				return nilnul.obj.seq.convert_._AppendX.Append(
					t, candidate
				);
			}
			return t;
			
		}

		static public IEnumerable<nilnul.fs.address_.ContainerI1> _Fro(IEnumerable<nilnul.fs.address_.ContainerI1> _disjoint) {


			return _Fro(
				new nilnul.fs.address_.ContainerI1[0]
				, 
				
				_disjoint
				
			);
			
		}

		

		public IEnumerator<ContainerI1> GetEnumerator()
		{
			return en.GetEnumerator();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
