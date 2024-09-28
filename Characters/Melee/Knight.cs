
namespace MagicDestroyers.Characters.Melees
{
    using COMPLETE_OOP_CODE.Characters.Enumerations;
    using COMPLETE_OOP_CODE.Characters.Melee;


    class Knight : Melee
    {
        private const string DEFAULT_NAME = "Knight";
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 10;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const Factions DEFAULT_FACTION = Factions.Melle;
        private readonly Hammer DEFAULT_WEAPON = new Hammer();
        private readonly ChainLink DEFAULT_BODYARMOR = new ChainLink();



        private ChainLink bodyArmor;
        private Hammer weapon;

       
        public ChainLink BodyArmor
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
        public Hammer Weapon 
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

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {
        }

        public Knight(string name, int level)
             : this(name, level, DEFAULT_ABILITY_POINTS)

        {
        }

        public Knight(string name, int level,int abilityPoints)
        :base(name,level,abilityPoints)
        {
            
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.BodyArmor = DEFAULT_BODYARMOR;
            this.Weapon = DEFAULT_WEAPON;
        }



        public void HolyBlow()
        {

        }
        public void PurifySoul()
        {

        }
        public void RighteousWings()
        {

        }

        public override void Attack()
        {
            this.HolyBlow();
        }

        public override void SpecialAttack()
        {
            this.PurifySoul();  
        }

        public override void Defend()
        {
            this.RighteousWings();
        }
    }
}

