﻿using Terraria;
using Terraria.ModLoader;

namespace CalValEX.Buffs.Pets
{
    public class RoverSpindleBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Wulfrum Rover");
            Description.SetDefault("Brilliance irreplaceable...");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<CalValEXPlayer>().roverd = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[ModContent.ProjectileType<Projectiles.Pets.RoverSpindlePet>()] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ModContent.ProjectileType<Projectiles.Pets.RoverSpindlePet>(), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}