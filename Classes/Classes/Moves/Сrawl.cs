﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Moves
{
	/// <summary>
	/// ползание
	/// </summary>
	public class Сrawl : IMove
	{
		string move = "Я ползаю";
		public string Move()
		{
			return move;
		}
	}
}
