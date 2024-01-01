﻿using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Tiles.Plushies;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace CalValEX.Items.Tiles.Plushies
{
    public class DevourerofGodsPlush : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Devourer of Gods Plushie (Placeable)");
            // Tooltip.SetDefault("Master drop");
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.width = 44;
            Item.height = 44;
            Item.consumable = true;
            Item.UseSound = SoundID.Item1;
            Item.rare = CalamityID.CalRarityID.DarkBlue;
            Item.useAnimation = 20;
            Item.useTime = 20;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.value = 20;
            Item.createTile = ModContent.TileType<DevourerofGodsPlushPlaced>();
            Item.maxStack = 99;
        }
    }
}