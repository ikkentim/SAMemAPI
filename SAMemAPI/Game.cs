// SAMemAPI
// Copyright (C) 2014 Tim Potze
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR
// OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
// 
// For more information, please refer to <http://unlicense.org>

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SAMemAPI
{
    public class Game : MemoryObject
    {
        private Game(ProcessMemory memory) : base(memory)
        {
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

        /// <summary>
        /// </summary>
        /// <remarks>Same as <see cref="MenuShow" />.</remarks>
        [Address(0xB7CB49)]
        public bool FreezeGame { get; set; }

        /// <summary>
        /// </summary>
        /// <remarks>Same as <see cref="FreezeGame" />.</remarks>
        [Address(0xB7CB49)]
        public bool MenuShow { get; set; }

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
        public bool MapTarget { get; set; } /* DWORD ? */

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
        public bool IsHUDEnabledByAnOpcode0826 { get; set; } /* DWORD ? */

        /// <summary>
        /// </summary>
        /// <remarks>Characters appear in reversed order</remarks>
        [Address(0x969110, 30)]
        public string BufferOf30LastTypedChars { get; set; }

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
        public string StatsFileTitle { get; set; }

        [Address(0)]
        public Cheats Cheats { get; set; }


        [Address(0x96918C)]
        public int HasEverCheatedOrNot { get; set; }

        [Address(0xBAA472)]
        public int HasNowCheatedOrNot { get; set; }

        [Address(0xB79044)]
        public int CheatedCount { get; set; }


        [Address(0x96918C)]
        public bool CheatedState { get; set; } /* DWORD ? */

        //Note: If it's set to 1 you'll get a warning message when saving a game. But this byte doesn't get set if you use a cheat enabler.

        [Address(0xBA6784)]
        public int Brightness { get; set; }

        [Address(0xBA6792)]
        public byte Legend { get; set; }

        [Address(0xBA676C)]
        public RadarMode RadarMode { get; set; }

        [Address(0xBA6769)]
        public HudMode HudMode { get; set; }


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
        private CVehicle CurrentVehiclePointer { get; set; }

        public CVehicle CurrentVehicle
        {
            get { return Memory[0xBA18FC] == 0 ? null : CurrentVehiclePointer; }
        }

        public CWanted Wanted
        {
            get { return new CWanted(Memory[0xB7CD9C]); }
        }

        public CIgnored Ignored
        {
            get { return new CIgnored(Memory[0xB7CD9C]); }
        }

        public Pool<Handling> Handling
        {
            get { return new Pool<Handling>(Memory[0xC2B9DC], 224, 212); }
        }

        public Pool<Rocket> Rockets
        {
            get { return new Pool<Rocket>(Memory[0xC891A8], 36, 32); }
        }

        public Pool<CGarage> Garages
        {
            get { return new Pool<CGarage>(Memory[0x96C048], 0xD4, 50); }
        }

        public Pool<Checkpoint> Checkpoints
        {
            get { return new Pool<Checkpoint>(Memory[0xC7F158], 38, 2); }
        }

        [Address(0xBAB22C)]
        public byte HealthBarRedTextEnemyMarkerAnythingRedColor { get; set; }

        [Address(0xBAB230)]
        public byte MoneyFontColorVehicleEntryNameGreenTextAnythingGreenColor { get; set; }

        [Address(0xBAB238)]
        public byte WhiteTextColor { get; set; }

        [Address(0xBAB240)]
        public byte MainMenuTitleBorder { get; set; }

        [Address(0xBAB244)]
        public byte WantedLevelColor { get; set; }

        [Address(0xBAB24C)]
        public byte RadioStationTextColor { get; set; }

        [Address(0xBAB258)]
        public byte YellowBlipTextColor { get; set; }

        [Address(0xC81318)]
        public short WeatherLock { get; set; }

        [Address(0xC8131C)]
        public short UpcomingWeather { get; set; }

        [Address(0xC81320)]
        public short CurrentWeather { get; set; }

        public static IEnumerable<Game> Get()
        {
            return Process.GetProcessesByName("gta_sa").Select(p => new Game(p));
        }
    }
}