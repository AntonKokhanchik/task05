﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Moves
{
	/// <summary>
	/// ходьба
	/// </summary>
	public class Walk : IMove
	{
		string move = "Я хожу";
		public string Move()
		{
			return move;
		}
	}
}
