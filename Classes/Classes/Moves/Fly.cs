﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Moves
{
	/// <summary>
	/// полёт
	/// </summary>
	public class Fly :IMove
	{
		string move = "Я летаю";
		public string Move()
		{
			return move;
		}
	}
}
