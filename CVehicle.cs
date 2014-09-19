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
    public class CVehicle : MemoryObject
    {
        public CVehicle(ProcessMemory memory) : base(memory)
        {
        }

        [Address(20)]
        public VehiclePosition Position { get; set; }

        [Address(66)]
        public byte Flags { get; set; }

        /*
         * Add these values, and write the sum into +66
1 = n/a
2 = n/a
4 = bullet-proof
8 = fire-proof
16 = damage-proof (from collisions etc)
32 = n/a
64 = n/a
128 = explosion-proof
         */

        [Address(68)]
        public float XSpeed { get; set; }

        [Address(72)]
        public float YSpeed { get; set; }

        [Address(76)]
        public float ZSpeed { get; set; }

        [Address(80)]
        public float XSpin { get; set; }

        [Address(84)]
        public float YSpin { get; set; }

        [Address(88)]
        public float ZSpi { get; set; }

        //Note: Do not get confused about the Spin Angles, these are NOT rotations but the angles of how fast your vehicle is turning in the given axis direction...

        [Address(140)]
        public float MassFromHandlingcfg { get; set; }

        [Address(144)]
        public float TurnMassFromHandlingcfg { get; set; }

        [Address(148)]
        public float GripDivider { get; set; }

/*1.0 = 1 x gGrip
10.1 = 10 x gGrip
100.0 = g / 100Grip*/

        [Address(152)]
        public float MassToGripMultiplier /*.Ie.GForceWhenFlying/duringSuspension/driving*/ { get; set; }

        [Address(160)]
        public float NormalizedGripLevel { get; set; }

        [Address(164)]
        public float CoMX { get; set; }

        [Address(168)]
        public float CoMY { get; set; }

        [Address(172)]
        public float CoMZ { get; set; }

        [Address(216)]
        public float IncreasesWhenCollisionOccurs { get; set; }

        [Address(1064)]
        public byte EngineState { get; set; }

//0 = stalled
//16 = ok
        [Address(1069)]
        public byte SirenOnOff { get; set; }

        [Address(1076)]
        public byte BodyColor { get; set; }

        [Address(1077)]
        public byte StripeColor { get; set; }

        [Address(1078)]
        public byte BodyColor2 { get; set; }

        [Address(1079)]
        public byte StripeColor2 { get; set; }

        [Address(1080)]
        public int ModdingDataAsInGarageInfo1 { get; set; }

        [Address(1084)]
        public int ModdingDataAsInGarageInfo2 { get; set; }

        [Address(1088)]
        public int ModdingDataAsInGarageInfo3 { get; set; }

        [Address(1092)]
        public int ModdingDataAsInGarageInfo4 { get; set; }

        [Address(1096)]
        public int ModdingDataAsInGarageInfo5 { get; set; }

        [Address(1100)]
        public int ModdingDataAsInGarageInfo6 { get; set; }

        [Address(1104)]
        public int ModdingDataAsInGarageInfo7 { get; set; }

        [Address(1108)]
        public int ModdingDataAsInGarageInfo8 { get; set; }

        [Address(1112)]
        public float CarWheelSizeFromVehicleIdeFile { get; set; }

        [Address(1116)]
        public int TimeLeftForCarAlarmToSoundInMs { get; set; }

        [Address(1120)]
        public int PointerToDriver { get; set; }

        [Address(1124)]
        public int PointerToPassenger1 { get; set; }

        [Address(1128)]
        public int PointerToPassenger2 { get; set; }

        [Address(1132)]
        public int PointerToPassenger3 { get; set; }

        [Address(1136)]
        public int PointerToPassenger4 { get; set; }

        [Address(1140)]
        public int PointerToPassenger5 { get; set; }

        [Address(1144)]
        public int PointerToPassenger6 { get; set; }

        [Address(1148)]
        public int PointerToPassenger7 { get; set; }

        [Address(1152)]
        public int PointerToPassenger8 { get; set; }

        [Address(1156)]
        public int PointerToPassenger9 { get; set; }

        [Address(1172)]
        public float SteerAngle1 { get; set; }

        [Address(1176)]
        public float SteerAngle2 { get; set; }

        [Address(1180)]
        public float GasPedal { get; set; }

        [Address(1184)]
        public float BrakePedal { get; set; }

        [Address(1192)]
        public byte PlacesACarBomb { get; set; }

/*0 = No bomb.
1 = Car has a time bomb, but it's not armed.
2 = Car has an on-ignition bomb, but it's not armed.
3 = Set remotely, perhaps (?).
4 = Time bomb is armed.
5 = On-ignition bomb is armed.
Note: You can set the above values to 0 or 1 to give the car a bomb. Some other flags get set when you arm the bomb. So if you set this value to 4 or 5, or actually arm the bomb through normal gameplay, it does not help if you try to change this value back.
*/

        [Address(1195)]
        public int TheNumberOfPedsTryingToHideBehindThisCar { get; set; }

        [Address(0x8A4)]
        public float NitroCount { get; set; }

//1.0 Nitro filled (in case of number of NOS is equal to 0 it'll mean Empty)
//-1.0 Nitro discharged
        [Address(0x48A)]
        public int NumberOfAvailableNOSInTheVehicle { get; set; }

//1~10 Have Available NOS
//0 No Have Available NOS
        [Address(1200)]
        public float BodyDirtLevel { get; set; }

//0.0 = fully clean
//15.0 = maximum dirt visible
        [Address(1216)]
        public float HealthCarDamageLeft { get; set; }

//<250.0 = on fire
//1000.0 = undamaged
        [Address(1272)]
        public int CarDoorLockedState { get; set; }

//1 = open
//2 = locked
        [Address(1300)]
        public int AlternateSiren { get; set; }

//0 = off
//1 = on
//Note: Automatically gets reset back to 0. To prevent this just NOP 0x6E0A3B (6 bytes).

        [Address(1412)]
        public int HeadlightsSwitch { get; set; }

//0 = off
//1 = on
//Note: Same case as above, gets automatically reset - NOP 0x6E1EDE (6 bytes).

        [Address(1424)]
        public byte CarType { get; set; }

/*0 = car/plane
5 = boat
6 = train
9 = bike*/

        [Address(1444)]
        public float TrainSpeed { get; set; }

/*-0.1 = is forward
0.1 = is reverse*/

        [Address(1445)]
        public byte CarTireLeftFrontStatus { get; set; }

/*0 = ok
1 = flat
2 = Used by planes when landing gear is up*/

        [Address(1446)]
        public byte CarTireLeftRearStatus { get; set; }

/*0 = ok
1 = flat
2 = Used by planes when landing gear is up*/

        [Address(1447)]
        public byte CarTireRightFrontStatus { get; set; }

/*0 = ok
1 = flat
2 = Used by planes when landing gear is up*/

        [Address(1448)]
        public byte CarTireRightRearStatus { get; set; }

/*0 = ok
1 = flat
2 = Used by planes when landing gear is up*/

        [Address(1628)]
        public byte BikeTireFrontStatusFront { get; set; }

/*0 = ok
1 = flat*/

        [Address(1629)]
        public byte BikeTireRearStatusRear { get; set; }

/*0 = ok
1 = flat*/

        [Address(1630)]
        public byte BicycleTireStatusFront { get; set; }

/*0 = ok
1 = shot*/

        [Address(1631)]
        public byte BicycleTireStatusRear { get; set; }

/*0 = ok
1 = shot*/
//Note: You cannot actually shoot the wheels of bmx. If you set the value 1 at above two offsets, it rides as if the wheels were shot. They probably not work.

        [Address(1736)]
        public byte IsTheBikeIdentifier { get; set; }

//Note: Gets set to 1 if this vehicle is a bike (or bmx).

        [Address(1824)]
        public float FrontLeftSuspensionHeight { get; set; }

        [Address(1828)]
        public float RearLeftSuspensionHeight { get; set; }

        [Address(1832)]
        public float FrontRearSuspensionHeight { get; set; }

        [Address(1836)]
        public float RearRearSuspensionHeight { get; set; }

//Note: There is also a copy of the suspension values at -0x10, but these are 'smoother'. They range from 0 to 1 (1 = fully extended/airborne, 0 = fully compressed).

        [Address(2020)]
        public float FrontLeftSuspensionHeight2 { get; set; }

        [Address(2024)]
        public float RearLeftSuspensionHeight2 { get; set; }

        [Address(2028)]
        public float FrontRightSuspensionHeight { get; set; }

        [Address(2032)]
        public float RearRightSuspensionHeight { get; set; }

        [Address(2156)]
        public short CurrentLoadOfVehicle /*,WorksForVehiclesSuchAsDumper,Packer,Dozer,ForkliftAndSoOn.*/ { get; set; }

        [Address(2160)]
        public short LastLoadValueOfVehicle
            /*.UsedToDetectWhetherVehicleShouldHaveSoundOfRaising/loweringALoad.AfterDetectingItGetsValueOfCarStruct+2156Below.*/
        { get; set; }

        [Address(2276)]
        public float BurnTimerInMs { get; set; }


        /*
         * ????
         * Let's say, the Car Position of this given car starts at 0xC5F5DB4:

+0 = X Level to the ground
+4 = Y Level to the ground
+8 = Z Level to the ground
+16 = X Where am I looking
+20 = Y Where am I looking
+24 = Z Where am I looking
+32 = Dyn flight data
+36 = Dyn flight data
+40 = Dyn flight data
+48 = CarPosX
+52 = CarPosY
+56 = CarPosZ
Following offsets are Floats, as positions of doors and other car parts that gets detached by damage. We need to recalculate and set their locations if we warp a car from one location to another. Otherwise the car spins uncontrollably:

+1828 = Detachables1 Pos X
+1832 = Detachables1 Pos Y
+1836 = Detachables1 Pos Z
+1872 = Detachables2 Pos X
+1876 = Detachables2 Pos Y
+1880 = Detachables2 Pos Z
+1916 = Detachables3 Pos X
+1920 = Detachables3 Pos Y
+1924 = Detachables3 Pos Z
+1960 = Detachables4 Pos X
+1964 = Detachables4 Pos Y
+1968 = Detachables4 Pos Z
The locations of the detachable objects are different for cars and bikes. This is merely because bike object is actually smaller than the car object. The car object is used for all vehicles (including heli) but the bikes.

Offsets for Detachables:

+1532 = BikeDetachPosAdr(0)
+1632 = BikeDetachPosAdr(1)
+1676 = BikeDetachPosAdr(2)
+1720 = BikeDetachPosAdr(3)
+1764 = BikeDetachPosAdr(4)
+1828 = CarDetachPosAdr(0)
+1872 = CarDetachPosAdr(1)
+1916 = CarDetachPosAdr(2)
+1960 = CarDetachPosAdr(3)
The trailer of the tanker is handled the same way as the vehicles. Its pointer gets set at offset:

+1224
         * 
         */
    }
}