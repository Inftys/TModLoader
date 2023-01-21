using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using NewMod.Projectiles;
using System;

namespace NewMod.Items {
    public class Radius : ModItem {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Radius");
            Tooltip.SetDefault("Ra di a tio n");
        }

        public override void SetDefaults() {
            Item.pick = 2333;
            Item.rare = -11;
            Item.damage = 233;
            Item.crit = 233;
            Item.useStyle = 5;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.mana = 0;
            
            Item.autoReuse = false;
            Item.useTurn = true;
            Item.noMelee = true;

            Item.DamageType = DamageClass.Magic;

            Item.shoot = ModContent.ProjectileType<Proj_Eye>();
            Item.shootSpeed = 5;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Vector2 vel = Main.MouseWorld - player.Center;
            vel.Normalize();                
            vel *= 8;
            Projectile.NewProjectileDirect(source, position, vel, type, damage, knockback, player.whoAmI);
            return false;    
        }
    }
}