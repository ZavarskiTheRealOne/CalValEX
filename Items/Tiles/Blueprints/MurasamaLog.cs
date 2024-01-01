using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using CalValEX.Tiles.Blueprints;

namespace CalValEX.Items.Tiles.Blueprints
{
    public class MurasamaLog : ModItem
    {
        public override string Texture => "CalValEX/Items/Tiles/Blueprints/Blueprint";
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Murasama Blueprint");
            /* Tooltip
                .SetDefault("Do Not Distribute"); */
            Item.ResearchUnlockCount = 1;
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTurn = true;
            Item.useAnimation = 15;
            Item.useTime = 10;
            Item.autoReuse = true;
            Item.maxStack = 99;
            Item.consumable = true;
            Item.createTile = ModContent.TileType<MurasamaBlueprintPlaced>();
            Item.width = 46;
            Item.height = 32;
            Item.rare = CalamityID.CalRarityID.Darkorange;
        }
    }
}