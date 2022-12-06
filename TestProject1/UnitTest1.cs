using FluentAssertions;
using IRController;
using Xunit;

namespace DecodingTests
{
    public class DecodingTests
    {
        [Fact]
        public void ShouldNotDecodeNec()
        {
            var input = new RmtCommand[]
                {
                    new RmtCommand(9314, false, 4439, true),
                    new RmtCommand(633, false, 567, true),
                    new RmtCommand(607, false, 565, true),
                    new RmtCommand(607, false, 566, true),
                    new RmtCommand(606, false, 567, true),
                    new RmtCommand(608, false, 564, true),
                    new RmtCommand(608, false, 566, true),
                    new RmtCommand(607, false, 566, true),
                    new RmtCommand(606, false, 567, true),
                    new RmtCommand(632, false, 1620, true),
                    new RmtCommand(608, false, 1645, true),
                    new RmtCommand(608, false, 1644, true),
                    new RmtCommand(608, false, 1645, true),
                    new RmtCommand(608, false, 1645, true),
                    new RmtCommand(608, false, 1644, true),
                    new RmtCommand(609, false, 1644, true),
                    new RmtCommand(608, false, 1645, true),
                    new RmtCommand(607, false, 566, true),
                    new RmtCommand(608, false, 564, true),
                    new RmtCommand(609, false, 1644, true),
                    new RmtCommand(607, false, 1646, true),
                    new RmtCommand(609, false, 1643, true),
                    new RmtCommand(610, false, 564, true),
                    new RmtCommand(608, false, 565, true),
                    new RmtCommand(609, false, 564, true),
                    new RmtCommand(633, false, 1620, true),
                    new RmtCommand(608, false, 1645, true),
                    new RmtCommand(628, false, 546, true),
                    new RmtCommand(632, false, 541, true),
                    new RmtCommand(633, false, 539, true),
                    new RmtCommand(610, false, 1643, true),
                    new RmtCommand(609, false, 1644, true),
                    new RmtCommand(608, false, 1644, true),
                    new RmtCommand(634, false, 6666, true),
                    new RmtCommand(9305, false, 2224, true),
                    new RmtCommand(636, false, 0, true),
                };
            var signalDecoder = new NecSignalDecoder(signalLengthTolerance: 0.17);
            var data = signalDecoder.Decode(input);
            data.Should().BeEquivalentTo(new SignalData
            {
                CommandNumber = -1,
                AddressNumber = -1,
                RawAddress = null,
                RawCommand = null,
                Protocol = Protocol.Unknown
            });
        }

        [Theory]
        [ClassData(typeof(LgAirConditioningExample))]
        public void ShouldDecodeLgAirConditioner(RmtCommand[] input, SignalData expectedOutput)
        {
            var signalDecoder = new LgAirConditionerSignalDecoder(signalLengthTolerance: 0.17);
            var data = signalDecoder.Decode(input);
            data.Should().BeEquivalentTo(expectedOutput);
        }


        [Theory]
        [ClassData(typeof(NecExample))]
        public void ShouldDecodeNec(RmtCommand[] input, SignalData expectedOutput)
        {
            var signalDecoder = new NecSignalDecoder(signalLengthTolerance: 0.17);
            var data = signalDecoder.Decode(input);
            data.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [MemberData(nameof(NecExample.Repeat), MemberType = typeof(NecExample))]
        public void ShouldDecodeNecRepeat(RmtCommand[] input, RmtCommand[] repeatedInput, SignalData expectedOutput)
        {
            var signalDecoder = new NecSignalDecoder(signalLengthTolerance: 0.17);
            var data = signalDecoder.Decode(input);
            data.Should().BeEquivalentTo(expectedOutput);
            data = signalDecoder.Decode(repeatedInput);
            data.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [ClassData(typeof(LgExample))]
        public void ShouldDecodeLgTvUsingNec(RmtCommand[] input, SignalData expectedOutput)
        {
            var signalDecoder = new NecSignalDecoder(signalLengthTolerance: 0.20);
            var data = signalDecoder.Decode(input);
            data.Should().BeEquivalentTo(expectedOutput);
        }

        [Theory]
        [MemberData(nameof(LgExample.Repeat), MemberType = typeof(LgExample))]
        public void ShouldDecodeLgTvRepeatUsingNec(RmtCommand[] input, RmtCommand[] repeatedInput, SignalData expectedOutput)
        {
            var signalDecoder = new NecSignalDecoder(signalLengthTolerance: 0.20);
            var data = signalDecoder.Decode(input);
            data.Should().BeEquivalentTo(expectedOutput);
            data = signalDecoder.Decode(repeatedInput);
            data.Should().BeEquivalentTo(expectedOutput);
        }
    }
}

public class RmtCommand
{
    public RmtCommand(ushort duration0, bool level0, ushort duration1, bool level1)
    {
        Duration0 = duration0;
        Duration1 = duration1;
        Level0 = level0;
        Level1 = level1;
    }

    public ushort Duration0 { set; get; }
    public ushort Duration1 { set; get; }
    public bool Level0 { set; get; }
    public bool Level1 { set; get; }
}

public class SignalData
{
    public int AddressNumber { set; get; } = -1;
    public int CommandNumber { set; get; } = -1;

    public string RawAddress { set; get; }
    public string RawCommand { set; get; }
    public Protocol Protocol { get; set; } = Protocol.Unknown;
}
