using System.Collections;

namespace IRController
{
    public class NecExample : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetData()
        {
            yield return new object[] { GetButton1Data(), new SignalData
        {
            CommandNumber =12,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="00110000",
            Protocol=Protocol.Nec
        } };
            yield return new object[] { GetButton2Data(), new SignalData {
            CommandNumber =24,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="00011000",
            Protocol=Protocol.Nec} };
            yield return new object[] { GetButton3Data(), new SignalData {
            CommandNumber =94,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01111010",
            Protocol=Protocol.Nec} };
            yield return new object[] { GetButton4Data(), new SignalData {
            CommandNumber =8,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="00010000",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetButton5Data(), new SignalData {
            CommandNumber =28,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="00111000",
            Protocol=Protocol.Nec} };
            yield return new object[] { GetButton6Data(), new SignalData {
            CommandNumber =90,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01011010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetButton7Data(), new SignalData {
            CommandNumber =66,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01000010",
            Protocol=Protocol.Nec} };
            yield return new object[] { GetButton8Data(), new SignalData {
            CommandNumber =82,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01001010",
            Protocol=Protocol.Nec} };
            yield return new object[] { GetButton9Data(), new SignalData {
            CommandNumber =74,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01010010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetChannelMinusButtonData(), new SignalData {
            CommandNumber =69,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="10100010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetChannelButtonData(), new SignalData {
            CommandNumber =70,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01100010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetChannelPlusButtonData(), new SignalData {
            CommandNumber =71,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="11100010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetPreviousButtonData(), new SignalData {
            CommandNumber =68,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="00100010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetNextButtonData(), new SignalData {
            CommandNumber =64,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="00000010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetPlayPauseButtonData(), new SignalData {
            CommandNumber =67,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="11000010",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetVolumeDownButtonData(), new SignalData {
            CommandNumber =7,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="11100000",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetVolumeUpButtonData(), new SignalData {
            CommandNumber =21,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="10101000",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetEQButtonData(), new SignalData {
            CommandNumber =9,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="10010000",
            Protocol=Protocol.Nec } };
            yield return new object[] { GetZeroButtonData(), new SignalData {
            CommandNumber =22,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01101000",
            Protocol=Protocol.Nec } };
            yield return new object[] { Get100ButtonData(), new SignalData {
            CommandNumber =25,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="10011000",
            Protocol=Protocol.Nec } };
            yield return new object[] { Get200ButtonData(), new SignalData {
            CommandNumber =13,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="10110000",
            Protocol=Protocol.Nec } };
        }

        public static IEnumerable<object[]> Repeat()
        {
            yield return new object[] { GetButton6Data(),GetButton6RepeatData(), new SignalData {
            CommandNumber =90,
            AddressNumber=0,
            RawAddress = "00000000",
            RawCommand="01011010",
            Protocol=Protocol.Nec } };
        }

        private RmtCommand[] GetButton1Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9322, false, 4437, true),
            new RmtCommand(661, false, 539, true),
            new RmtCommand(636, false, 538, true),
            new RmtCommand(609, false, 564, true),
            new RmtCommand(634, false, 540, true),
            new RmtCommand(638, false, 512, true),
            new RmtCommand(658, false, 539, true),
            new RmtCommand(634, false, 517, true),
            new RmtCommand(656, false, 540, true),
            new RmtCommand(633, false, 1620, true),
            new RmtCommand(636, false, 1617, true),
            new RmtCommand(636, false, 1618, true),
            new RmtCommand(636, false, 1618, true),
            new RmtCommand(610, false, 1643, true),
            new RmtCommand(635, false, 1617, true),
            new RmtCommand(636, false, 1618, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(610, false, 565, true),
            new RmtCommand(609, false, 542, true),
            new RmtCommand(632, false, 1643, true),
            new RmtCommand(635, false, 1618, true),
            new RmtCommand(634, false, 518, true),
            new RmtCommand(630, false, 541, true),
            new RmtCommand(656, false, 516, true),
            new RmtCommand(635, false, 540, true),
            new RmtCommand(657, false, 1617, true),
            new RmtCommand(635, false, 1619, true),
            new RmtCommand(610, false, 540, true),
            new RmtCommand(632, false, 540, true),
            new RmtCommand(659, false, 1618, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(634, false, 1618, true),
            new RmtCommand(633, false, 1621, true),
            new RmtCommand(635, false, 0, true),
            };
        }
        private RmtCommand[] GetButton2Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9223,false,4532,true),
            new RmtCommand(565,false,608,true),
            new RmtCommand(566,false,605,true),
            new RmtCommand(567,false,583,true),
            new RmtCommand(590,false,607,true),
            new RmtCommand(567,false,608,true),
            new RmtCommand(566,false,605,true),
            new RmtCommand(567,false,607,true),
            new RmtCommand(564,false,609,true),
            new RmtCommand(594,false,1634,true),
            new RmtCommand(590,false,1665,true),
            new RmtCommand(588,false,1664,true),
            new RmtCommand(589,false,1686,true),
            new RmtCommand(566,false,1687,true),
            new RmtCommand(567,false,1687,true),
            new RmtCommand(566,false,1663,true),
            new RmtCommand(590,false,1661,true),
            new RmtCommand(591,false,607,true),
            new RmtCommand(565,false,608,true),
            new RmtCommand(566,false,607,true),
            new RmtCommand(566,false,1686,true),
            new RmtCommand(567,false,1686,true),
            new RmtCommand(592,false,582,true),
            new RmtCommand(565,false,608,true),
            new RmtCommand(567,false,605,true),
            new RmtCommand(567,false,1687,true),
            new RmtCommand(566,false,1665,true),
            new RmtCommand(587,false,1688,true),
            new RmtCommand(566,false,607,true),
            new RmtCommand(567,false,606,true),
            new RmtCommand(566,false,1686,true),
            new RmtCommand(568,false,1686,true),
            new RmtCommand(566,false,1663,true),
            new RmtCommand(592,false,0,true),
            };
        }
        private RmtCommand[] GetButton3Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9275,false,4506,true),
            new RmtCommand(591,false,582,true),
            new RmtCommand(568,false,607,true),
            new RmtCommand(566,false,606,true),
            new RmtCommand(591,false,559,true),
            new RmtCommand(590,false,607,true),
            new RmtCommand(566,false,608,true),
            new RmtCommand(591,false,582,true),
            new RmtCommand(566,false,608,true),
            new RmtCommand(589,false,1664,true),
            new RmtCommand(591,false,1639,true),
            new RmtCommand(589,false,1665,true),
            new RmtCommand(588,false,1666,true),
            new RmtCommand(588,false,1664,true),
            new RmtCommand(590,false,1663,true),
            new RmtCommand(615,false,1639,true),
            new RmtCommand(588,false,1663,true),
            new RmtCommand(591,false,606,true),
            new RmtCommand(593,false,1636,true),
            new RmtCommand(616,false,1662,true),
            new RmtCommand(566,false,1687,true),
            new RmtCommand(618,false,1635,true),
            new RmtCommand(565,false,608,true),
            new RmtCommand(567,false,1686,true),
            new RmtCommand(568,false,605,true),
            new RmtCommand(593,false,1661,true),
            new RmtCommand(566,false,607,true),
            new RmtCommand(567,false,606,true),
            new RmtCommand(567,false,608,true),
            new RmtCommand(589,false,582,true),
            new RmtCommand(567,false,1688,true),
            new RmtCommand(591,false,582,true),
            new RmtCommand(592,false,1661,true),
            new RmtCommand(566,false,0,true),
            };
        }
        private RmtCommand[] GetButton4Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9312,false,4464,true),
            new RmtCommand(638,false,564,true),
            new RmtCommand(611,false,565,true),
            new RmtCommand(609,false,565,true),
            new RmtCommand(610,false,566,true),
            new RmtCommand(609,false,566,true),
            new RmtCommand(609,false,566,true),
            new RmtCommand(608,false,567,true),
            new RmtCommand(607,false,568,true),
            new RmtCommand(609,false,1645,true),
            new RmtCommand(608,false,1646,true),
            new RmtCommand(609,false,1645,true),
            new RmtCommand(609,false,1646,true),
            new RmtCommand(609,false,1646,true),
            new RmtCommand(607,false,1647,true),
            new RmtCommand(611,false,1643,true),
            new RmtCommand(610,false,1645,true),
            new RmtCommand(608,false,567,true),
            new RmtCommand(610,false,564,true),
            new RmtCommand(608,false,566,true),
            new RmtCommand(609,false,1644,true),
            new RmtCommand(608,false,545,true),
            new RmtCommand(631,false,565,true),
            new RmtCommand(631,false,543,true),
            new RmtCommand(608,false,543,true),
            new RmtCommand(631,false,1645,true),
            new RmtCommand(633,false,1621,true),
            new RmtCommand(633,false,1620,true),
            new RmtCommand(609,false,543,true),
            new RmtCommand(631,false,1645,true),
            new RmtCommand(632,false,1622,true),
            new RmtCommand(607,false,1624,true),
            new RmtCommand(629,false,1623,true),
            new RmtCommand(630,false,0,true),
            };
        }
        private RmtCommand[] GetButton5Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9314,false,4439,true),
            new RmtCommand(633,false,567,true),
            new RmtCommand(607,false,565,true),
            new RmtCommand(607,false,566,true),
            new RmtCommand(606,false,567,true),
            new RmtCommand(608,false,564,true),
            new RmtCommand(608,false,566,true),
            new RmtCommand(607,false,566,true),
            new RmtCommand(606,false,567,true),
            new RmtCommand(632,false,1620,true),
            new RmtCommand(608,false,1645,true),
            new RmtCommand(608,false,1644,true),
            new RmtCommand(608,false,1645,true),
            new RmtCommand(608,false,1645,true),
            new RmtCommand(608,false,1644,true),
            new RmtCommand(609,false,1644,true),
            new RmtCommand(608,false,1645,true),
            new RmtCommand(607,false,566,true),
            new RmtCommand(608,false,564,true),
            new RmtCommand(609,false,1644,true),
            new RmtCommand(607,false,1646,true),
            new RmtCommand(609,false,1643,true),
            new RmtCommand(610,false,564,true),
            new RmtCommand(608,false,565,true),
            new RmtCommand(609,false,564,true),
            new RmtCommand(633,false,1620,true),
            new RmtCommand(608,false,1645,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(632,false,541,true),
            new RmtCommand(633,false,539,true),
            new RmtCommand(610,false,1643,true),
            new RmtCommand(609,false,1644,true),
            new RmtCommand(608,false,1644,true),
            new RmtCommand(636,false,0,true),
            };
        }
        private static RmtCommand[] GetButton6Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9318,false,4436,true),
            new RmtCommand(635,false,566,true),
            new RmtCommand(633,false,540,true),
            new RmtCommand(608,false,565,true),
            new RmtCommand(609,false,564,true),
            new RmtCommand(609,false,564,true),
            new RmtCommand(609,false,564,true),
            new RmtCommand(610,false,564,true),
            new RmtCommand(609,false,565,true),
            new RmtCommand(633,false,1619,true),
            new RmtCommand(610,false,1643,true),
            new RmtCommand(635,false,1618,true),
            new RmtCommand(610,false,1644,true),
            new RmtCommand(635,false,1618,true),
            new RmtCommand(635,false,1618,true),
            new RmtCommand(633,false,1620,true),
            new RmtCommand(610,false,1644,true),
            new RmtCommand(612,false,562,true),
            new RmtCommand(634,false,1619,true),
            new RmtCommand(634,false,516,true),
            new RmtCommand(657,false,1619,true),
            new RmtCommand(633,false,1621,true),
            new RmtCommand(608,false,542,true),
            new RmtCommand(630,false,1646,true),
            new RmtCommand(607,false,541,true),
            new RmtCommand(632,false,1623,true),
            new RmtCommand(629,false,543,true),
            new RmtCommand(629,false,1624,true),
            new RmtCommand(629,false,544,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(627,false,0,true),
            };
        }
        private RmtCommand[] GetButton7Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9268,false,4504,true),
            new RmtCommand(594,false,581,true),
            new RmtCommand(594,false,580,true),
            new RmtCommand(594,false,578,true),
            new RmtCommand(621,false,552,true),
            new RmtCommand(622,false,553,true),
            new RmtCommand(620,false,556,true),
            new RmtCommand(620,false,555,true),
            new RmtCommand(592,false,579,true),
            new RmtCommand(621,false,1633,true),
            new RmtCommand(594,false,1660,true),
            new RmtCommand(617,false,1635,true),
            new RmtCommand(619,false,1636,true),
            new RmtCommand(617,false,1637,true),
            new RmtCommand(617,false,1637,true),
            new RmtCommand(618,false,1636,true),
            new RmtCommand(616,false,1659,true),
            new RmtCommand(596,false,554,true),
            new RmtCommand(619,false,1635,true),
            new RmtCommand(618,false,555,true),
            new RmtCommand(593,false,584,true),
            new RmtCommand(615,false,558,true),
            new RmtCommand(616,false,556,true),
            new RmtCommand(618,false,1637,true),
            new RmtCommand(592,false,582,true),
            new RmtCommand(616,false,1635,true),
            new RmtCommand(594,false,581,true),
            new RmtCommand(616,false,1636,true),
            new RmtCommand(617,false,1659,true),
            new RmtCommand(593,false,1661,true),
            new RmtCommand(566,false,1687,true),
            new RmtCommand(592,false,581,true),
            new RmtCommand(567,false,1686,true),
            new RmtCommand(594,false,0,true),
            };
        }
        private RmtCommand[] GetButton8Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9358,false,4435,true),
            new RmtCommand(668,false,536,true),
            new RmtCommand(637,false,539,true),
            new RmtCommand(640,false,536,true),
            new RmtCommand(640,false,535,true),
            new RmtCommand(637,false,538,true),
            new RmtCommand(638,false,515,true),
            new RmtCommand(659,false,538,true),
            new RmtCommand(638,false,537,true),
            new RmtCommand(638,false,1616,true),
            new RmtCommand(636,false,1619,true),
            new RmtCommand(636,false,1617,true),
            new RmtCommand(638,false,1617,true),
            new RmtCommand(639,false,1616,true),
            new RmtCommand(638,false,1617,true),
            new RmtCommand(640,false,1615,true),
            new RmtCommand(640,false,1614,true),
            new RmtCommand(637,false,539,true),
            new RmtCommand(637,false,1616,true),
            new RmtCommand(638,false,539,true),
            new RmtCommand(637,false,537,true),
            new RmtCommand(636,false,1617,true),
            new RmtCommand(636,false,540,true),
            new RmtCommand(634,false,1619,true),
            new RmtCommand(637,false,538,true),
            new RmtCommand(634,false,1619,true),
            new RmtCommand(636,false,539,true),
            new RmtCommand(611,false,1642,true),
            new RmtCommand(637,false,1617,true),
            new RmtCommand(637,false,516,true),
            new RmtCommand(635,false,1642,true),
            new RmtCommand(635,false,515,true),
            new RmtCommand(661,false,1618,true),
            new RmtCommand(634,false,0,true),
            };
        }
        private RmtCommand[] GetButton9Data()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9278,false,4463,true),
            new RmtCommand(660,false,540,true),
            new RmtCommand(633,false,516,true),
            new RmtCommand(656,false,540,true),
            new RmtCommand(608,false,565,true),
            new RmtCommand(608,false,564,true),
            new RmtCommand(632,false,541,true),
            new RmtCommand(632,false,517,true),
            new RmtCommand(656,false,516,true),
            new RmtCommand(656,false,1620,true),
            new RmtCommand(610,false,1643,true),
            new RmtCommand(634,false,1618,true),
            new RmtCommand(631,false,1622,true),
            new RmtCommand(633,false,1619,true),
            new RmtCommand(634,false,1618,true),
            new RmtCommand(610,false,1642,true),
            new RmtCommand(634,false,1619,true),
            new RmtCommand(631,false,543,true),
            new RmtCommand(608,false,1643,true),
            new RmtCommand(634,false,516,true),
            new RmtCommand(631,false,1645,true),
            new RmtCommand(608,false,539,true),
            new RmtCommand(658,false,515,true),
            new RmtCommand(633,false,1645,true),
            new RmtCommand(609,false,538,true),
            new RmtCommand(632,false,1646,true),
            new RmtCommand(631,false,516,true),
            new RmtCommand(659,false,1619,true),
            new RmtCommand(632,false,515,true),
            new RmtCommand(659,false,1620,true),
            new RmtCommand(630,false,1600,true),
            new RmtCommand(630,false,540,true),
            new RmtCommand(658,false,1598,true),
            new RmtCommand(630,false,0,true),
            };
        }
        private static RmtCommand[] GetButton6RepeatData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9281,false,2207,true),
            new RmtCommand(627,false,0,true),
            };
        }

        private RmtCommand[] GetChannelMinusButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9317, false, 4437, true),
            new RmtCommand(662, false, 538, true),
            new RmtCommand(634, false, 540, true),
            new RmtCommand(635, false, 537, true),
            new RmtCommand(634, false, 540, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(634, false, 539, true),
            new RmtCommand(632, false, 541, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(637, false, 1616, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(635, false, 1618, true),
            new RmtCommand(635, false, 1617, true),
            new RmtCommand(610, false, 1643, true),
            new RmtCommand(635, false, 1617, true),
            new RmtCommand(633, false, 1621, true),
            new RmtCommand(635, false, 1617, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(611, false, 563, true),
            new RmtCommand(609, false, 1642, true),
            new RmtCommand(608, false, 566, true),
            new RmtCommand(634, false, 539, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(632, false, 1620, true),
            new RmtCommand(633, false, 541, true),
            new RmtCommand(632, false, 540, true),
            new RmtCommand(632, false, 1620, true),
            new RmtCommand(635, false, 538, true),
            new RmtCommand(610, false, 1642, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(635, false, 1617, true),
            new RmtCommand(635, false, 539, true),
            new RmtCommand(609, false, 1643, true),
            new RmtCommand(635, false, 0, true),
            };
        }

        private RmtCommand[] GetChannelButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9310, false, 4439, true),
            new RmtCommand(661, false, 539, true),
            new RmtCommand(633, false, 517, true),
            new RmtCommand(656, false, 516, true),
            new RmtCommand(657, false, 539, true),
            new RmtCommand(632, false, 517, true),
            new RmtCommand(633, false, 541, true),
            new RmtCommand(656, false, 517, true),
            new RmtCommand(656, false, 515, true),
            new RmtCommand(634, false, 1643, true),
            new RmtCommand(608, false, 1645, true),
            new RmtCommand(608, false, 1622, true),
            new RmtCommand(656, false, 1597, true),
            new RmtCommand(656, false, 1597, true),
            new RmtCommand(628, false, 1623, true),
            new RmtCommand(630, false, 1622, true),
            new RmtCommand(630, false, 1622, true),
            new RmtCommand(629, false, 543, true),
            new RmtCommand(629, false, 1624, true),
            new RmtCommand(627, false, 1626, true),
            new RmtCommand(628, false, 545, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(626, false, 1627, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 1626, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 1627, true),
            new RmtCommand(628, false, 1626, true),
            new RmtCommand(628, false, 1626, true),
            new RmtCommand(654, false, 519, true),
            new RmtCommand(629, false, 1625, true),
            new RmtCommand(652, false, 0, true),
            };
        }

        private RmtCommand[] GetChannelPlusButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9310, false, 4439, true),
            new RmtCommand(659, false, 541, true),
            new RmtCommand(608, false, 564, true),
            new RmtCommand(608, false, 566, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(632, false, 540, true),
            new RmtCommand(609, false, 564, true),
            new RmtCommand(610, false, 564, true),
            new RmtCommand(632, false, 1620, true),
            new RmtCommand(609, false, 1644, true),
            new RmtCommand(609, false, 1644, true),
            new RmtCommand(609, false, 1644, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(607, false, 1646, true),
            new RmtCommand(611, false, 1642, true),
            new RmtCommand(611, false, 1642, true),
            new RmtCommand(609, false, 1644, true),
            new RmtCommand(607, false, 1645, true),
            new RmtCommand(609, false, 1644, true),
            new RmtCommand(609, false, 565, true),
            new RmtCommand(634, false, 539, true),
            new RmtCommand(608, false, 543, true),
            new RmtCommand(653, false, 1621, true),
            new RmtCommand(609, false, 565, true),
            new RmtCommand(633, false, 539, true),
            new RmtCommand(610, false, 541, true),
            new RmtCommand(656, false, 539, true),
            new RmtCommand(608, false, 1644, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(610, false, 1643, true),
            new RmtCommand(633, false, 541, true),
            new RmtCommand(633, false, 1618, true),
            new RmtCommand(635, false, 0, true),
            };
        }

        private RmtCommand[] GetPreviousButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9308, false, 4437, true),
            new RmtCommand(661, false, 539, true),
            new RmtCommand(632, false, 541, true),
            new RmtCommand(632, false, 540, true),
            new RmtCommand(633, false, 539, true),
            new RmtCommand(635, false, 538, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(632, false, 541, true),
            new RmtCommand(631, false, 541, true),
            new RmtCommand(634, false, 1618, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(634, false, 1618, true),
            new RmtCommand(633, false, 1620, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(632, false, 1620, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(633, false, 539, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(633, false, 1618, true),
            new RmtCommand(635, false, 539, true),
            new RmtCommand(633, false, 539, true),
            new RmtCommand(631, false, 542, true),
            new RmtCommand(632, false, 1619, true),
            new RmtCommand(634, false, 540, true),
            new RmtCommand(633, false, 1618, true),
            new RmtCommand(609, false, 1643, true),
            new RmtCommand(633, false, 541, true),
            new RmtCommand(609, false, 1642, true),
            new RmtCommand(610, false, 1643, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(610, false, 539, true),
            new RmtCommand(656, false, 1619, true),
            new RmtCommand(629, false, 0, true),
            };
        }

        private RmtCommand[] GetNextButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9311, false, 4439, true),
            new RmtCommand(661, false, 539, true),
            new RmtCommand(635, false, 539, true),
            new RmtCommand(635, false, 538, true),
            new RmtCommand(634, false, 540, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(635, false, 516, true),
            new RmtCommand(657, false, 539, true),
            new RmtCommand(634, false, 515, true),
            new RmtCommand(634, false, 1643, true),
            new RmtCommand(633, false, 1621, true),
            new RmtCommand(633, false, 1621, true),
            new RmtCommand(635, false, 1619, true),
            new RmtCommand(632, false, 1621, true),
            new RmtCommand(633, false, 1600, true),
            new RmtCommand(653, false, 1599, true),
            new RmtCommand(630, false, 1624, true),
            new RmtCommand(629, false, 541, true),
            new RmtCommand(632, false, 541, true),
            new RmtCommand(631, false, 542, true),
            new RmtCommand(629, false, 544, true),
            new RmtCommand(628, false, 545, true),
            new RmtCommand(628, false, 546, true),
            new RmtCommand(626, false, 1627, true),
            new RmtCommand(627, false, 547, true),
            new RmtCommand(626, false, 1627, true),
            new RmtCommand(627, false, 1627, true),
            new RmtCommand(627, false, 1627, true),
            new RmtCommand(626, false, 1627, true),
            new RmtCommand(627, false, 1627, true),
            new RmtCommand(625, false, 1628, true),
            new RmtCommand(626, false, 547, true),
            new RmtCommand(626, false, 1628, true),
            new RmtCommand(627, false, 0, true),
            };
        }

        private RmtCommand[] GetPlayPauseButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9302, false, 4437, true),
            new RmtCommand(660, false, 538, true),
            new RmtCommand(635, false, 538, true),
            new RmtCommand(634, false, 538, true),
            new RmtCommand(635, false, 537, true),
            new RmtCommand(633, false, 539, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(633, false, 539, true),
            new RmtCommand(633, false, 540, true),
            new RmtCommand(631, false, 1620, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(632, false, 1620, true),
            new RmtCommand(633, false, 1620, true),
            new RmtCommand(633, false, 1618, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(634, false, 1618, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(634, false, 1617, true),
            new RmtCommand(633, false, 518, true),
            new RmtCommand(654, false, 540, true),
            new RmtCommand(608, false, 564, true),
            new RmtCommand(634, false, 538, true),
            new RmtCommand(608, false, 1643, true),
            new RmtCommand(609, false, 541, true),
            new RmtCommand(631, false, 564, true),
            new RmtCommand(632, false, 540, true),
            new RmtCommand(609, false, 1642, true),
            new RmtCommand(633, false, 1619, true),
            new RmtCommand(634, false, 1618, true),
            new RmtCommand(608, false, 1644, true),
            new RmtCommand(631, false, 542, true),
            new RmtCommand(632, false, 1619, true),
            new RmtCommand(608, false, 0, true),
            };
        }

        private RmtCommand[] GetVolumeDownButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9308, false, 4440, true),
            new RmtCommand(661, false, 539, true),
            new RmtCommand(634, false, 539, true),
            new RmtCommand(634, false, 515, true),
            new RmtCommand(658, false, 540, true),
            new RmtCommand(619, false, 554, true),
            new RmtCommand(608, false, 541, true),
            new RmtCommand(632, false, 541, true),
            new RmtCommand(657, false, 515, true),
            new RmtCommand(659, false, 1619, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(634, false, 1620, true),
            new RmtCommand(634, false, 1620, true),
            new RmtCommand(634, false, 1619, true),
            new RmtCommand(608, false, 1645, true),
            new RmtCommand(607, false, 1622, true),
            new RmtCommand(631, false, 1621, true),
            new RmtCommand(631, false, 1623, true),
            new RmtCommand(629, false, 1624, true),
            new RmtCommand(628, false, 1624, true),
            new RmtCommand(628, false, 546, true),
            new RmtCommand(628, false, 545, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 547, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 546, true),
            new RmtCommand(627, false, 1627, true),
            new RmtCommand(627, false, 1626, true),
            new RmtCommand(627, false, 1627, true),
            new RmtCommand(626, false, 1627, true),
            new RmtCommand(627, false, 1627, true),
            new RmtCommand(651, false, 0, true),
            };
        }

        private RmtCommand[] GetVolumeUpButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9288,false,4466,true),
            new RmtCommand(662,false,539,true),
            new RmtCommand(633,false,541,true),
            new RmtCommand(608,false,566,true),
            new RmtCommand(607,false,566,true),
            new RmtCommand(610,false,564,true),
            new RmtCommand(635,false,538,true),
            new RmtCommand(611,false,563,true),
            new RmtCommand(632,false,542,true),
            new RmtCommand(634,false,1619,true),
            new RmtCommand(637,false,1618,true),
            new RmtCommand(635,false,1619,true),
            new RmtCommand(610,false,1644,true),
            new RmtCommand(634,false,1621,true),
            new RmtCommand(633,false,1621,true),
            new RmtCommand(632,false,1622,true),
            new RmtCommand(632,false,1622,true),
            new RmtCommand(632,false,1623,true),
            new RmtCommand(613,false,535,true),
            new RmtCommand(632,false,1624,true),
            new RmtCommand(629,false,542,true),
            new RmtCommand(630,false,1625,true),
            new RmtCommand(628,false,545,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(626,false,547,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(627,false,1628,true),
            new RmtCommand(626,false,547,true),
            new RmtCommand(626,false,1628,true),
            new RmtCommand(627,false,547,true),
            new RmtCommand(627,false,1628,true),
            new RmtCommand(626,false,1628,true),
            new RmtCommand(627,false,1628,true),
            new RmtCommand(628,false,0,true),
            };
        }

        private RmtCommand[] GetEQButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9277,false,4469,true),
            new RmtCommand(633,false,540,true),
            new RmtCommand(632,false,540,true),
            new RmtCommand(632,false,540,true),
            new RmtCommand(634,false,539,true),
            new RmtCommand(633,false,539,true),
            new RmtCommand(632,false,541,true),
            new RmtCommand(630,false,543,true),
            new RmtCommand(629,false,544,true),
            new RmtCommand(631,false,1623,true),
            new RmtCommand(630,false,1623,true),
            new RmtCommand(630,false,1623,true),
            new RmtCommand(629,false,1624,true),
            new RmtCommand(630,false,1624,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(628,false,1626,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(627,false,545,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(626,false,546,true),
            new RmtCommand(627,false,1626,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(629,false,544,true),
            new RmtCommand(627,false,1626,true),
            new RmtCommand(628,false,1626,true),
            new RmtCommand(628,false,1625,true),
            new RmtCommand(627,false,1627,true),
            new RmtCommand(627,false,0,true),
            };
        }

        private RmtCommand[] GetZeroButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9258, false, 4501, true),
            new RmtCommand(623, false, 552, true),
            new RmtCommand(622, false, 551, true),
            new RmtCommand(624, false, 549, true),
            new RmtCommand(626, false, 549, true),
            new RmtCommand(623, false, 550, true),
            new RmtCommand(622, false, 552, true),
            new RmtCommand(622, false, 551, true),
            new RmtCommand(597, false, 579, true),
            new RmtCommand(621, false, 1630, true),
            new RmtCommand(598, false, 1658, true),
            new RmtCommand(620, false, 1634, true),
            new RmtCommand(596, false, 1658, true),
            new RmtCommand(621, false, 1633, true),
            new RmtCommand(620, false, 1634, true),
            new RmtCommand(594, false, 1659, true),
            new RmtCommand(597, false, 1658, true),
            new RmtCommand(618, false, 558, true),
            new RmtCommand(592, false, 1660, true),
            new RmtCommand(599, false, 1654, true),
            new RmtCommand(622, false, 552, true),
            new RmtCommand(619, false, 1635, true),
            new RmtCommand(595, false, 579, true),
            new RmtCommand(595, false, 577, true),
            new RmtCommand(621, false, 554, true),
            new RmtCommand(619, false, 1635, true),
            new RmtCommand(618, false, 554, true),
            new RmtCommand(595, false, 579, true),
            new RmtCommand(594, false, 1659, true),
            new RmtCommand(620, false, 555, true),
            new RmtCommand(618, false, 1636, true),
            new RmtCommand(619, false, 1634, true),
            new RmtCommand(594, false, 1660, true),
            new RmtCommand(619, false, 0, true),
            };
        }

        private RmtCommand[] Get100ButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9284,false,4465,true),
            new RmtCommand(661,false,515,true),
            new RmtCommand(638,false,559,true),
            new RmtCommand(634,false,517,true),
            new RmtCommand(631,false,565,true),
            new RmtCommand(635,false,516,true),
            new RmtCommand(657,false,516,true),
            new RmtCommand(655,false,517,true),
            new RmtCommand(657,false,516,true),
            new RmtCommand(657,false,1622,true),
            new RmtCommand(633,false,1620,true),
            new RmtCommand(634,false,1621,true),
            new RmtCommand(632,false,1600,true),
            new RmtCommand(629,false,1624,true),
            new RmtCommand(655,false,1598,true),
            new RmtCommand(655,false,1598,true),
            new RmtCommand(630,false,1623,true),
            new RmtCommand(629,false,1626,true),
            new RmtCommand(628,false,545,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(627,false,1627,true),
            new RmtCommand(628,false,1627,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(628,false,546,true),
            new RmtCommand(627,false,1628,true),
            new RmtCommand(627,false,1627,true),
            new RmtCommand(627,false,547,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(628,false,1627,true),
            new RmtCommand(629,false,1625,true),
            new RmtCommand(654,false,1601,true),
            new RmtCommand(627,false,0,true),
            };
        }

        private RmtCommand[] Get200ButtonData()
        {
            return new RmtCommand[]
            {
            new RmtCommand(9304,false,4441,true),
            new RmtCommand(660,false,539,true),
            new RmtCommand(610,false,563,true),
            new RmtCommand(608,false,565,true),
            new RmtCommand(609,false,564,true),
            new RmtCommand(608,false,565,true),
            new RmtCommand(632,false,541,true),
            new RmtCommand(632,false,541,true),
            new RmtCommand(633,false,539,true),
            new RmtCommand(632,false,1621,true),
            new RmtCommand(634,false,1619,true),
            new RmtCommand(611,false,1643,true),
            new RmtCommand(609,false,1644,true),
            new RmtCommand(632,false,1621,true),
            new RmtCommand(609,false,1645,true),
            new RmtCommand(633,false,1620,true),
            new RmtCommand(609,false,1645,true),
            new RmtCommand(607,false,1646,true),
            new RmtCommand(608,false,541,true),
            new RmtCommand(631,false,1646,true),
            new RmtCommand(631,false,1601,true),
            new RmtCommand(652,false,518,true),
            new RmtCommand(630,false,542,true),
            new RmtCommand(629,false,544,true),
            new RmtCommand(628,false,544,true),
            new RmtCommand(628,false,545,true),
            new RmtCommand(627,false,1627,true),
            new RmtCommand(627,false,546,true),
            new RmtCommand(626,false,547,true),
            new RmtCommand(626,false,1627,true),
            new RmtCommand(627,false,1627,true),
            new RmtCommand(627,false,1627,true),
            new RmtCommand(626,false,1628,true),
            new RmtCommand(626,false,0,true),
            };
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return GetData();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}