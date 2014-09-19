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
    public class CWanted : MemoryObject
    {
        public CWanted(ProcessMemory memory) : base(memory)
        {
        }

        [Address(0x0)]
        public int IsTheCounterForHowPissedTheCopsAre { get; set; }

/*above 50 - 1 star
above 180 - 2 stars
above 550 - 3 stars
above 1200 - 4 stars
above 2400 - 5 stars
above 4600 - 6 stars*/

        [Address(0x4)]
        public int IsTheCounterForHowPissedTheCopsAreBeforeParole { get; set; }

        [Address(0x8)]
        public int TimeValueTheLastTimeTheWantedLevelDecreased { get; set; }

        [Address(0xC)]
        public int TimeValueTheLastTimeTheWantedLevelChanged { get; set; }

        [Address(0x10)]
        public int TimeOfParole { get; set; }

        [Address(0x14)]
        public float MultiplierOfWantedLevelContributionOfCrimes { get; set; }

        [Address(0x18)]
        public byte CurrentAmountOfCops { get; set; }

        [Address(0x19)]
        public byte MaximumNumberOfFootCopsSimultaneouslyShootingAtYou { get; set; }

        [Address(0x1A)]
        public byte MaximumNumberOfCopCarsInPursuit { get; set; }

        [Address(0x1B)]
        public byte AmountOfCopsCurrently { get; set; }

        [Address(0x1C)]
        public short ChanceARoadBlockAppearsRangeUnknown { get; set; }

        [Address(0x1E)]
        public bool IsThePlayerIgnoredByPoliceSetByScript { get; set; }

        [Address(0x1F)]
        public bool IsThePlayerIgnoredByPoliceSetByGarages { get; set; }

        [Address(0x20)]
        public bool IsThePlayerIgnoredByEveryone { get; set; }

        [Address(0x21)]
        public bool ShouldTheStreamerLoadTheSWATModels { get; set; }

        [Address(0x22)]
        public bool ShouldTheStreamerLoadTheFBIModels { get; set; }

        [Address(0x23)]
        public bool ShouldTheStreamerLoadTheArmyModels { get; set; }

        [Address(0x24)]
        public int CurrentChaseTime { get; set; }

        [Address(0x28)]
        public int CurrentChaseTimeCounter { get; set; }

        [Address(0x2C)]
        public bool IsTimeCounting { get; set; }

        [Address(0x2D)]
        public short CurrentWantedLevel { get; set; }

        [Address(0x2F)]
        public short WantedLevelBefore { get; set; }

//need to do more

        //Note: Helicopters will still shoot if you change flag 0x19 to 0.
    }
}