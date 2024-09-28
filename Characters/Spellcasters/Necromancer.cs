

namespace MagicDestroyers.Characters.Spellcasters
{
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;

    class Necromancer : Spellcaster
    {
        private const string DEFAULT_NAME = "Necromancer";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LeatherVest DEFAULT_BODYARMOR = new LeatherVest();


        private LeatherVest bodyArmor;
        private Sword weapon;


      
      
        public LeatherVest BodyArmor 
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Sword Weapon 
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }


        public Necromancer()
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Necromancer(string name, int level)
            :this(name,level,DEFAULT_MANA_POINTS)
        {
        }
        public Necromancer(string name, int level, int manaPoints)
        :base (name,level,manaPoints)
        {

            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODYARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }
 


        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        public void BoneShield()
        {

        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }
    }

}

