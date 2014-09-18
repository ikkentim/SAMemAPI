using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//Thanks to : http://www.gtamodding.com/?title=Memory_Addresses_(SA)
using System.Security;

namespace SAMemAPI
{
    public class Game : MemoryObject
    {
        private Game(ProcessMemory memory) : base(memory)
        {
        }

        public static IEnumerable<Game> Get()
        {
            return Process.GetProcessesByName("gta_sa").Select(p => new Game(p));
        }

        [Address(0xA49D54)]
        public int TimerForDrivingFlyingMissions { get; set; }

        [Address(0xA51974)]
        public int TimerForBoatBikeMissions { get; set; }

        [Address(0xA51A3C)]
        public int TimerForBloodringRace { get; set; }

        [Address(0xB7CE50)]
        public int Money { get; set; }

        [Address(0xBAA420)]
        public int WantedLevel { get; set; }

        [Address(0x8CDEE4)]
        public int MaxWantedLevel { get; set; }

        [Address(0xB79038)]
        public int HowManyDaysHavePassedInGame { get; set; }

        [Address(0xB70153)]
        public byte CurrentHour { get; set; }

        [Address(0xB70152)]
        public byte CurrentMinute { get; set; }

        [Address(0x8D5104)]
        public byte CurrentBlurLevel { get; set; }

        [Address(0xB7014E)]
        public byte CurrentWeekday { get; set; }

        [Address(0x8CB7A5)]
        public byte CurrentRadiostationID { get; set; }

        [Address(0xB700F0)]
        public int CurrentCarIDNotForBikes { get; set; }

        [Address(0xB7CB49)]
        public byte GameFreezesLikeWhenInMenu { get; set; }

        [Address(0xB7CB49)]
        public byte GameFreezesLikeWhenInMenuEnum { get; set; }

        //0 = normal
        //1= everything stops

        [Address(0xB7CB49)]
        public byte MenuShowEnum { get; set; }

        //0 = leave
        //1 = show

        [Address(0x863984)]
        public float Gravity { get; set; }

        [Address(0xB610E0)]
        public int AGlobalTimerInMs { get; set; }

        [Address(0xB7CB84)]
        public int AGlobalTimerInMsExcludingMenu { get; set; }

        [Address(0xA5153C)]
        public int MissionTimerFromANumberTo0 { get; set; }

        [Address(0xB7CB64)]
        public float GameSpeedInPercent { get; set; }

        [Address(0xB70158)]
        public int TimerRelatedToWeatherAndTimeInMs { get; set; }

        [Address(0xB7015C)]
        public int DefinesHowManyMs { get; set; }

        [Address(0xB7CEE4)]
        public int IsInfiniteRun { get; set; }

        [Address(0xB7CEE6)]
        public int IsPlayerFireproof { get; set; }

        [Address(0x96C009)]
        public int IsPaynsprayFree { get; set; }

        [Address(0xA444A4)]
        public int IsRadarGreyedOut { get; set; }

        [Address(0x8D2530)]
        public float PedestrianDensityMultiplier { get; set; }

        [Address(0x8A5B20)]
        public float VehicleDensityMultiplier { get; set; }

        [Address(0xB6F065)]
        public int CutsceneWidescreen { get; set; }

        [Address(0xA4A948)]
        public int LowriderChallengeScore { get; set; }

        [Address(0xA4EC20)]
        public int DancingMinigameScore { get; set; }

        [Address(0xB790B8)]
        public byte PhotographsTakenNumber { get; set; }

        [Address(0xA9AD74)]
        public byte TagsNumber { get; set; }

        [Address(0xB791E4)]
        public byte HorseshoesNumber { get; set; }

        [Address(0xB791EC)]
        public byte OystersNumber { get; set; }

        //Note: For those number above if you change it to maximum amount they appear to pop a message and gives a bonus like weapons in cj savehouses.

        [Address(0x716642)]
        public float ChangeSolidClouds { get; set; }

        [Address(0x716655)]
        public float DisableSolidClouds { get; set; }

        //Note: Both values default to 200. If you change one of them to 100,000 you get very few clouds, a much nicer effect. If you change both of them to 100,000 you never get the clouds.

        [Address(0xB79078)]
        public byte PeopleDroppedOffInTaxiStats { get; set; }

        [Address(0xA49C30)]
        public byte PeopleDroppedOffInTaxiRewards { get; set; }

        [Address(0xB79040)]
        public byte SafehouseVisitsNumber { get; set; }

        [Address(0xA49EFC)]
        public int DeniseProgress { get; set; }

        [Address(0xA49F00)]
        public int MichelleProgress { get; set; }

        [Address(0xA49F04)]
        public int HelenaProgress { get; set; }

        [Address(0xA49F08)]
        public int BarbaraProgress { get; set; }

        [Address(0xA49F0C)]
        public int KatieProgress { get; set; }

        [Address(0xA49F10)]
        public int MillieProgress { get; set; }

        //Note: These above six addresses are within the scm block, and valid only for original scm. setting a value to 100 (ie. 100 pct) gives you all gifts of that GF (ie. car keys, wardrobe etc.).

        [Address(0xB79108)]
        public int NumberOfGirlsDated { get; set; }

        [Address(0xB79100)]
        public int CurrentNumberOfGirlfriends { get; set; }

        [Address(0xB79104)]
        public int NumberOfDisastrousDates { get; set; }

        [Address(0xB79110)]
        public int NumberOfSuccessfulDates { get; set; }

        [Address(0xB79060)]
        public int UniqueJumpsFoundNumber { get; set; }

        [Address(0xB79064)]
        public int UniqueJumpsDoneNumber { get; set; }

        [Address(0xBA6774)]
        public int MapTargetEnum { get; set; }

        //0 = disabled
        //1 = enabled

        [Address(0x86329C)]
        public int ListOfValidCommandNames { get; set; }

        [Address(0xC17054)]
        public int APointerToTheMainGameWindowHandle { get; set; }

        [Address(0xBA3798)]
        public int BeginningOfZoneInfoStructure { get; set; }

        [Address(0xBA1DF0)]
        public int BeginningOfZonePopStructure { get; set; }

        [Address(0xA94B68)]
        public int ArrayOfPointersToRwTextureCorrespondingToOpcode038F { get; set; }

        [Address(0xA444A0)]
        public int IsHUDEnabledByAnOpcode0826Enum { get; set; }

        //0 = disabled
        //1 = enabled

        [Address(0x969110, 30)]
        public string BufferOf30LastTypedCharsEarlierTypedCharsAreOnNextByt { get; set; }

        /*
         * DirectX / Rendering
         * 0xC97C1C - A copy of the window handle that is used to initialize the DirectX device.
         * 0xC97C20 - Pointer to IDirect3D9 interface.
         * 0xC97C28 - Pointer to IDirect3DDevice9 interface.
         * 0xC9C040 - Global instance of D3DPRESENT_PARAMETERS structure.
         */

        [Address(0xB793D4)]
        public float FatStat { get; set; }

        [Address(0xB793D8)]
        public float StaminaStat { get; set; }

        [Address(0xB793DC)]
        public float MuscleStat { get; set; }

        [Address(0xB793E0)]
        public float HealthStat { get; set; }

        [Address(0xB793E4)]
        public float SexAppealStat { get; set; }

        [Address(0xB79496)]
        public float PistolStat { get; set; }

        [Address(0xB79498)]
        public float SilencedPistolStat { get; set; }

        [Address(0xB7949C)]
        public float DesertEagleStat { get; set; }

        [Address(0xB794A0)]
        public float ShotgunStat { get; set; }

        [Address(0xB794A4)]
        public float SawnOffShotgunStat { get; set; }

        [Address(0xB794A8)]
        public float CombatShotgunStat { get; set; }

        [Address(0xB794AC)]
        public float MachinePistolStat { get; set; }

        [Address(0xB794B0)]
        public float SMGStat { get; set; }

        [Address(0xB794B4)]
        public float AK47Stat { get; set; }

        [Address(0xB794B8)]
        public float M4Sta { get; set; }

        [Address(0x8663A0, 64)]
        public string StatsFileName { get; set; }

        [Address(0x86636C, 64)]
        public int StatsFileTitle { get; set; }

        //CHEATS START

        [Address(0x969130)]
        public int WeaponSet1 { get; set; }

        [Address(0x969131)]
        public int WeaponSet2 { get; set; }

        [Address(0x969132)]
        public int WeaponSet3 { get; set; }

        [Address(0x969133)]
        public int HealthArmor250K { get; set; }

        [Address(0x969134)]
        public int IncreaseWantedLevel2Stars { get; set; }

        [Address(0x969135)]
        public int ClearWantedLevel { get; set; }

        [Address(0x969136)]
        public int SunnyWeather { get; set; }

        [Address(0x969137)]
        public int VerySunnyWeather { get; set; }

        [Address(0x969138)]
        public int OvercastWeather { get; set; }

        [Address(0x969139)]
        public int RainyWeather { get; set; }

        [Address(0x96913A)]
        public int FoggyWeather { get; set; }

        [Address(0x96913B)]
        public int FasterClock { get; set; }

        [Address(0x96913C)]
        public int FasterGameplay { get; set; }

        [Address(0x96913D)]
        public int SlowerGameplay { get; set; }

        [Address(0x96913E)]
        public int PedsAttackEachOtherWithGolfclub { get; set; }

        [Address(0x96913F)]
        public int HaveBountyOnHead { get; set; }

        [Address(0x969140)]
        public int EveryoneIsArmed { get; set; }

        [Address(0x969141)]
        public int SpawnRhino { get; set; }

        [Address(0x969142)]
        public int SpawnBloodringBanger { get; set; }

        [Address(0x969143)]
        public int SpawnRancher { get; set; }

        [Address(0x969144)]
        public int SpawnRacecarA { get; set; }

        [Address(0x969145)]
        public int SpawnRacecarB { get; set; }

        [Address(0x969146)]
        public int SpawnRomero { get; set; }

        [Address(0x969147)]
        public int SpawnStretch { get; set; }

        [Address(0x96914A)]
        public int BlowUpAllCars { get; set; }

        [Address(0x96914B)]
        public int WheelsOnly { get; set; }

        [Address(0x96914C)]
        public int PerfectHandling { get; set; }

        [Address(0x96914D)]
        public int Suicide { get; set; }

        [Address(0x96914E)]
        public int AllGreenLights { get; set; }

        [Address(0x96914F)]
        public int AggressiveDrivers { get; set; }

        [Address(0x969150)]
        public int PinkTraffic { get; set; }

        [Address(0x969151)]
        public int BlackTraffic { get; set; }

        [Address(0x969152)]
        public int CarsCanDriveOnWater { get; set; }

        [Address(0x969153)]
        public int BoatsCanFly { get; set; }

        [Address(0x969154)]
        public int CJIsFat { get; set; }

        [Address(0x969155)]
        public int MaxMuscle { get; set; }

        [Address(0x969156)]
        public int CJIsSkinny { get; set; }

        [Address(0x969157)]
        public int ElvisEverywhere { get; set; }

        [Address(0x969158)]
        public int PedsAttackWithRockets { get; set; }

        [Address(0x969159)]
        public int BeachTheme { get; set; }

        [Address(0x96915A)]
        public int GangMembersEverywhere { get; set; }

        [Address(0x96915B)]
        public int GangsControlTheStreets { get; set; }

        [Address(0x96915C)]
        public int NinjaTheme { get; set; }

        [Address(0x96915D)]
        public int SlutMagnet { get; set; }

        [Address(0x96915E)]
        public int TrafficIsCheapCars { get; set; }

        [Address(0x96915F)]
        public int TrafficIsFastCars { get; set; }

        [Address(0x969160)]
        public int CarsCanFly { get; set; }

        [Address(0x969161)]
        public int HugeBunnyHop { get; set; }

        [Address(0x969162)]
        public int SpawnHydra { get; set; }

        [Address(0x969163)]
        public int SpawnVortexHovercraft { get; set; }

        [Address(0x969164)]
        public int TankModeSmashNBoom { get; set; }

        [Address(0x969165)]
        public int AllCarsHaveNitro { get; set; }

        [Address(0x969166)]
        public int CarsFloatAwayWhenHit { get; set; }

        [Address(0x969167)]
        public int AlwaysMidnight { get; set; }

        [Address(0x969168)]
        public int StopGameClockOrangeSky { get; set; }

        [Address(0x969169)]
        public int Thunderstorm { get; set; }

        [Address(0x96916A)]
        public int Sandstorm { get; set; }

        [Address(0x96916C)]
        public int MegaJump { get; set; }

        [Address(0x96916D)]
        public int InfiniteHealth { get; set; }

        [Address(0x96916E)]
        public int InfiniteOxygen { get; set; }

        [Address(0x96916F)]
        public int GetParachute { get; set; }

        [Address(0x969170)]
        public int GetJetpack { get; set; }

        [Address(0x969171)]
        public int NeverWanted { get; set; }

        [Address(0x969172)]
        public int SixStarWantedLevel { get; set; }

        [Address(0x969173)]
        public int MegaPunch { get; set; }

        [Address(0x969174)]
        public int NeverGetHungry { get; set; }

        [Address(0x969175)]
        public int PedsRiot { get; set; }

        [Address(0x969176)]
        public int FunhouseTheme { get; set; }

        [Address(0x969177)]
        public int SlowerGameplay2 { get; set; }

        [Address(0x969178)]
        public int InfiniteAmmoNoReload { get; set; }

        [Address(0x969179)]
        public int FullWeaponAimingWhileDriving { get; set; }

        [Address(0x96917A)]
        public int DecreasedTraffic { get; set; }

        [Address(0x96917B)]
        public int TrafficIsCountryVehicles { get; set; }

        [Address(0x96917C)]
        public int RecruitAnyone9MM { get; set; }

        [Address(0x96917D)]
        public int CountryTheme { get; set; }

        [Address(0x96917E)]
        public int RecruitAnyoneRockets { get; set; }

        [Address(0x96917F)]
        public int MaxRespect { get; set; }

        [Address(0x969180)]
        public int MaxSexAppeal { get; set; }

        [Address(0x969181)]
        public int MaxStamina { get; set; }

        [Address(0x969183)]
        public int HitmanInAllWeapons { get; set; }

        [Address(0x969184)]
        public int SpawnHunter { get; set; }

        [Address(0x969185)]
        public int SpawnQuad { get; set; }

        [Address(0x969186)]
        public int SpawnTankerTruck { get; set; }

        [Address(0x969187)]
        public int SpawnDozer { get; set; }

        [Address(0x969188)]
        public int SpawnStuntPlane { get; set; }

        [Address(0x969189)]
        public int SpawnMonste { get; set; }

        //END CHEATS

        [Address(0x96918C)]
        public int HasEverCheatedOrNot { get; set; }

        [Address(0xBAA472)]
        public int HasNowCheatedOrNot { get; set; }

        [Address(0xB79044)]
        public int CheatedCount { get; set; }


        [Address(0x96918C)]
        public int CheatedStateEnum { get; set; }

//0 = disabled
//1 = enabled
//Note: If it's set to 1 you'll get a warning message when saving a game. But this byte doesn't get set if you use a cheat enabler.

        [Address(0xBA6784)]
        public int Brightness { get; set; }

        [Address(0xBA6792)]
        public byte Legend { get; set; }

        [Address(0xBA676C)]
        public byte RadarModeEnum { get; set; }

/*0 = maps & blips
1 = blips
2 = off*/

        [Address(0xBA6769)]
        public int HudMode { get; set; }

/*0 = off
1 = on*/

        [Address(0xBA678C)]
        public byte Subtitles { get; set; }

        [Address(0xBA6830)]
        public byte StoreGalleryPhotos { get; set; }

        [Address(0xBA6788)]
        public float DrawDistance { get; set; }

        [Address(0xBA6794)]
        public byte FrameLimiter { get; set; }

        [Address(0xBA6793)]
        public byte Widescreen { get; set; }

        [Address(0xA9AE54)]
        public byte VisualFXQuality { get; set; }

        [Address(0xBA680C)]
        public byte MipMapping { get; set; }

        [Address(0xBA6814)]
        public byte Antialiasing { get; set; }

/*1 = 0x (off)
2 = 1x
3 = 2x
4 = 3x*/

        [Address(0xBA6820)]
        public byte ResolutionValues { get; set; }

/*11 = 640x480
12 = 800x400
13 = 800x600
15 = 1024x768
(Depends on the graphic driver/hardware.)*/

        [Address(0xBA6798)]
        public byte RadioVolume { get; set; }

        [Address(0xBA6797)]
        public byte SFXVolume { get; set; }

        [Address(0xBA6799)]
        public byte RadioEqualizer { get; set; }

        [Address(0xBA6795)]
        public byte RadioAutoTune { get; set; }

        [Address(0xBA67F8)]
        public byte UsertrackPlayModeValuesEnum { get; set; }

//0 = radio
//1 = random
        [Address(0xBA680D)]
        public byte UsertrackAutomaticMediaScan { get; set; }

        [Address(0xBA679A)]
        public byte RadioStationIDValuesEnum { get; set; }

/*
1 to 12 (see below for station names according to ID)
1 = "Playback FM"
2 = "K Rose"
3 = "K-DST"
4 = "Bounce FM"
5 = "SF-UR"
6 = "Radio Los Santos"
7 = "Radio X"
8 = "CSR 103.9"
9 = "K-JAH West"
10 = "Master Sounds 98.3"
11 = "WCTR Talk Radio"
12 = "User Track Player"
13 = "Radio Off"
 
AlienX: Seems that the Radio Station ID is just a menu identifier, this does not actually change the radio station while in-game!

Another note... The opcode for switching players radio stations does not work in line with the station ID's, i have yet to figure out what station ID's are for the SCM code - Dont try to use the above ID's for the SCM Operation Code, it just wont work

Thanks to AlienX For the station names and ID's
 */

        [Address(0xBA6818)]
        public byte ControllerConfigurationValues { get; set; }

        //0 = mouse + keys
        //1 = joypad
        [Address(0xB6EC1C)]
        public float MouseSensitivity { get; set; }

        [Address(0xC1CC02)]
        public byte SteerWithMouse { get; set; }

        [Address(0xC1CC03)]
        public byte FlyWithMouse { get; set; }

        [Address(0xB6EC2E)]
        public int REALAimingModeOffsetNotMenu { get; set; }

        //0 = joypad
        //1 = mouse + keys

        [Address(0xB6F5F0)]
        public CPed PlayerPointer { get; set; }

        //[Address(0xB7CD98)]
        //public int PlayerPointerDirectOffsetToThePedPoolStart { get; set; }

        [Address(0xB74498)]
        public int CPedsMaximumNumber { get; set; }

        [Address(0xB74490)]
        public int ContainsAPointerToAMainStructBelow { get; set; }

        [Address(0xB74490)]
        public CPedPool PedPool { get; set; }

        [Address(0xB74494)]
        public CVehiclePool VehiclePool { get; set; }

        /*
         0x969084 - First vehicle you got into
                Note: To get the next vehicle, so the second one, you need to add +0x4 as many times you want. They are 0 if you haven't entered a first/second/third/etc car yet.
         */

        [Address(0xBA18FC)]
        private  CVehicle CurrentVehiclePointer { get; set; }

        public CVehicle CurrentVehicle
        {
            get { return Memory[0xBA18FC] == 0 ? null : CurrentVehiclePointer; }
        }

        //TODO: Camera and down still to be done (from wiki)
    }
}