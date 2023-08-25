using System;
using Terraria;
using Terraria.ModLoader;

namespace imkSushisMod {
public class imkSushisWorld : ModSystem
{
    public int SkipAm = 0;
    public int TimeSpeed = 0;

    public override void PreUpdateTime()
    {
        if (SkipAm <= 0) 
            return;
        
        var maxTimeSpeed = MaxTimeSpeed();

        if (maxTimeSpeed > TimeSpeed && TimeSpeed < 100)
            TimeSpeed++;
        else if (maxTimeSpeed < TimeSpeed) 
            TimeSpeed--;
            
        Main.time += TimeSpeed;
        SkipAm -= TimeSpeed;
    }
    
    public int MaxTimeSpeed()
    {
        var eightNPlusOne = 8 * SkipAm + 1;
        return (int)Math.Floor((Math.Sqrt(eightNPlusOne) - 1) / 2);
    }

    public void AddTime(int am)
    {
    	SkipAm += am * 100;
    }
}}