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

namespace SAMemAPI
{
    public class Cheats : MemoryObject
    {
        public Cheats(ProcessMemory memory) : base(memory)
        {
        }

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
        public int SpawnMonster { get; set; }
    }
}