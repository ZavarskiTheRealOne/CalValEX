using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using CalValEX;
using CalValEX.Items.Pets;

namespace CalValEX
{
	public class CalValEXPlayer : ModPlayer
	{
		private const int saveVersion = 0;
		
		public bool ZoneAstral;

		public bool mBirb = false;
		public bool mBirb2 = false;
		public bool mDoge = false;
		public bool hDoge = false;
		public bool bDoge = false;
		public bool mAero = false;
		public bool aero = false;
		public bool mSkater = false;
		public bool mShark = false;
		public bool mFolly = false;
		public bool mPerf = false;
		public bool mHive = false;
		public bool mPhan = false;
		public bool mChan = false;
		public bool mNaked = false;
		public bool mArmored = false;
		public bool SWPet = false;
		public bool eidolist = false;
		public bool excal = false;
		public bool mRav = false;
		public bool tub = false;
		public bool andro = false;
		public bool seerS = false;
		public bool seerM = false;
		public bool seerL = false;
		public bool mImp = false;
		public bool George = false;
		public bool rPanda = false;
		public bool catfish = false;
		public bool cr = false;
		public bool	eb = false;
		public bool	mSlime = false;
		public bool	fog = false;
		public bool mDebris = false;
		public bool mHeat = false;
		public bool mHeat2 = false;
		public bool dBall = false;
		public bool mClam = false;
		public bool mAme = false;
		public bool	mSap = false;
		public bool	mEme = false;
		public bool	mTop = false;
		public bool	mRub = false;
		public bool	mDia = false;
		public bool	mCry = false;
		public bool	mAmb = false;
		public bool sBun = false;
		public bool uSerpent = false;
		public bool GeorgeII = false;
		public bool junsi = false;
		public bool SignusMini = false;
		public bool Angrypup = false;
		public bool cryokid = false;

	public bool MiniCryo = false;

	public bool SmolCrab = false;

	public bool VoidOrb = false;

	public bool AstPhage = false;

	public bool StarJelly = false;

	public bool ProGuard1 = false;

	public bool ProGuard2 = false;

	public bool ProGuard3 = false;

	public bool ProviPet = false;

	public bool Dstone = false;

	public bool EWyrm = false;

	public bool PBGmini = false;

	public bool BoldLizard = false;

	public bool Nugget = false;

	public bool Enredpet = false;

	public bool sandmini = false;

	public bool raresandmini = false;

	public bool babywaterclone = false;

	public bool rarebrimling = false;

	public bool cloudmini = false;

	public bool Skeetyeet = false;
	public bool TerminalRock = false;
	public bool BabyCnidrion = false;
	public bool sVoid = false;
	public bool	sSignus = false;
	public bool	sWeeb = false;
	public bool	euros = false;
	public bool jared = false;
	public bool asPet = false;
	public bool dsPet = false;
	public bool mDuke = false;
	public bool sirember = false;
	public bool deusmain = false;
	public bool deussmall = false;
	public bool rusty = false;
	public bool sepet = false;
	public bool pylon = false;
	public bool worb = false;
	public bool rover = false;
	public bool drone = false;
	public bool hover = false;
	public bool RepairBot = false;
		
		public override void ResetEffects()
		{
			mBirb = false;
			mBirb2 = false;
			mDoge = false;
			mAero = false;
			mSkater = false;
			mShark = false;
			mFolly = false;
			mPerf = false;
			mHive = false;
			mPhan = false;
			mChan = false;
			mNaked = false;
			mArmored = false;
			eidolist = false;
			excal = false;
			aero = false;
			mRav = false;
			tub = false;
			andro = false;
			seerS = false;
			seerM = false;
			seerL = false;
			mImp = false;
			George = false;
			rPanda = false;
			catfish = false;
			cr = false;
			eb = false;
			mSlime = false;
			fog = false;
			mDebris = false;
			mHeat = false;
			mHeat2 = false;
			dBall = false;
			mClam = false;
			mAme = false;
			mSap = false;
			mEme = false;
			mTop = false;
			mRub = false;
			mDia = false;
			mCry = false;
			mAmb = false;
			sBun = false;
			uSerpent = false;
			GeorgeII = false;
			junsi = false;
			SignusMini = false;
		MiniCryo = false;
		SmolCrab = false;
		VoidOrb = false;
		AstPhage = false;
		StarJelly = false;
		ProGuard1 = false;
		ProGuard2 = false;
		ProGuard3 = false;
		ProviPet = false;
		Dstone = false;
		EWyrm = false;
		PBGmini = false;
		BoldLizard = false;
		Nugget = false;
		Enredpet = false;
		sandmini = false;
		raresandmini = false;
		rarebrimling = false;
		babywaterclone = false;
		cloudmini = false;
		Skeetyeet = false;
		Angrypup = false;
		cryokid = false;
		TerminalRock = false;
		BabyCnidrion = false;
		sVoid = false;
		sSignus = false;
		sWeeb = false;
		euros = false;
		hDoge = false;
		bDoge = false;
		SWPet = false;
		jared = false;
		asPet = false;
		dsPet = false;
		mDuke = false;
		sirember = false;
		deusmain = false;
		deussmall = false;
		rusty = false;
		sepet = false;
		pylon = false;
		worb = false;
		rover = false;
		drone = false;
		hover = false;
		RepairBot = false;
		}

		public override void UpdateDead()
		{
			mBirb = false;
			mBirb2 = false;
			mDoge = false;
			mAero = false;
			mSkater = false;
			mShark = false;
			mFolly = false;
			mPerf = false;
			mHive = false;
			mPhan = false;
			mChan = false;
			mNaked = false;
			mArmored = false;
			eidolist = false;
			excal = false;
			aero = false;
			mRav = false;
			tub = false;
			andro = false;
			seerS = false;
			seerM = false;
			seerL = false;
			mImp = false;
			George = false;
			rPanda = false;
			catfish = false;
			cr = false;
			eb = false;
			mSlime = false;
			fog = false;
			mDebris = false;
			mHeat = false;
			mHeat2 = false;
			dBall = false;
			mClam = false;
			mAme = false;
			mSap = false;
			mEme = false;
			mTop = false;
			mRub = false;
			mDia = false;
			mCry = false;
			mAmb = false;
			sBun = false;
			uSerpent = false;
			GeorgeII = false;
			junsi = false;
			SignusMini = false;
		MiniCryo = false;
		SmolCrab = false;
		VoidOrb = false;
		AstPhage = false;
		StarJelly = false;
		ProGuard1 = false;
		ProGuard2 = false;
		ProGuard3 = false;
		ProviPet = false;
		Dstone = false;
		EWyrm = false;
		PBGmini = false;
		BoldLizard = false;
		Nugget = false;
		Enredpet = false;
		sandmini = false;
		raresandmini = false;
		rarebrimling = false;
		babywaterclone = false;
		cloudmini = false;
		Skeetyeet = false;
		Angrypup = false;
		cryokid = false;
		TerminalRock = false;
		BabyCnidrion = false;
		sVoid = false;
		sSignus = false;
		sWeeb = false;
		euros = false;
		hDoge = false;
		bDoge = false;
		SWPet = false;
		jared = false;
		asPet = false;
		dsPet = false;
		mDuke = false;
		sirember = false;
		deusmain = false;
		deussmall = false;
		rusty = false;
		sepet = false;
		pylon = false;
		worb = false;
		rover = false;
		drone = false;
		hover = false;
		RepairBot = false;
		}

		public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
	{
		if (player.ZoneBeach && power > 80 && Utils.NextFloat(Main.rand) < 0.021f)
		{
			caughtType = mod.ItemType("WetBubble");
		}
		Mod clamMod = ModLoader.GetMod("CalamityMod");
		if ((bool)clamMod.Call("GetInZone", Main.player[Main.myPlayer], "sulphursea") && power > 90 && Utils.NextFloat(Main.rand) < 0.02f)
		{
			caughtType = mod.ItemType("CursedLockpick");
		}
	}
	
	public override void UpdateBiomes() {
			ZoneAstral = CalValEXWorld.astralTiles > 50;
		}

		public override bool CustomBiomesMatch(Player other) {
			CalValEXPlayer modOther = other.GetModPlayer<CalValEXPlayer>();
			return ZoneAstral == modOther.ZoneAstral;
		}

		public override void CopyCustomBiomesTo(Player other) {
			CalValEXPlayer modOther = other.GetModPlayer<CalValEXPlayer>();
			modOther.ZoneAstral = ZoneAstral;
		}

		public override void SendCustomBiomes(BinaryWriter writer) {
			BitsByte flags = new BitsByte();
			flags[0] = ZoneAstral;
			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader) {
			BitsByte flags = reader.ReadByte();
			ZoneAstral = flags[0];
		}
	}
}
