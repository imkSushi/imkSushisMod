using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.Map;

namespace imkSushisMod;


// ReSharper disable once PartialTypeWithSinglePart
public partial class RecipeCreator
{
    private static List<string> _recipeText = new();
    public const bool FORMATRECIPES = false;
    private static int _sectionLength = 0;
    private static int _totalLength = 0;
    private static int _sectionStart = 0;
    private readonly bool _disableDecrafting;

    public RecipeCreator(bool disableDecrafting = false)
    {
        _disableDecrafting = disableDecrafting;
    }

    // ReSharper disable once UnusedMember.Global
    public void New((int ingredient, int stack, bool group)[] ingredients,
        int[] tiles,
        (int item, int stack) result,
        bool format = FORMATRECIPES)
    {
        var recipe = Recipe.Create(result.item, result.stack);
        if(_disableDecrafting)
        {
            recipe.DisableDecraft();
        }

        foreach (var (ingredient, stack, group) in ingredients)
        {
            if (group)
                recipe.AddRecipeGroup(ingredient, stack);
            else
            {
                recipe.AddIngredient(ingredient, stack);
                if(!_disableDecrafting && GetIngredientDecraftCondition(ingredient, out var condition))
                {
                    recipe.AddDecraftCondition(condition);
                }
            }
        }
        
        foreach (var tile in tiles)
        {
            recipe.AddTile(tile);
            if(!_disableDecrafting && GetCraftingStationDecraftCondition(tile, out var condition))
            {
                recipe.AddDecraftCondition(condition);
            }
        }

        recipe.Register();

        if (format)
        {
            var str = ingredients
                .Select(ingredient =>
                {
                    var name = ingredient.group
                        ? GetGroupName(ingredient.ingredient)
                        : GetItemName((short)ingredient.ingredient);
                    return ingredient.stack == 1
                            ? $"{name}"
                            : $"{name} x{ingredient.stack}";
                })
                .Aggregate((left, right) => left + " + " + right);
            if (tiles.Length > 0)
            {
                str += " @ " + tiles.Select(GetTileName).Aggregate((left, right) => left + " & " + right);
            }
            
            str += " -> " + GetItemName(result.item) + (result.stack == 1 ? "" : " x" + result.stack);
            
            _recipeText.Add(str);
        }
        
        if (FORMATRECIPES)
            UpdateRecipeNumbers();
    }

    public static bool GetIngredientDecraftCondition(int ingredient, [MaybeNullWhen(false)]out Condition condition)
    {
        condition = ingredient switch
        {
            //Drops
            ItemID.ShadowScale or ItemID.TissueSample =>
                Condition.DownedEowOrBoc,
            ItemID.Bone =>
                Condition.DownedSkeletron,
            ItemID.CursedFlame or ItemID.Ichor =>
                Condition.Hardmode,
            ItemID.PixieDust or ItemID.UnicornHorn =>
                Condition.Hardmode,

            //Souls and Fragments
            ItemID.SoulofFlight or ItemID.SoulofLight or ItemID.SoulofNight =>
                Condition.Hardmode,
            ItemID.SoulofFright => Condition.DownedSkeletronPrime,
            ItemID.SoulofMight => Condition.DownedDestroyer,
            ItemID.SoulofSight => Condition.DownedTwins,
            ItemID.FragmentVortex or ItemID.FragmentNebula or ItemID.FragmentSolar or ItemID.FragmentStardust =>
                Condition.DownedCultist,

            //Ores and Bars
            ItemID.CobaltOre or ItemID.PalladiumOre or ItemID.MythrilOre or ItemID.OrichalcumOre or ItemID.AdamantiteOre or ItemID.TitaniumOre or
            ItemID.CobaltBar or ItemID.PalladiumBar or ItemID.MythrilBar or ItemID.OrichalcumBar or ItemID.AdamantiteBar or ItemID.TitaniumBar =>
                Condition.Hardmode,
            ItemID.HallowedBar =>
                Condition.DownedMechBossAny,
            ItemID.ChlorophyteOre or ItemID.ChlorophyteBar =>
                Condition.DownedMechBossAll,
            ItemID.ShroomiteBar =>
                Condition.DownedPlantera,
            ItemID.Ectoplasm or ItemID.SpectreBar => 
                Condition.DownedPlantera,
            ItemID.LunarOre or ItemID.LunarBar =>
                Condition.DownedMoonLord,
            _ => null
        };
        return condition != null;
    }

    public static bool GetCraftingStationDecraftCondition(int craftingStation, [MaybeNullWhen(false)]out Condition condition)
    {
        condition = craftingStation switch
        {
            TileID.TinkerersWorkbench => Condition.DownedGoblinArmy,
            TileID.CrystalBall => Condition.Hardmode,
            TileID.MythrilAnvil => Condition.Hardmode,
            TileID.AdamantiteForge => Condition.Hardmode,
            TileID.Autohammer => Condition.DownedPlantera,
            TileID.LunarCraftingStation => Condition.DownedCultist,
            _ => null
        };
        return condition != null;
    }
    
    public string GetItemName(int id)
    {
        return Lang.GetItemName(id).Value;
    }

    public string GetGroupName(int id)
    {
        return RecipeGroup.recipeGroups[id].GetText();
    }
    
    public string GetTileName(int id)
    {
        return Lang.GetMapObjectName(MapHelper.tileLookup[id]);
    }

    public void StartNewRecipeSection(string name)
    {
        if (FORMATRECIPES)
        {
            if (_recipeText.Count > 0)
            {
                _recipeText.Add("[/SPOILER]");
                _recipeText.Add("");
                _recipeText[_sectionStart] = $"[SPOILER={_recipeText[_sectionStart]} ({_sectionLength} recipes)]";
            }

            _recipeText.Add(name);
            _sectionStart = _recipeText.Count - 1;
            _sectionLength = 0;
        }
    }

    private void UpdateRecipeNumbers()
    {
        _sectionLength++;
        _totalLength++;
    }

    public void New2Way(int item1, int item2, int tile, bool format = FORMATRECIPES)
    {
        New(item1, tile, item2, false);
        New(item2, tile, item1, false);
        if (format)
        {
            _recipeText.Add($"{GetItemName(item1)} <-> {GetItemName(item2)} @ {GetTileName(tile)}");
        }
    }
    
    public void NewTaxed2Way(int item1, int item2, int tax, int tile, bool format = FORMATRECIPES)
    {
        New(item1, tax, tile, item2, false);
        New(item2, tax, tile, item1, false);
        if (format)
        {
            _recipeText.Add($"{GetItemName(item1)} <-> {GetItemName(item2)} @ {GetTileName(tile)} (+ {GetItemName(tax)})");
        }
    }

    public void NewTaxed2Way(int item1,
        int item2,
        (int item, int stack) tax,
        int tile,
        bool format = FORMATRECIPES)
    {
        New(item1, (tax.item, tax.stack), tile, item2, false);
        New(item2, (tax.item, tax.stack), tile, item1, false);
        if (format)
        {
            _recipeText.Add($"{GetItemName(item1)} <-> {GetItemName(item2)} @ {GetTileName(tile)} (+ {tax.stack}x {GetItemName(tax.item)})");
        }
    }

    public void New3Way(int item1, int item2, int item3, int tile, bool format = FORMATRECIPES)
    {
        New2Way(item1, item2, tile, false);
        New2Way(item2, item3, tile, false);
        New2Way(item3, item1, tile, false);
        if (format)
        {
            _recipeText.Add($"{GetItemName(item1)} <-> {GetItemName(item2)} <-> {GetItemName(item3)} @ {GetTileName(tile)}");
        }
    }

    public void NewTaxed3Way(int item1, int item2, int item3, int tax, int tile, bool format = FORMATRECIPES)
    {
        NewTaxed2Way(item1, item2, tax, tile, false);
        NewTaxed2Way(item2, item3, tax, tile, false);
        NewTaxed2Way(item3, item1, tax, tile, false);
        if (format)
        {
            _recipeText.Add($"{GetItemName(item1)} <-> {GetItemName(item2)} <-> {GetItemName(item3)} @ {GetTileName(tile)} (+ {GetItemName(tax)})");
        }
    }
    
    public void NewTaxed3Way(int item1, int item2, int item3, (int item, int stack) tax, int tile, bool format = FORMATRECIPES)
    {
        NewTaxed2Way(item1, item2, tax, tile, false);
        NewTaxed2Way(item2, item3, tax, tile, false);
        NewTaxed2Way(item3, item1, tax, tile, false);
        if (format)
        {
            _recipeText.Add($"{GetItemName(item1)} <-> {GetItemName(item2)} <-> {GetItemName(item3)} @ {GetTileName(tile)} (+ {tax.stack}x {GetItemName(tax.item)})");
        }
    }

    public void NewTaxed4Way(int item1,
        int item2,
        int item3,
        int item4,
        (int item, int stack) tax,
        int tile,
        bool format = FORMATRECIPES)
    {
        NewTaxed3Way(item1, item2, item3, tax, tile, false);
        NewTaxed2Way(item1, item4, tax, tile, false);
        NewTaxed2Way(item2, item4, tax, tile, false);
        NewTaxed2Way(item3, item4, tax, tile, false);
        if (format)
        {
            _recipeText.Add($"{GetItemName(item1)} <-> {GetItemName(item2)} <-> {GetItemName(item3)} <-> {GetItemName(item4)} @ {GetTileName(tile)} (+ {tax.stack}x {GetItemName(tax.item)})");
        }
    }

    public static void OutputRecipes(string path)
    {
        if (FORMATRECIPES)
        {
            var output = new string[]
            {
                "Total recipes: " + _totalLength,
                ""
            };
            File.WriteAllLines(path, output.Concat(_recipeText).ToArray());
        }

    }
}