using System.Collections;

public class LgExample : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetData()
    {
        yield return new object[] { GetButton1Data(), new SignalData
        {
            CommandNumber =17,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="10001000",
            Protocol= IRController.Protocol.Nec
        } };
        yield return new object[] { GetButton2Data(), new SignalData {
            CommandNumber =18,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="01001000",
            Protocol=IRController.Protocol.Nec} };
        yield return new object[] { GetButton3Data(), new SignalData {
            CommandNumber =19,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="11001000",
            Protocol=IRController.Protocol.Nec} };
        yield return new object[] { GetButton4Data(), new SignalData {
            CommandNumber =20,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="00101000",
            Protocol=IRController.Protocol.Nec } };
        yield return new object[] { GetButton5Data(), new SignalData {
            CommandNumber =21,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="10101000",
            Protocol=IRController.Protocol.Nec} };
        yield return new object[] { GetButton6Data(), new SignalData {
            CommandNumber =22,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="01101000",
            Protocol=IRController.Protocol.Nec } };
        yield return new object[] { GetButton7Data(), new SignalData {
            CommandNumber =23,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="11101000",
            Protocol=IRController.Protocol.Nec} };
        yield return new object[] { GetButton8Data(), new SignalData {
            CommandNumber =24,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="00011000",
            Protocol=IRController.Protocol.Nec} };
        yield return new object[] { GetButton9Data(), new SignalData {
            CommandNumber =25,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="10011000",
            Protocol=IRController.Protocol.Nec } };
    }

    public static IEnumerable<object[]> Repeat()
    {
        yield return new object[] { GetButton2Data(),GetButton2RepeatData(), new SignalData {
            CommandNumber =18,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="01001000",
            Protocol=IRController.Protocol.Nec } };

        yield return new object[] { GetButton4Data(),GetButton4RepeatData(), new SignalData {
            CommandNumber =20,
            AddressNumber=4,
            RawAddress = "00100000",
            RawCommand="00101000",
            Protocol=IRController.Protocol.Nec } };
    }

    private RmtCommand[] GetButton1Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(9066, false, 4448, true),
            new RmtCommand(595, false, 553, true),
            new RmtCommand(593, false, 529, true),
            new RmtCommand(568, false, 1676, true),
            new RmtCommand(568, false, 553, true),
            new RmtCommand(570, false, 553, true),
            new RmtCommand(568, false, 553, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(570, false, 552, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(570, false, 1673, true),
            new RmtCommand(596, false, 1647, true),
            new RmtCommand(569, false, 1675, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(569, false, 552, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(569, false, 529, true),
            new RmtCommand(617, false, 1650, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(568, false, 553, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(594, false, 527, true),
            new RmtCommand(571, false, 1673, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(590, false, 1653, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(593, false, 1649, true),
            new RmtCommand(570, false, 1674, true),
            new RmtCommand(570, false, 1673, true),
            new RmtCommand(593, false, 0, true),
        };
    }
    private static RmtCommand[] GetButton2Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(9068, false, 4449, true),
            new RmtCommand(618, false, 530, true),
            new RmtCommand(568, false, 553, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(568, false, 553, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(568, false, 1676, true),
            new RmtCommand(592, false, 530, true),
            new RmtCommand(568, false, 1674, true),
            new RmtCommand(569, false, 1675, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(569, false, 1675, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(567, false, 1675, true),
            new RmtCommand(570, false, 552, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(568, false, 553, true),
            new RmtCommand(591, false, 1652, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(592, false, 1651, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(594, false, 0, true),
        };
    }
    private RmtCommand[] GetButton3Data()
    {
        return new RmtCommand[]
        {

            new RmtCommand(9062, false, 4455, true),
            new RmtCommand(587, false, 560, true),
            new RmtCommand(539, false, 583, true),
            new RmtCommand(539, false, 1705, true),
            new RmtCommand(539, false, 582, true),
            new RmtCommand(540, false, 582, true),
            new RmtCommand(539, false, 583, true),
            new RmtCommand(540, false, 582, true),
            new RmtCommand(563, false, 559, true),
            new RmtCommand(561, false, 1682, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(561, false, 561, true),
            new RmtCommand(539, false, 1704, true),
            new RmtCommand(563, false, 1681, true),
            new RmtCommand(563, false, 1680, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(563, false, 1680, true),
            new RmtCommand(564, false, 1680, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(562, false, 560, true),
            new RmtCommand(564, false, 557, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(566, false, 555, true),
            new RmtCommand(567, false, 1676, true),
            new RmtCommand(566, false, 1677, true),
            new RmtCommand(566, false, 534, true),
            new RmtCommand(588, false, 1677, true),
            new RmtCommand(567, false, 1676, true),
            new RmtCommand(566, false, 1678, true),
            new RmtCommand(590, false, 0, true),
        };
    }
    private static RmtCommand[] GetButton4Data()
    {
        return new RmtCommand[]
        {

            new RmtCommand(9066, false, 4449, true),
            new RmtCommand(621, false, 527, true),
            new RmtCommand(594, false, 527, true),
            new RmtCommand(595, false, 1648, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(595, false, 527, true),
            new RmtCommand(569, false, 552, true),
            new RmtCommand(594, false, 505, true),
            new RmtCommand(592, false, 1673, true),
            new RmtCommand(595, false, 1648, true),
            new RmtCommand(570, false, 529, true),
            new RmtCommand(616, false, 1650, true),
            new RmtCommand(593, false, 1650, true),
            new RmtCommand(594, false, 1649, true),
            new RmtCommand(594, false, 1649, true),
            new RmtCommand(593, false, 1651, true),
            new RmtCommand(592, false, 504, true),
            new RmtCommand(594, false, 527, true),
            new RmtCommand(593, false, 1653, true),
            new RmtCommand(589, false, 530, true),
            new RmtCommand(591, false, 1652, true),
            new RmtCommand(590, false, 532, true),
            new RmtCommand(589, false, 533, true),
            new RmtCommand(588, false, 534, true),
            new RmtCommand(588, false, 1655, true),
            new RmtCommand(588, false, 1656, true),
            new RmtCommand(587, false, 534, true),
            new RmtCommand(588, false, 1656, true),
            new RmtCommand(587, false, 535, true),
            new RmtCommand(587, false, 1656, true),
            new RmtCommand(587, false, 1656, true),
            new RmtCommand(588, false, 1655, true),
            new RmtCommand(588, false, 0, true),
        };
    }

    private static RmtCommand[] GetButton4RepeatData()
    {
        return new RmtCommand[]
        {
            new RmtCommand(9059, false, 2215, true),
            new RmtCommand(589, false, 0, true),
        };
    }
    private RmtCommand[] GetButton5Data()
    {
        return new RmtCommand[]
        {

            new RmtCommand(9090, false, 4425, true),
            new RmtCommand(621, false, 526, true),
            new RmtCommand(597, false, 525, true),
            new RmtCommand(597, false, 1646, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(597, false, 525, true),
            new RmtCommand(594, false, 527, true),
            new RmtCommand(596, false, 526, true),
            new RmtCommand(595, false, 526, true),
            new RmtCommand(596, false, 1647, true),
            new RmtCommand(596, false, 1647, true),
            new RmtCommand(593, false, 529, true),
            new RmtCommand(594, false, 1649, true),
            new RmtCommand(594, false, 1648, true),
            new RmtCommand(596, false, 1647, true),
            new RmtCommand(594, false, 1649, true),
            new RmtCommand(570, false, 1673, true),
            new RmtCommand(594, false, 1648, true),
            new RmtCommand(595, false, 506, true),
            new RmtCommand(616, false, 1648, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(597, false, 1646, true),
            new RmtCommand(570, false, 551, true),
            new RmtCommand(596, false, 526, true),
            new RmtCommand(595, false, 527, true),
            new RmtCommand(569, false, 530, true),
            new RmtCommand(593, false, 1672, true),
            new RmtCommand(571, false, 551, true),
            new RmtCommand(570, false, 1672, true),
            new RmtCommand(570, false, 552, true),
            new RmtCommand(594, false, 1648, true),
            new RmtCommand(570, false, 1673, true),
            new RmtCommand(570, false, 1674, true),
            new RmtCommand(595, false, 0, true),
        };
    }
    private static RmtCommand[] GetButton6Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(9065, false, 4449, true),
            new RmtCommand(594, false, 555, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(567, false, 555, true),
            new RmtCommand(568, false, 553, true),
            new RmtCommand(567, false, 555, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(594, false, 1650, true),
            new RmtCommand(568, false, 1674, true),
            new RmtCommand(569, false, 1675, true),
            new RmtCommand(569, false, 1675, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(569, false, 1675, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(568, false, 1675, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(594, false, 528, true),
            new RmtCommand(569, false, 553, true),
            new RmtCommand(594, false, 1649, true),
            new RmtCommand(569, false, 554, true),
            new RmtCommand(567, false, 554, true),
            new RmtCommand(569, false, 1674, true),
            new RmtCommand(568, false, 532, true),
            new RmtCommand(590, false, 1675, true),
            new RmtCommand(570, false, 1673, true),
            new RmtCommand(569, false, 1675, true),
            new RmtCommand(568, false, 0, true),
        };
    }
    private RmtCommand[] GetButton7Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(9038, false, 4477, true),
            new RmtCommand(565, false, 582, true),
            new RmtCommand(540, false, 582, true),
            new RmtCommand(562, false, 1682, true),
            new RmtCommand(538, false, 583, true),
            new RmtCommand(562, false, 559, true),
            new RmtCommand(562, false, 560, true),
            new RmtCommand(540, false, 581, true),
            new RmtCommand(562, false, 561, true),
            new RmtCommand(561, false, 1681, true),
            new RmtCommand(540, false, 1704, true),
            new RmtCommand(562, false, 559, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(542, false, 1701, true),
            new RmtCommand(563, false, 1680, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(563, false, 1680, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(566, false, 1678, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(566, false, 534, true),
            new RmtCommand(588, false, 1678, true),
            new RmtCommand(566, false, 1678, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(567, false, 0, true),
        };
    }
    private RmtCommand[] GetButton8Data()
    {
        return new RmtCommand[]
        {

            new RmtCommand(9064, false, 4451, true),
            new RmtCommand(589, false, 560, true),
            new RmtCommand(539, false, 582, true),
            new RmtCommand(561, false, 1682, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(562, false, 560, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(564, false, 557, true),
            new RmtCommand(566, false, 1679, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(541, false, 581, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(566, false, 1678, true),
            new RmtCommand(565, false, 1679, true),
            new RmtCommand(563, false, 1680, true),
            new RmtCommand(566, false, 1678, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(564, false, 558, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(566, false, 1678, true),
            new RmtCommand(562, false, 1681, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(564, false, 558, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(565, false, 1679, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(566, false, 557, true),
            new RmtCommand(564, false, 558, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(566, false, 1677, true),
            new RmtCommand(567, false, 1677, true),
            new RmtCommand(566, false, 0, true),
        };
    }
    private RmtCommand[] GetButton9Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(9039, false, 4477, true),
            new RmtCommand(590, false, 559, true),
            new RmtCommand(563, false, 558, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(541, false, 581, true),
            new RmtCommand(540, false, 582, true),
            new RmtCommand(561, false, 561, true),
            new RmtCommand(564, false, 558, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(564, false, 1679, true),
            new RmtCommand(563, false, 1680, true),
            new RmtCommand(566, false, 557, true),
            new RmtCommand(563, false, 1680, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(565, false, 1679, true),
            new RmtCommand(565, false, 1678, true),
            new RmtCommand(566, false, 1677, true),
            new RmtCommand(566, false, 557, true),
            new RmtCommand(563, false, 558, true),
            new RmtCommand(566, false, 1677, true),
            new RmtCommand(568, false, 1676, true),
            new RmtCommand(566, false, 556, true),
            new RmtCommand(565, false, 557, true),
            new RmtCommand(567, false, 554, true),
            new RmtCommand(567, false, 555, true),
            new RmtCommand(568, false, 1676, true),
            new RmtCommand(567, false, 1676, true),
            new RmtCommand(568, false, 554, true),
            new RmtCommand(567, false, 556, true),
            new RmtCommand(566, false, 1676, true),
            new RmtCommand(567, false, 1676, true),
            new RmtCommand(568, false, 1676, true),
            new RmtCommand(567, false, 0, true),
        };
    }
    private static RmtCommand[] GetButton2RepeatData()
    {
        return new RmtCommand[]{
        new RmtCommand(9065, false, 2234, true),
        new RmtCommand(594, false, 0, true),
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