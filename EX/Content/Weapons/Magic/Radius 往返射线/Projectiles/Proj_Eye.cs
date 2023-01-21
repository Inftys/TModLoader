using Terraria;
using Terraria.ID;
using Microsoft.Xna.Framework;
using System;
using Terraria.ModLoader;
using NewMod.Particles;

namespace NewMod.Projectiles {
    public class Proj_Eye : ModProjectile {

        private float Timer {
            get => Projectile.ai[0];
	    set => Projectile.ai[0] = value;
        }
        public override void SetDefaults() {
            Projectile.width = 40;
            Projectile.height = 40;
            Projectile.scale = 1;
            Projectile.ignoreWater = true;
            Projectile.friendly = true;
            Projectile.tileCollide = false;
            Projectile.damage = 233;
            Projectile.alpha = 255;
            Projectile.penetrate = -1;
            Projectile.extraUpdates = 9;

            Projectile.timeLeft = 3000; // 600帧为1秒
        }

        public override void AI() {
            for(int i = 1; i <= 3; i += 1) {
                Dust dust1 = Dust.NewDustDirect(Projectile.Center, 10, 10, Draw.PinkFx, 0, 0, 0 ,default(Color), 1.3f);
                dust1.noGravity = true;
                dust1.velocity *= 0f;
            }

            Timer++;

            if (Timer == 180) {
                for(int i = 1; i <= 15; i += 1) {
                    Dust dust = Dust.NewDustDirect(Projectile.Center, 10, 10, Draw.PinkFx, 0, 0, 0, default(Color), 1.3f);
                }
                Projectile.velocity = -Projectile.velocity;
            }

            else if (Timer == 360) {
                for(int i = 1; i <= 15; i += 1) {
                    Projectile.timeLeft = 0;
                    Dust dust = Dust.NewDustDirect(Projectile.Center, 10, 10, Draw.PinkFx, 0, 0, 0, Color.Crimson, 1.3f);
                }
            }
        }

        public override void Kill(int timeLeft)
        {
            for(int i = 1; i <= 20; i += 1) {
                Dust dust = Dust.NewDustDirect(Projectile.Center, 10, 10, Draw.PinkFx, 0, 0, 0, default(Color), 2f);
            }
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            for(int i = 1; i <= 15; i += 1) {
                Dust dust = Dust.NewDustDirect(Projectile.Center, 10, 10, Draw.PinkFx, 0, 0, 0, default(Color), 2f);
            }
        }
    }
}
