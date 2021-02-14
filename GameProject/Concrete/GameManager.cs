﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
	public class GameManager : IGameService
	{
		public void Add(Game game)
		{
			Console.WriteLine("Oyun Eklendi : "+game.GameName);
		}

		public void Delete(Game game)
		{
			Console.WriteLine("Oyun Silindi : " + game.GameName);
		}

		public void Update(Game game)
		{
			Console.WriteLine("Oyun Güncellendi : " + game.GameName);
		}
	}
}
