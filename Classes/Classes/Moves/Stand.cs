﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Moves
{
	public class Stand :IMove
	{
		string move = "Я не двигаюсь";
		public string Move()
		{
			return move;
		}
	}
}
