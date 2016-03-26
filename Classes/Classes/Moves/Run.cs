using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Moves
{
	public class Run : IMove
	{
		string move = "Я бегаю";
		public string Move()
		{
			return move;
		}
	}
}
