namespace IRController
{
    public class LgAirConditionerSignalDecoder : Decoder
    {
        public LgAirConditionerSignalDecoder(double signalLengthTolerance)
            : base(signalLengthTolerance)
        {
        }

        protected override int PulseLengthInMicroseconds => 500;
        protected override int HeaderMark => PulseLengthInMicroseconds * 18;
        protected override int HeaderSpace => 4200;
        protected override int RepeatSpace => PulseLengthInMicroseconds * 4;
        protected override int ZeroSpace => 540;
        protected override int OneSpace => PulseLengthInMicroseconds * 3;
        protected override Protocol Protocol => Protocol.LgAirConditioner;
        protected override int SignalLength => 30;
        protected override bool UseLessSignificantBitFirst => false;
        protected override int AddressBits => 8;
        protected override int CommandBits => 16;
    }
}