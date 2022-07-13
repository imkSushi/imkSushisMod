using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace imkSushisMod
{
	public class imkSushisMod : Mod
	{
		public override void AddRecipes()
		{
			base.AddRecipes();
			for (var i = 2772; i < 2787; i++)
			{
				ItemID.Sets.Deprecated[i] = false;
			}
			for (var i = 2462; i < 3467; i++)
			{
				ItemID.Sets.Deprecated[i] = false;
			}
			RecipeManager.AddRecipes();
		}

		public override void AddRecipeGroups()
		{
			imkSushiRecipeGroups.AddRecipeGroups();
		}

		public override void PostAddRecipes()
		{
			var recipe = new RecipeCreator();
			
			recipe.StartNewRecipeSection("");
            
			if (RecipeCreator.FORMATRECIPES)
			{
				Console.WriteLine("Recipe file path please:");
				var path = Console.ReadLine();
				if (path != "")
				{
					RecipeCreator.OutputRecipes(path);
				}
			}
		}
	}
}