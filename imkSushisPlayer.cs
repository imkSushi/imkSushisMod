using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace imkSushisMod;
public class imkSushisPlayer : ModPlayer
{
	public void HighestHealth()
	{
		if (Player.noItems)
			return;
		if (Player.potionDelay > 0)
			return;
		var highestHealthPotion = 0;
		for (var i = 0; i < 58; i++)
		{
			var item2 = Player.inventory[i];
			if (item2.stack > 0 && item2.type > ItemID.None && item2.potion && item2.healLife > highestHealthPotion)
			{
				highestHealthPotion = item2.healLife;
			}
		}
		if ((highestHealthPotion + Player.statLife <= Player.statLifeMax2) && (highestHealthPotion > 0))
		{
			Player.QuickHeal();
		}
	}
	
}