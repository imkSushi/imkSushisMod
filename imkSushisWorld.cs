using Terraria;
using Terraria.ModLoader;

namespace imkSushisMod {
public class imkSushisWorld : ModSystem
{
    public int SkipAm = 0;

    public override void PreUpdateTime()
    {
        if (SkipAm > 0)
        {
            Main.time += 100;
            SkipAm--;
        }
    }

    public void AddTime(int am)
    {
    	SkipAm += am;
    }
}}