using COMPLETE_OOP_CODE.Characters;
using MagicDestroyers.Characters.Melees;
using MagicDestroyers.Characters.Spellcasters;

public class Program
{
    static void Main()
    {

        //abilityPoints
        //faction string
        //healthPoints
        //level
        //name
        //bodyArmor ChainLink
        //weapon Axe
        //
        //armorPoints
        //damage

        // Warrior -> Strike, Execute, SkinHarden
        // Assasin -> Raze, Bleed, Survival
        // Knight -> HolyBlow, PurifySoul, RighteousWings
        // Mage -> ArcaneWrath, Firewall, Meditation
        // Necromancer ->ShadowRage, VampireTouch, BoneShield
        // Druid -> Moonfire, Starburst, OneWithTheNature

        // Sword -> Bloodthirst
        // Axe -> HackNSlash
        // Hammer -> Stun
        // Staff -> Empower


        //Default constructor
        //name,level constructor
        //name,level,abilitypoints constructor


        // InfoHandler 

        // Weapon -> Blunt -> Staff
        //                 -> Hammer

        //        -> Sharp -> Sword
        //                 -> Axe

        // Armor -> Mail -> Chainlink
        
        //       -> Leather -> LeatherVest 

        //       -> Cloth -> ClothRobe 

        // IAttack, IDeffence

        // 

        Character warrior = new Warrior();
        Character knight = new Knight();
        Character assasin = new Assasin();
        Character mage = new Mage();
        Character necromancer = new Necromancer();
        Character druid = new Druid();

        List<Character> meleeTeam = new List<Character>();
        List<Character> spellTeam = new List<Character>();

        meleeTeam.Add(warrior);
        meleeTeam.Add(knight);
        meleeTeam.Add(assasin);

        spellTeam.Add(mage);
        spellTeam.Add(necromancer);
        spellTeam.Add(druid);

        warrior.Attack(mage);



    }
}