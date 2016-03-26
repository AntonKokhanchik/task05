using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	/// <summary>
	/// животное
	/// </summary>
	public abstract class Animal
	{
		public virtual string Name { get; set; }
		public virtual IMove MoveType { get; protected set; }
		public virtual IVoice VoiseType { get; protected set; }

		protected Animal() { }
	}
}
