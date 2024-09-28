

namespace MagicDestroyers.Characters.Melees
{
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;
   

    class Assasin : Melee
    {
        private const string DEFAULT_NAME = "Assasin";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Melle;
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


        public Assasin()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }
        public Assasin(string name, int level)
            : this(name, level, DEFAULT_ABILITY_POINTS)

        {
        }

        public Assasin(string name, int level, int abilityPoints)
         :base(name,level,abilityPoints)
        {
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODYARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }



        public void Raze()
        {

        }
        public void Bleed()
        {

        }
        public void Survival()
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

