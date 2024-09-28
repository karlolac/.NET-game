
namespace MagicDestroyers.Characters.Melees
{
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;
 
    using System;

    public class Warrior : Melee
    {
        private const string DEFAULT_NAME = "Warrior";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const Factions DEFAULT_FACTION = Factions.Melle;
        private readonly Axe DEFAULT_WEAPON=new Axe();
        private readonly ChainLink DEFAULT_BODYARMOR=new ChainLink();

     
        public Warrior()
            :this(DEFAULT_NAME,DEFAULT_LEVEL)
        {
        }
        public Warrior(string name, int level)
            :this(name,level,DEFAULT_HEALTH_POINTS)
        {
        }

        public Warrior(string name, int level, int healthPoints)
        : base(name, level, healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.BodyArmor = DEFAULT_BODYARMOR;
            base.Weapon = DEFAULT_WEAPON;

        }

        public void Strike()
        {
            
        }
        public void Execute()
        {
            
        }
        public void SkinHarden()
        {
            
        }

       

        public override void Attack()
        {
            this.Strike();
        }

        public override void SpecialAttack()
        {
            this.Execute();
        }

        public override void Defend()
        {
            this.SkinHarden();
        }
    }
}
