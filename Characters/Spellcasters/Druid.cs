

namespace MagicDestroyers.Characters.Spellcasters
{
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;
 
    using System.Globalization;

    class Druid : Spellcaster
    {
        private const string DEFAULT_NAME = "Druid";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Spellcaster;
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly LeatherVest DEFAULT_BODYARMOR = new LeatherVest();

      
        private LeatherVest bodyArmor;
        private Staff weapon;


      
        public LeatherVest BodyArmor 
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.BodyArmor = value;
            }
        }
        public Staff Weapon 
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

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Druid(string name, int level)
            : this(name, level, DEFAULT_MANA_POINTS)

        {
        }
        public Druid(string name, int level, int manaPoints)
        :base (name,level,manaPoints)
        {
           
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODYARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }





        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        public void OneWithTheNature()
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

