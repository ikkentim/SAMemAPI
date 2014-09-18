using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SAMemAPI
{
    public class CVehicle : MemoryObject
    {
        public CVehicle(ProcessMemory memory) : base(memory)
        {
        }

        [Address(20)]
        public VehiclePosition Position { get; set; }

        /*
         +34 = [word] Vehicle ID from vehicles.ide
+66 = [byte] Is the BP/EP/DP/DP (Special Flags) status of the car as follows:
Add these values, and write the sum into +66
1 = n/a
2 = n/a
4 = bullet-proof
8 = fire-proof
16 = damage-proof (from collisions etc)
32 = n/a
64 = n/a
128 = explosion-proof
+68 = [float] X (East-West) speed
+72 = [float] Y (North-South) speed
+76 = [float] Z (Up-Down) speed
+80 = [float] X (NS) Spin
+84 = [float] Y (EW) Spin
+88 = [float] Z (NW) Spin
Note: Do not get confused about the Spin Angles, these are NOT rotations but the angles of how fast your vehicle is turning in the given axis direction...

(Car addresses continued:)

+140 = [float] Mass (kg) from handling.cfg
+144 = [float] Turn Mass from handling.cfg
+148 = [float] Grip Divider:
1.0 = 1 x gGrip
10.1 = 10 x gGrip
100.0 = g / 100Grip
+152 = [float] Mass-to-Grip Multiplier. Ie. G Force when flying/during suspension/driving (acceleration towards ground)
+160 = [float] Normalized Grip Level
+164 = [float] CoM X
+168 = [float] CoM Y
+172 = [float] CoM Z
+216 = [float] Increases when collision occurs
+1064 = [byte] Engine State (whether the engine is running or stalled):
0 = stalled
16 = ok
+1069 = [byte] Siren on/off
+1076 = [byte] Body Color (as in carcolors.dat, black being the 0)
+1077 = [byte] Stripe Color (as in carcolors.dat, black being the 0)
+1078 = [byte] Body Color #2
+1079 = [byte] Stripe Color #2
+1080 = [dword] modding data as in garage info (Not working?)
+1084 = [dword] modding data as in garage info (Not working?)
+1088 = [dword] modding data as in garage info (Not working?)
+1092 = [dword] modding data as in garage info (Not working?)
+1096 = [dword] modding data as in garage info (Not working?)
+1100 = [dword] modding data as in garage info (Not working?)
+1104 = [dword] modding data as in garage info (Not working?)
+1108 = [dword] modding data as in garage info (Not working?)
+1112 = [float] Car Wheel Size from vehicle.ide
+1116 = [dword] Time left for car alarm to sound in ms
+1120 = [dword] Pointer to driver
+1124 = [dword] Pointer to passenger 1 (Front-right seat)
+1128 = [dword] Pointer to passenger 2 (Rear-left seat)
+1132 = [dword] Pointer to passenger 3 (Rear-right seat)
+1136 = [dword] Pointer to passenger 4 (Used for buses)
+1140 = [dword] Pointer to passenger 5 (Used for buses)
+1144 = [dword] Pointer to passenger 6 (Used for buses)
+1148 = [dword] Pointer to passenger 7 (Used for buses)
+1152 = [dword] Pointer to passenger 8 (Used for buses)
+1156 = [dword] Pointer to passenger 9 (Used for buses)
+1172 = [float] Steer angle 1
+1176 = [float] Steer angle 2
+1180 = [float] Gas pedal
+1184 = [float] Brake pedal
+1192 = [byte] Places a car-bomb:
0 = No bomb.
1 = Car has a time bomb, but it's not armed.
2 = Car has an on-ignition bomb, but it's not armed.
3 = Set remotely, perhaps (?).
4 = Time bomb is armed.
5 = On-ignition bomb is armed.
Note: You can set the above values to 0 or 1 to give the car a bomb. Some other flags get set when you arm the bomb. So if you set this value to 4 or 5, or actually arm the bomb through normal gameplay, it does not help if you try to change this value back.

+1195 = [BYTE] The number of peds (usually cops) trying to hide behind this car.
+0x8A4 = [float] Nitro Count
1.0 Nitro filled (in case of number of NOS is equal to 0 it'll mean Empty)
-1.0 Nitro discharged
+0x48A = [BYTE] Number of available NOS in the vehicle
1~10 Have Available NOS
0 No Have Available NOS
+1200 = [float] Body dirt level:
0.0 = fully clean
15.0 = maximum dirt visible
+1216 = [float] Health/Car Damage Left:
<250.0 = on fire
1000.0 = undamaged
+1272 = [dword] Car Door Locked State:
1 = open
2 = locked
+1300 = [dword] Alternate siren (honking):
0 = off
1 = on
Note: Automatically gets reset back to 0. To prevent this just NOP 0x6E0A3B (6 bytes).

+1412 = [dword] Headlights switch:
0 = off
1 = on
Note: Same case as above, gets automatically reset - NOP 0x6E1EDE (6 bytes).

+1424 = [byte] Car type:
0 = car/plane
5 = boat
6 = train
9 = bike
+1444 = [float] Train speed:
-0.1 = is forward
0.1 = is reverse
+1445 = [byte] Car Tire (Left-Front) Status:
0 = ok
1 = flat
2 = Used by planes when landing gear is up
+1446 = [byte] Car Tire (Left-Rear) Status:
0 = ok
1 = flat
2 = Used by planes when landing gear is up
+1447 = [byte] Car Tire (Right-Front) Status:
0 = ok
1 = flat
2 = Used by planes when landing gear is up
+1448 = [byte] Car Tire (Right-Rear) Status:
0 = ok
1 = flat
2 = Used by planes when landing gear is up
+1628 = [byte] Bike Tire (Front) Status:
0 = ok
1 = flat
+1629 = [byte] Bike Tire (Rear) Status:
0 = ok
1 = flat
+1630 = [byte] Bicycle Tire (Front) Status:
0 = ok
1 = shot
+1631 = [byte] Bicycle Tire (Rear) Status:
0 = ok
1 = shot
Note: You cannot actually shoot the wheels of bmx. If you set the value 1 at above two offsets, it rides as if the wheels were shot. They probably not work.

+1736 = [byte] Is the bike identifier.
Note: Gets set to 1 if this vehicle is a bike (or bmx).

+1824 = [float] Front-Left suspension height
+1828 = [float] Rear-Left suspension height
+1832 = [float] Front-Rear suspension height
+1836 = [float] Rear-Rear suspension height
Note: There is also a copy of the suspension values at -0x10, but these are 'smoother'. They range from 0 to 1 (1 = fully extended/airborne, 0 = fully compressed).

+2020 = [float] Front-Left suspension height
+2024 = [float] Rear-Left suspension height
+2028 = [float] Front-Right suspension height
+2032 = [float] Rear-Right suspension height
+2156 = [word] Current load of vehicle, works for vehicles such as dumper, packer, dozer, forklift and so on.
+2160 = [word] Last load value of vehicle. Used to detect whether vehicle should have sound of raising/lowering a load. After detecting it gets value of car struct +2156 below.
+2276 = [float] Burn Timer (in ms)
Let's say, the Car Position of this given car starts at 0xC5F5DB4:

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
To the car object start. When warping vehicles that has trailer, we need to warp this 'vehicle' as well. The same pointer is used also when you are towing other vehicles as well.

Wanted
0xB7CD9C - Wanted pool start (CWanted). Each slot has 668 bytes of data.

+0x0 = Is the counter for how pissed the cops are:
above 50 = 1 star
above 180 = 2 stars
above 550 = 3 stars
above 1200 = 4 stars
above 2400 = 5 stars
above 4600 = 6 stars
+0x4 = like above, but 'before parole (timed wanted level decrease?)'
+0x8 = [dword] time value, the last time the wanted level decreased
+0xC = [dword] time value, the last time the wanted level changed
+0x10 = [dword] 'time of parole'
+0x14 = [float] multiplier of wanted level contribution of crimes (set using 03C7?)
+0x18 = [byte] Current amount of cops 'in pursuit'
+0x19 = [byte] Maximum number of foot cops simultaneously shooting at you ('in pursuit')
+0x1A = [byte] Maximum number of cop cars in pursuit
+0x1B = [byte] Amount of cops currently 'beating the suspect'
+0x1C = [word] Chance a road block appears, range unknown (though 127 seems to have a special meaning)
+0x1E = [bool] Is the player ignored by police? (set by script)
+0x1F = [bool] Is the player ignored by police? (set by garages)
+0x20 = [bool] Is the player ignored by everyone?
+0x21 = [bool] Should the streamer load the SWAT models?
+0x22 = [bool] Should the streamer load the FBI models?
+0x23 = [bool] Should the streamer load the army models?
+0x24 = [dword] Current chase time
+0x28 = [dword] 'Current chase time counter'
+0x2C = [bool] 'is time counting'
+0x2D = [word] Current wanted level (1-6)
+0x2F = [word] Wanted level before 'parole'
need to do more
Note: Helicopters will still shoot if you change flag 0x19 to 0.
         */
    }
}
