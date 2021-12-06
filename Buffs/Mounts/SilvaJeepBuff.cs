﻿using Terraria;
using Terraria.ModLoader;
using CalValEX.Items.Mounts.Ground;

namespace CalValEX.Buffs.Mounts
{
    public class SilvaJeepBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Silvian Jeep");
            Description.SetDefault("Beep beep I'm a jeep");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.mount.SetMount(ModContent.MountType<SilvaJeep>(), player);
            player.buffTime[buffIndex] = 10;
            CalValEX.MountNerf(player, 0.9f, 0.85f);
        }
    }
}