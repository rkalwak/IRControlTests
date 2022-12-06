using nanoFramework.Hardware.Esp32.Rmt;

namespace IRController
{
    public class GenericSignalDecoder
    {
        private readonly double signalLengthTolerance;
        private Decoder decoder;
        public GenericSignalDecoder(double signalLengthTolerance = 0.25)
        {
            this.signalLengthTolerance = signalLengthTolerance;
        }

        public SignalData Decode(RmtCommand[] response)
        {
            if (decoder == null)
            {
                var necDecoder = new NecSignalDecoder(signalLengthTolerance);
                var lgAirConditionerDecoder = new LgAirConditionerSignalDecoder(signalLengthTolerance);
                if (necDecoder.IsSignalMatchingProtocol(response))
                {
                    decoder = necDecoder;
                }
                else if (lgAirConditionerDecoder.IsSignalMatchingProtocol(response))
                {
                    decoder = lgAirConditionerDecoder;
                }
            }

            return decoder?.Decode(response);
        }
    }
}