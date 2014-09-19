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
    public class Handling : MemoryObject
    {
        public Handling(ProcessMemory memory) : base(memory)
        {
        }

        /*
         * Think shit needda be floats
         */

        [Address(0x0)]
        public int IndexIdentifier { get; set; }

        [Address(0x4)]
        public int FMass { get; set; }

        [Address(0x8)]
        public int OneDividedByFMass { get; set; }

        [Address(0xC)]
        public int FTurnMass { get; set; }

        [Address(0x10)]
        public int FDragMult { get; set; }

        [Address(0x14)]
        public int CentreOfMassX { get; set; }

        [Address(0x18)]
        public int CentreOfMassY { get; set; }

        [Address(0x1C)]
        public int CentreOfMassZ { get; set; }

        [Address(0x20)]
        public byte NPercentSubmerged { get; set; }

        [Address(0x24)]
        public int FMassSubmerged { get; set; }

        //fMass * 8.0000001e-1 / nPercentSubmerged

        [Address(0x28)]
        public int FTractionMultiplier { get; set; }

        [Address(0x74)]
        public byte TransmissionDatanDriveType { get; set; }

        [Address(0x75)]
        public byte TransmissionDatanEngineType { get; set; }

        [Address(0x76)]
        public byte TransmissionDatanNumberOfGears { get; set; }

        [Address(0x7C)]
        public int TransmissionDatafEngineAcceleration { get; set; }

        [Address(0x80)]
        public int TransmissionDatafEngineInertia { get; set; }

        [Address(0x84)]
        public int TransmissionDatafMaxVelocity { get; set; }

        [Address(0x94)]
        public int FBrakeDeceleration { get; set; }

        [Address(0x98)]
        public int FBrakeBias { get; set; }

        [Address(0x9C)]
        public byte BABS { get; set; }

        [Address(0xA0)]
        public int FSteeringLock { get; set; }

        [Address(0xA4)]
        public int FTractionLoss { get; set; }

        [Address(0xA8)]
        public int FTractionBias { get; set; }

        [Address(0xAC)]
        public int FSuspensionForceLevel { get; set; }

        [Address(0xB0)]
        public int FSuspensionDampingLevel { get; set; }

        [Address(0xB4)]
        public int FSuspensionHighSpdComDamp { get; set; }

        [Address(0xB8)]
        public int SuspensionUpperLimit { get; set; }

        [Address(0xBC)]
        public int SuspensionLowerLimit { get; set; }

        [Address(0xC0)]
        public int SuspensionBiasBetweenFrontAndRear { get; set; }

        [Address(0xC4)]
        public int SuspensionAntiDiveMultiplier { get; set; }

        [Address(0xC8)]
        public float FCollisionDamageMultiplier { get; set; }

        //{ memory fCollisionDamageMultiplier = fCollisionDamageMultiplier * ( 1.0 / fMass) * 2000.0 }

        [Address(0xCC)]
        public int ModelFlags { get; set; }

        [Address(0xD0)]
        public int HandlingFlags { get; set; }

        [Address(0xD4)]
        public int FSeatOffsetDistance { get; set; }

        [Address(0xD8)]
        public int NMonetaryValue { get; set; }

        [Address(0xDC)]
        public byte FrontLights { get; set; }

        [Address(0xDD)]
        public byte RearLights { get; set; }

        [Address(0xDE)]
        public byte VehicleAnimGrou { get; set; }
    }
}