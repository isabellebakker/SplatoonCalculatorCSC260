using FinalProject.Final;
using Microsoft.VisualBasic.ApplicationServices;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        Headgear Headgear = new Headgear();
        Shirt Shirt = new Shirt();
        Shoes Shoes = new Shoes();
        Weapon Weapon = new Weapon();

        public MainForm()
        {
            InitializeComponent();
        }

        public void mainFormLoad(object sender, EventArgs e)
        {
            headgearMainDropdown.SelectedIndex = 0;
            headgearSub1Dropdown.SelectedIndex = 0;
            headgearSub2Dropdown.SelectedIndex = 0;
            headgearSub3Dropdown.SelectedIndex = 0;
            shirtMainDropdown.SelectedIndex = 0;
            shirtSub1Dropdown.SelectedIndex = 0;
            shirtSub2Dropdown.SelectedIndex = 0;
            shirtSub3Dropdown.SelectedIndex = 0;
            shoesMainDropdown.SelectedIndex = 0;
            shoesSub1Dropdown.SelectedIndex = 0;
            shoesSub2Dropdown.SelectedIndex = 0;
            shoesSub3Dropdown.SelectedIndex = 0;
            weaponDropdown.SelectedIndex = 0;

            Console.WriteLine(DateTime.Now + ": Initiated Program-- set default Dropdown values");
        }

        public void buttonCalc_Click(object sender, EventArgs e)
        {
            #region set object fields
            Headgear.Main = headgearMainDropdown.Items[headgearMainDropdown.SelectedIndex].ToString();
            Headgear.Sub1 = headgearSub1Dropdown.Items[headgearSub1Dropdown.SelectedIndex].ToString();
            Headgear.Sub2 = headgearSub2Dropdown.Items[headgearSub2Dropdown.SelectedIndex].ToString();
            Headgear.Sub3 = headgearSub3Dropdown.Items[headgearSub3Dropdown.SelectedIndex].ToString();

            Shirt.Main = shirtMainDropdown.Items[shirtMainDropdown.SelectedIndex].ToString();
            Shirt.Sub1 = shirtSub1Dropdown.Items[shirtSub1Dropdown.SelectedIndex].ToString();
            Shirt.Sub2 = shirtSub2Dropdown.Items[shirtSub2Dropdown.SelectedIndex].ToString();
            Shirt.Sub3 = shirtSub3Dropdown.Items[shirtSub3Dropdown.SelectedIndex].ToString();

            Shoes.Main = shoesMainDropdown.Items[shoesMainDropdown.SelectedIndex].ToString();
            Shoes.Sub1 = shoesSub1Dropdown.Items[shoesSub1Dropdown.SelectedIndex].ToString();
            Shoes.Sub2 = shoesSub2Dropdown.Items[shoesSub2Dropdown.SelectedIndex].ToString();
            Shoes.Sub3 = shoesSub3Dropdown.Items[shoesSub3Dropdown.SelectedIndex].ToString();

            string weaponName = weaponDropdown.Items[weaponDropdown.SelectedIndex].ToString();
            switch (weaponName)
            {
                case ".52 Gal":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splash Wall";
                    Weapon.SpecialPoints = 200;
                    break;
                case ".96 Gal":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Aerospray MG":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Fizzy Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Aerospray RG":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Ballpoint Splatling":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Fizzy Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Big Swig Roller":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splash Wall";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Bamboozler 14 Mk I":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Autobomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Blaster":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Autobomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Bloblobber":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 190;
                    break;
                case "Carbon Roller":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Autobomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Carbon Roller Deco":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Burst Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Clash Blaster":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Classic Squiffer":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Point Sensor";
                    Weapon.SpecialPoints = 190;
                    break;
                case "Custom Splattershot Jr.":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Torpedo";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Dapple Dualies":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Squid Beakon";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Dapple Dualies Nouveau":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Torpedo";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Dark Tetra Dualies":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Autobomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Dualie Squelchers":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Dynamo Roller":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 190;
                    break;
                case "E-liter 4K":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Ink Mine";
                    Weapon.SpecialPoints = 210;
                    break;
                case "Explosher":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Flingza Roller":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Ink Mine";
                    Weapon.SpecialPoints = 210;
                    break;
                case "Forge Splattershot Pro":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Suction Bomb";
                    Weapon.SpecialPoints = 210;
                    break;
                case "Glooga Dualies":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splash Wall";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Goo Tuber":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Torpedo";
                    Weapon.SpecialPoints = 200;
                    break;
                case "H-3 Nozzlenose":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Point Sensor";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Heavy Splatling":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Hydra Splatling":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Autobomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Inkbrush":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Inkbrush Nouveau":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Ink Mine";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Jet Squelcher":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Angle Shooter";
                    Weapon.SpecialPoints = 200;
                    break;
                case "L-3 Nozzlenose":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Curling Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Luna Blaster":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Luna Blaster Neo":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Fizzy Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Mini Splatling":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Burst Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "N-Zap '85":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Suction Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Nautilus 47":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Point Sensor";
                    Weapon.SpecialPoints = 190;
                    break;
                case "Octobrush":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Suction Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Range Blaster":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Suction Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Rapid Blaster":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Ink Mine";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Rapid Blaster Pro":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Toxic Mist";
                    Weapon.SpecialPoints = 180;
                    break;
                case "REEF-LUX 450":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Curling Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Slosher":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 210;
                    break;
                case "Slosher Deco":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Angle Shooter";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Sloshing Machine":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Fizzy Bomb";
                    Weapon.SpecialPoints = 210;
                    break;
                case "Snipewriter 5H":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splash-o-Matic":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Burst Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splat Brella":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Sprinkler";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splat Charger":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splat Dualies":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Suction Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splat Roller":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Curling Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Splatana Stamper":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Burst Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splatana Wiper":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Torpedo";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Splattershot":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Suction Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splattershot Jr.":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Splattershot Nova":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Point Sensor";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Splattershot Pro":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Angle Shooter";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Sploosh-o-Matic":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Curling Bomb";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Squeezer":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splash Wall";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Tenta Brella":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Squid Beakon";
                    Weapon.SpecialPoints = 190;
                    break;
                case "Tentatek Splattershot":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Splat Bomb";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Tri-Slosher":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Toxic Mist";
                    Weapon.SpecialPoints = 190;
                    break;
                case "Tri-Stringer":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Toxic Mist";
                    Weapon.SpecialPoints = 200;
                    break;
                case "Undercover Brella":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Ink Mine";
                    Weapon.SpecialPoints = 180;
                    break;
                case "Zink Mini Splatling":
                    Weapon.MainWeapon = weaponName;
                    Weapon.SubWeapon = "Toxic Mist";
                    Weapon.SpecialPoints = 180;
                    break;
                default:
                    break;
            }

            Console.WriteLine(DateTime.Now + ": Assigned Weapon object values");

            Weapon.getSubPercent(); //activate method to calculate the amount of points needed for its special
            #endregion

            #region getting data from user input

            int abInkSaverMain = 0;
            int abInkSaverSub = 0;
            int abInkRecoveryUp = 0;
            int abRunSpeedUp = 0;
            int abSwimSpeedUp = 0;
            int abSpecialChargeUp = 0;
            int abSpecialSaver = 0;
            int abSpecialPowerUp = 0;
            int abQuickRespawn = 0;
            int abQuickSuperJump = 0;
            int abSubPowerUp = 0;
            int abInkResistanceUp = 0;
            int abSubResistanceUp = 0;
            int abIntensifyAction = 0;
            bool abRespawnPunisher = false;

            switch (Headgear.Main)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 10;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 10;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 10;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 10;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 10;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 10;
                    break;
                case "Special Saver":
                    abSpecialSaver += 10;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 10;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 10;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 10;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 10;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 10;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 10;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 10;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Headgear object-- Main value");
            switch (Headgear.Sub1)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Headgear object-- Sub1 value");
            switch (Headgear.Sub2)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Headgear object-- Sub2 value");
            switch (Headgear.Sub3)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Headgear object-- Sub3 value");
            switch (Shirt.Main)
            {
                case "Ninja Squid":
                    abSwimSpeedUp -= 12;
                    break;
                case "Respawn Punisher":
                    abRespawnPunisher = true;
                    break;
                case "Ink Saver Main":
                    abInkSaverMain += 10;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 10;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 10;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 10;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 10;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 10;
                    break;
                case "Special Saver":
                    abSpecialSaver += 10;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 10;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 10;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 10;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 10;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 10;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 10;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 10;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shirt object-- Main value");
            switch (Shirt.Sub1)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shirt object-- Sub1 value");
            switch (Shirt.Sub2)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shirt object-- Sub2 value");
            switch (Shirt.Sub3)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shirt object-- Sub3 value");
            switch (Shoes.Main)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 10;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 10;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 10;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 10;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 10;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 10;
                    break;
                case "Special Saver":
                    abSpecialSaver += 10;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 10;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 10;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 10;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 10;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 10;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 10;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 10;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shoes object-- Main value");
            switch (Shoes.Sub1)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shoes object-- Sub1 value");
            switch (Shoes.Sub2)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shoes object-- Sub2 value");
            switch (Shoes.Sub3)
            {
                case "Ink Saver Main":
                    abInkSaverMain += 3;
                    break;
                case "Ink Saver Sub":
                    abInkSaverSub += 3;
                    break;
                case "Ink Recovery Up":
                    abInkRecoveryUp += 3;
                    break;
                case "Run Speed Up":
                    abRunSpeedUp += 3;
                    break;
                case "Swim Speed Up":
                    abSwimSpeedUp += 3;
                    break;
                case "Special Charge Up":
                    abSpecialChargeUp += 3;
                    break;
                case "Special Saver":
                    abSpecialSaver += 3;
                    break;
                case "Special Power Up":
                    abSpecialPowerUp += 3;
                    break;
                case "Quick Respawn":
                    abQuickRespawn += 3;
                    break;
                case "Quick Super Jump":
                    abQuickSuperJump += 3;
                    break;
                case "Sub Power Up":
                    abSubPowerUp += 3;
                    break;
                case "Ink Resistance Up":
                    abInkResistanceUp += 3;
                    break;
                case "Sub Resistance Up":
                    abSubResistanceUp += 3;
                    break;
                case "Intensify Action":
                    abIntensifyAction += 3;
                    break;
                default:
                    break;
            }
            Console.WriteLine(DateTime.Now + ": Assigned Shoes object-- Sub3 value");

            #endregion

            #region calculations

            abtbInkSaverMain.Text = "" + (100 - (abInkSaverMain * 1.3)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Ink Saver Main");
            abtbInkSaverSub.Text = "" + (Weapon.SubPercent - (abInkSaverSub * 0.6)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Ink Saver Sub");
            abtbInkRecoveryUp.Text = "" + (0 + (abInkRecoveryUp * 1.2)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Ink Recovery Up");
            abtbRunSpeedUp.Text = "" + (100 + (abRunSpeedUp * 1.66)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Run Speed Up");
            abtbSwimSpeedUp.Text = "" + (100 + (abSwimSpeedUp * 0.83)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Swim Speed Up");
            abtbSpecialChargeUp.Text = "" + (100 + abSpecialChargeUp) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Special Charge Up");
            abtbSpecialPowerUp.Text = "" + (100 + abSpecialPowerUp) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Special Power Up");
            abtbQuickSuperJump.Text = "" + (3.633 - (abQuickSuperJump * 0.17)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Quick Super Jump");
            abtbSubPowerUp.Text = "" + (100 + (abSubPowerUp * 2.66)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Sub Power Up");
            abtbInkResistanceUp.Text = "" + (0 + (abInkResistanceUp * 3.5)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Ink Resistance Up");
            abtbSubResistanceUp.Text = "" + (100 + (abSubResistanceUp * 1.64)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Sub Resistance Up");
            abtbIntensifyAction.Text = "" + (100 + (abIntensifyAction * 2)) + "%";
            Console.WriteLine(DateTime.Now + ": Finished Calculation-- Intensify Action");

            if (abRespawnPunisher == true)
            {
                abtbQuickRespawn.Text = "" + (9.67 - (abQuickRespawn * 0.133)) + " sec";
                Console.WriteLine(DateTime.Now + ": Finished Calculation-- Quick Respawn");
                abtbSpecialSaver.Text = "" + (72.5 - (abSpecialSaver * 0.92)) + "%";
                Console.WriteLine(DateTime.Now + ": Finished Calculation-- Special Saver");
            }
            else
            {
                abtbQuickRespawn.Text = "" + (8.5 - (abQuickRespawn * 0.133)) + " sec";
                Console.WriteLine(DateTime.Now + ": Finished Calculation-- Quick Respawn");
                abtbSpecialSaver.Text = "" + (50 - (abSpecialSaver * 0.92)) + "%";
                Console.WriteLine(DateTime.Now + ": Finished Calculation-- Special Saver");
            }

            #endregion
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void headgearSub3Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}