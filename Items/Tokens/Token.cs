using Terraria.ID;
using Terraria.ModLoader;

namespace imkSushisMod.Items.Tokens;

public abstract class Token : ModItem
{
    protected class TokenRecipeCreator
    {
        private RecipeCreator _recipe = new(true);
        private int _tokenId;

        public TokenRecipeCreator(int tokenId)
        {
            _tokenId = tokenId;
            _recipe.StartNewRecipeSection($"{_recipe.GetItemName(tokenId)} Recipes");
        }

        public void From(int item)
        {
            From((item, 1), 1);
        }

        public void From(int item, int resultStack)
        {
            From((item, 1), resultStack);
        }

        public void From((int item, int stack) item)
        {
            From(item, 1);
        }

        public void From((int item, int stack) item, int resultStack)
        {
            _recipe.New(new []{(item.item, item.stack, false)}, new int[]{TileID.TinkerersWorkbench}, (_tokenId, resultStack));
        }

        public void To((int item, int stack) result, int tokenStack)
        {
            _recipe.New(new []{(_tokenId, tokenStack, false)}, new int[]{TileID.TinkerersWorkbench}, (result.item, result.stack));
        }
        
        public void To((int item, int stack) result)
        {
            To(result, 1);
        }
        
        public void To(int result)
        {
            To((result, 1), 1);
        }
        
        public void To(int result, int tokenStack)
        {
            To((result, 1), tokenStack);
        }
    }
}