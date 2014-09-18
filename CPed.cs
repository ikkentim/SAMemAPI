namespace SAMemAPI
{
    public class CPed : MemoryObject
    {
        public CPed(ProcessMemory memory) : base(memory)
        {
        }

        [Address(0x14)]
        public PlayerPosition Position { get; set; }

        [Address(0x2F)]
        public byte LocationStatus { get; set; }

        /*
0 = outside
3 = inside a building*/

        [Address(0x42)]
        public byte Flags { get; set; }

        /*
         * Bit 1 = makes ped soft (ie. can move through walls and everything) (noclip in other words)
Bit 2 = freezes ped (ie. ped cannot walk)
Bit 3 = bullet-proof
Bit 4 = flame-proof
Bit 5 = collision-proof
Bit 6 = MP-proof (MP)
Bit 7 = ?
Bit 8 = explosion-proof
         */

        [Address(0xC0)]
        public int PointToNearestCar { get; set; }

        [Address(0x15C)]
        public int SomeAnimStates { get; set; }

        /*
         0 = landing from jump
61 = punching
102 = stopped
154 = sprint
205 = run*/

        [Address(0x46C)]
        public byte PlayerCheck { get; set; }

        /*
         * 0 = in air/water
1 = in car
2 = entering interior
3 = on foot
         */

        [Address(0x46D)]
        public int JumpState { get; set; }

        /*
         32 = landed/idle
34 = in air
36 = landing
         */

        [Address(0x46F)]
        public int CrouchState { get; set; }

        /*
         * 128 = stand
         * 132 = crouched
         */

        [Address(0x47C)]
        public int PointerToAnimStruct { get; set; }

        [Address(0x4DF)]
        public int CurrentAnimPlayState { get; set; }

        /*
         * 0 = nothing
61 = starting/stopping
62 = looping
         */

        [Address(0x504)]
        public short MuzzleFlashIntensity { get; set; }

        /*
         * 0 to 10000 = on
65536 = off
         */

        [Address(0x530)]
        public int State { get; set; }

        /*
         * 
0 = leaving a car, falling down from a bike or something like this
1 = normal case
50 = driving
55 = wasted
63 = busted
CPed +0x534 = Runningstate:
0 = while driving
1 = standing still
4 = start to run
6 = running
7 = running fast (sprinting) by pressing sprint key
         * */

        [Address(0x540)]
        public float Health { get; set; }

        [Address(0x544)]
        public float MaxHealth { get; set; }

        [Address(0x548)]
        public float Armor { get; set; }

        [Address(0x558)]
        public float CurrentRotationZAngle { get; set; }

        [Address(0x55C)]
        public float TargetRotationZAngle { get; set; }

        [Address(0x560)]
        public float RotationSpeedZAngle { get; set; }

        [Address(0x568)]
        public int CurrentCarYouAreInContactWith { get; set; }

        [Address(0x584)]
        public int CurrentEntityYouAreInContactWith { get; set; }

        [Address(0x58C)]
        public int LastOrCurrentDrivenCar { get; set; }

        [Address(0x598)]
        public byte PlayerLock { get; set; }

        [Address(0x5A0)]
        public byte StartOfWeaponData { get; set; }

        [Address(0x5D8)]
        public int PistolWeaponType { get; set; }

//22 - 9mm
//23 - silenced 9mm
//24 - desert eagle
        [Address(0x5DC)]
        public int PistolState { get; set; }

        [Address(0x5E0)]
        public int PistolAmmoInClip { get; set; }

        [Address(0x5E4)]
        public int PistolTotalAmmo { get; set; }

        [Address(0x5F4)]
        public int ShotgunWeaponType { get; set; }

//25 - shotgun
//26 - sawn-off shotgun
//27 - spas-12
        [Address(0x5F8)]
        public int ShotgunState { get; set; }

//1 - firing?
//2 - reloading
        [Address(0x5FC)]
        public int ShotgunAmmoInClip { get; set; }

        [Address(0x600)]
        public int ShotgunTotalAmmo { get; set; }

        [Address(0x718)]
        public byte CurrentWeaponSlot { get; set; }

        [Address(0x740)]
        public int CurrentWeaponID { get; set; }

        [Address(0x760)]
        public int WeaponYouWereDamagedWith { get; set; }

        [Address(0x764)]
        public CPed PointerToThePedThatDamagedYou { get; set; }

    }
}