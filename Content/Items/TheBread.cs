using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Breaded.Content.Items
{ 
	// This is a basic item template.
	// Please see tModLoader's ExampleMod for every other example:
	// https://github.com/tModLoader/tModLoader/tree/stable/ExampleMod
	public class TheBread : ModItem
	{
		// The Display Name and Tooltip of this item can be edited in the 'Localization/en-US_Mods.Bread.hjson' file.
		public override void SetDefaults()
		{
			Item.damage = 999999;
			Item.shoot = ModContent.ProjectileType<BreadBurst>();
			Item.shootSpeed = 17f;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 26;
			Item.value = Item.buyPrice(platinum: 10);
			Item.rare = ItemRarityID.Blue;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
	public class BreadBurst : ModProjectile
	{ 
		public override void SetDefaults()
		{
			Projectile.width = 1;
			Projectile.height = 1;

            Projectile.aiStyle = 1;
			AIType = ProjectileID.Bullet;

            Projectile.friendly = true;
			Projectile.hostile = false;

			Projectile.DamageType = DamageClass.Ranged;
			Projectile.tileCollide = true;
			Projectile.timeLeft = 60;
        }	
	}

}
