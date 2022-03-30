﻿using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Tiles.Monoliths;

namespace CalValEX.Items.Tiles.Monoliths
{
    public class AuroraMonolith : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Calls the auroras of the arctic when activated");
        }

        public override void SetDefaults()
        {
            Item.width = 22;
            Item.height = 32;
            Item.maxStack = 999;
            Item.useTurn = true;
            Item.autoReuse = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.consumable = true;
            Item.rare = ItemRarityID.Pink;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.createTile = ModContent.TileType<AuroraMonolithPlaced>();
        }

        /*public override void AddRecipes()
        {
            Mod CalValEX = ModLoader.GetMod("CalamityMod");
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModLoader.GetMod("CalamityMod").ItemType("VerstaltiteBar"), 15);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }*/
    }
}