using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.Map;
using Terraria.ModLoader;

namespace imkSushisMod;


public partial class RecipeCreator
{
    private Mod _mod;
    private List<string> _recipeText = new();
    public const bool FORMATRECIPES = false;
    private int _sectionLength = 0;
    private int _totalLength = 0;
    private int _sectionStart = 0;
    public RecipeCreator(Mod mod)
    {
        _mod = mod;
    }

    public void New((int ingredient, int stack, bool group)[] ingredients,
        int[] tiles,
        (int item, int stack) result,
        bool format = FORMATRECIPES)
    {
        var recipe = _mod.CreateRecipe(result.item, result.stack);
        foreach (var (ingredient, stack, group) in ingredients)
        {
            if (group)
                recipe.AddRecipeGroup(ingredient, stack);
            else
                recipe.AddIngredient(ingredient, stack);
        }
        
        foreach (var tile in tiles)
        {
            recipe.AddTile(tile);
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
                _recipeText.Add("");
                _recipeText[_sectionStart] = $"[B][U]{_recipeText[_sectionStart]}[/U][/B] ({_sectionLength} recipes)";
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

    public void OutputRecipes(string path)
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