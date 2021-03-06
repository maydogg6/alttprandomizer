﻿using System;
using AlttpRandomizer.Random;

namespace AlttpRandomizer.Rom
{
    public class RomLocationsFactory
	{
		public static IRomLocations GetRomLocations(RandomizerDifficulty difficulty)
		{
			switch (difficulty)
			{
				case RandomizerDifficulty.Casual:
					return new RomLocationsCasual();
				default:
					throw new ArgumentException("Difficulty must be set.", "difficulty");
			}
		}
	}
}
