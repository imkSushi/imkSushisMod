using System;
using Terraria.ModLoader;

namespace imkSushisMod
{
	public class imkSushisMod : Mod
	{
		
		public override void AddRecipes()
		{
			base.AddRecipes();
			RecipeManager.AddRecipes(this);
		}
	}
}