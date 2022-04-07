using CalValEX.Items.Tiles.Banners;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using CalValEX.Items.Critters;
//using CalamityMod.CalPlayer;

namespace CalValEX.NPCs.Critters
{
    public class Isopod : ModNPC
    {
        public override void SetStaticDefaults()
        {
            //DisplayName.SetDefault("Abyssal Isopod");
            Main.npcFrameCount[NPC.type] = 8;
            Main.npcCatchable[NPC.type] = true;
        }

        public override void SetDefaults()
        {
            NPC.width = 56;
            NPC.height = 26;
            //NPC.aiStyle = 67;
            //NPC.damage = 0;
            //NPC.defense = 0;
            //NPC.lifeMax = 2000;
            //NPC.HitSound = SoundID.NPCHit38;
            //NPC.DeathSound = SoundID.NPCDeath1;
            //NPC.npcSlots = 0.5f;
            //NPC.noGravity = true;
            //NPC.catchItem = 2007;

            NPC.CloneDefaults(NPCID.GlowingSnail);
            NPC.catchItem = (short)ItemType<IsopodItem>();
            NPC.lavaImmune = false;
            //NPC.aiStyle = 0;
            NPC.friendly = true; // We have to add this and CanBeHitByItem/CanBeHitByProjectile because of reasons.
            AIType = NPCID.GlowingSnail;
            AnimationType = NPCID.GlowingSnail;
            NPC.HitSound = SoundID.NPCHit38;
            NPC.lifeMax = 2000;
            for (int i = 0; i < NPC.buffImmune.Length; i++)
            {
                //NPC.buffImmune[(ModLoader.GetMod("CalamityMod").BuffType("CrushDepth"))] = false;
            }
            Banner = NPC.type;
            BannerItem = ItemType<IsopodBanner>();
        }

        public override void SetBestiary(Terraria.GameContent.Bestiary.BestiaryDatabase database, Terraria.GameContent.Bestiary.BestiaryEntry bestiaryEntry)
        {
            bestiaryEntry.UIInfoProvider = new Terraria.GameContent.Bestiary.CommonEnemyUICollectionInfoProvider(ContentSamples.NpcBestiaryCreditIdsByNpcNetIds[Type], quickUnlock: true);
            bestiaryEntry.Info.AddRange(new Terraria.GameContent.Bestiary.IBestiaryInfoElement[] {
                Terraria.GameContent.Bestiary.BestiaryDatabaseNPCsPopulator.CommonTags.SpawnConditions.Biomes.Ocean,
                new Terraria.GameContent.Bestiary.FlavorTextBestiaryInfoElement("A docile scavenger that makes itself at home at the bottom of the Abyss. They are known to clean up the remains of any victims to the Abyss' other fauna."),
            });
        }

        public override bool? CanBeHitByItem(Player player, Item item)
        {
            return true;
        }

        public override bool? CanBeHitByProjectile(Projectile projectile)
        {
            return true;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            //Mod clamMod = ModLoader.GetMod("CalamityMod"); //this is to get calamity mod, you have to add 'weakReferences = CalamityMod@1.4.4.4' (without the '') in your build.txt for this to work
            //if (clamMod != null)
            {
                if (spawnInfo.player.ZoneNormalCaverns/*GetModPlayer<CalamityPlayer>().ZoneAbyssLayer4*/ && !CalValEXConfig.Instance.CritterSpawns)
                {
                    if (spawnInfo.water)
                    {
                        return Terraria.ModLoader.Utilities.SpawnCondition.CaveJellyfish.Chance * 1.2f;
                    }
                }
            }
            return 0f;
        }

        public override void OnCatchNPC(Player player, Item item)
        {
            item.stack = 1;
        }

        public override void HitEffect(int hitDirection, double damage)
        {
            if (NPC.life <= 0)
            {
                Gore.NewGore(NPC.position, NPC.velocity, Mod.Find<ModGore>("Isopod").Type, 1f);
                Gore.NewGore(NPC.position, NPC.velocity, Mod.Find<ModGore>("Isopod2").Type, 1f);
                Gore.NewGore(NPC.position, NPC.velocity, Mod.Find<ModGore>("Isopod3").Type, 1f);
                Gore.NewGore(NPC.position, NPC.velocity, Mod.Find<ModGore>("Isopod4").Type, 1f);
            }
        }

        // TODO: Hooks for Collision_MoveSnailOnSlopes and NPC.aiStyle = 67 problem
    }
}