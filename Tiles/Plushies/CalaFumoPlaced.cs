﻿using CalValEX.Items.Plushies;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace CalValEX.Tiles.Plushies
{
    public class CalaFumoPlaced : ModTile
    {
        public override string Texture => "CalValEX/Tiles/Plushies/CalamitasPlushPlaced";
        public override void SetStaticDefaults()
        {
            RegisterItemDrop(PlushManager.PlushItems["Calamitas"]);
            Main.tileFrameImportant[Type] = true;
            Terraria.ID.TileID.Sets.DisableSmartCursor[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Width = 2;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.addTile(Type);
            LocalizedText name = CreateMapEntryName();
            // name.SetDefault("Calamitas Fumo");
            AddMapEntry(new Color(144, 148, 144), name);
            DustType = 11;

        }
    }
}