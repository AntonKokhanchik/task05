using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Moves
{
	/// <summary>
	/// прыжки
	/// </summary>
	public class Jump : IMove
	{
		string move = "Я передвигаюсь прыжками";
		public string Move()
		{
			return move;
		}
	}
}
