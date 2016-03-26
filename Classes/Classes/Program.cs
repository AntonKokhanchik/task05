using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Program
	{
		static void Main(string[] args)
		{
			Program p = new Program();
			List<Animal> zoo = new List<Animal>();
			do { }
			while (p.Menu1(zoo));
		}




		public bool Menu1(List<Animal> zoo)
		{
			PrintMenu();
			ConsoleKey ch = Console.ReadKey(true).Key;
			if (ch == ConsoleKey.Escape)
				return false;

			Console.Clear();

			try
			{
				Switcher(ch, zoo);
			}
			catch (ArgumentException exc)
			{
				if (exc.Message == "нет пункта меню")
					Console.WriteLine("выбирать можно нажатием на клавиши с цифрами\n\n");
				else throw exc;
			}
			return true;
		}

		public void PrintMenu()
		{
			Console.WriteLine("Выберете желаемое действие:");

			Console.WriteLine("1.Просмотреть зоопарк");
			Console.WriteLine("2.Добавить нвое животное");

			Console.WriteLine("Esc для выхода");
		}

		public void Switcher(ConsoleKey ch, List<Animal> zoo)
		{
			switch (ch)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					WriteZoo(zoo); break;
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					AddAnimal(zoo); break;

				default: throw new ArgumentException("нет пункта меню");
			}
		}




		public void WriteZoo(List<Animal> zoo)
		{
			if(zoo.Count == 0)
				Console.WriteLine("Зоопарк пуст");
			else
				foreach (Animal a in zoo)
					Console.WriteLine("{0}, {1}, {2}", a.Name, a.MoveType.Move(), a.VoiseType.Voice());
		}

		public void AddAnimal(List<Animal> zoo)
		{
			IMove moveType;
			IVoice voiseType;
			bool more = false;

			do
			{
				do { }
				while (SubMenu1(out voiseType));

				do { }
				while (SubMenu2(out moveType));

				do { }
				while (SubMenu3(zoo, moveType, voiseType, out more));

				more = More();
			}
			while (more);
		}

		public bool More()
		{
			Console.WriteLine("Хотите добваить ещё?");
			Console.WriteLine("1.Да");
			Console.WriteLine("2.Нет");
			do
			{
				switch (Console.ReadKey(true).Key)
				{
					case ConsoleKey.D1:
					case ConsoleKey.NumPad1:
						return true;
					case ConsoleKey.D2:
					case ConsoleKey.NumPad2:
						return false;
				}
			}
			while (true);
		}


		public bool SubMenu1(out IVoice voiceType)
		{
			PrintSubMenu1();

			ConsoleKey ch = Console.ReadKey(true).Key;

			Console.Clear();

			try
			{
				voiceType = SwitcherSub1(ch);
			}
			catch (ArgumentException exc)
			{
				if (exc.Message == "нет пункта меню")
				{
					Console.WriteLine("выбирать можно нажатием на клавиши с цифрами\n\n");
					voiceType = null;
					return true;
				}
				else throw exc;
			}
			return false;
		}

		public void PrintSubMenu1()
		{
			Console.WriteLine("Выберете способ издавать звуки для нового животного:");

			Console.WriteLine("1.Тявкание");
			Console.WriteLine("2.Карканье");
			Console.WriteLine("3.Шипение");
			Console.WriteLine("4.Мяукание");
			Console.WriteLine("5.Рычание");
			Console.WriteLine("6.Ничего");
		}

		public IVoice SwitcherSub1(ConsoleKey ch)
		{
			switch (ch)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					return new Voiсes.Bark();
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					return new Voiсes.Caw();
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					return new Voiсes.Hiss();
				case ConsoleKey.D4:
				case ConsoleKey.NumPad4:
					return new Voiсes.Mew();
				case ConsoleKey.D5:
				case ConsoleKey.NumPad5:
					return new Voiсes.Roar();
				case ConsoleKey.D6:
				case ConsoleKey.NumPad6:
					return new Voiсes.Silence();

				default: throw new ArgumentException("нет пункта меню");
			}
		}




		public bool SubMenu2(out IMove moveType)
		{
			PrintSubMenu2();

			ConsoleKey ch = Console.ReadKey(true).Key;

			Console.Clear();

			try
			{
				moveType = SwitcherSub2(ch);
			}
			catch (ArgumentException exc)
			{
				if (exc.Message == "нет пункта меню")
				{
					Console.WriteLine("выбирать можно нажатием на клавиши с цифрами\n\n");
					moveType = null;
					return true;
				}
				else throw exc;
			}
			return false;
		}

		public void PrintSubMenu2()
		{
			Console.WriteLine("Выберете способ передвижения нового животного:");

			Console.WriteLine("1.Полёт");
			Console.WriteLine("2.Передвижение прыжками");
			Console.WriteLine("3.Бег");
			Console.WriteLine("4.Ходьба");
			Console.WriteLine("5.Ползание");
			Console.WriteLine("6.Ничего");
		}

		public IMove SwitcherSub2(ConsoleKey ch)
		{
			switch (ch)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					return new Moves.Fly();
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					return new Moves.Jump();
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					return new Moves.Run();
				case ConsoleKey.D4:
				case ConsoleKey.NumPad4:
					return new Moves.Walk();
				case ConsoleKey.D5:
				case ConsoleKey.NumPad5:
					return new Moves.Сrawl();
				case ConsoleKey.D6:
				case ConsoleKey.NumPad6:
					return new Moves.Stand();

				default: throw new ArgumentException("нет пункта меню");
			}
		}




		public bool SubMenu3(List<Animal> zoo, IMove moveType, IVoice voiseType, out bool more)
		{
			PrintSubMenu3();

			ConsoleKey ch = Console.ReadKey(true).Key;

			Console.Clear();

			try
			{
				SwitcherSub3(ch, zoo, moveType, voiseType);
			}
			catch (ArgumentException exc)
			{
				if (exc.Message == "нет пункта меню")
				{
					Console.WriteLine("выбирать можно нажатием на клавиши с цифрами\n\n");
					more = true;
					return true;
				}
				else if (exc.Message == "неверное передвижение")
					Console.WriteLine("Это животное не может так двигаться");
				else if (exc.Message == "неверное звучание")
					Console.WriteLine("Это животное не может издавать такие звуки");
				else throw exc;
			}
			more = false;
			return false;
		}

		public void PrintSubMenu3()
		{
			Console.WriteLine("Что это за животное?");

			Console.WriteLine("1.Медведь");
			Console.WriteLine("2.Кошка");
			Console.WriteLine("3.Ворона");
			Console.WriteLine("4.Лиса");
			Console.WriteLine("5.Змея");
		}

		public void SwitcherSub3(ConsoleKey ch, List<Animal> zoo, IMove moveType, IVoice voiseType)
		{
			switch (ch)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					zoo.Add(new Animals.Bear(moveType, voiseType)); break;
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					zoo.Add(new Animals.Cat(moveType, voiseType)); break;
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					zoo.Add(new Animals.Crow(moveType, voiseType)); break;
				case ConsoleKey.D4:
				case ConsoleKey.NumPad4:
					zoo.Add(new Animals.Fox(moveType, voiseType)); break;
				case ConsoleKey.D5:
				case ConsoleKey.NumPad5:
					zoo.Add(new Animals.Snake(moveType, voiseType)); break;

				default: throw new ArgumentException("нет пункта меню");
			}
		}
	}
}
