using Terraria;
using Terraria.ModLoader;

namespace LPTownNPCShield
{
	public class InvulnerableTownNPC : GlobalNPC
    {
        public override void ModifyHitNPC(NPC npc, NPC target, ref NPC.HitModifiers modifiers)
        {
            if (target.friendly)
            {
                modifiers.SetMaxDamage(1);
            }
        }

        public override void ModifyHitByProjectile(NPC npc, Projectile projectile, ref NPC.HitModifiers modifiers)
        {
            if (npc.friendly && !projectile.trap)
            {
                modifiers.SetMaxDamage(1);
            }
        }
    }
}
