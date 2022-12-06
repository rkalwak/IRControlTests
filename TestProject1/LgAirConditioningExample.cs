using System.Collections;

public class LgAirConditioningExample : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetData()
    {
        yield return new object[] { GetButton1Data(), new SignalData
        {
            CommandNumber =49157,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="1100000000000101",
            Protocol= IRController.Protocol.LgAirConditioner
        } };
        yield return new object[] { GetButton2Data(), new SignalData {
            CommandNumber =656,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001010010000",
            Protocol=IRController.Protocol.LgAirConditioner} };
        yield return new object[] { GetButton3Data(), new SignalData {
            CommandNumber =672,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001010100000",
            Protocol=IRController.Protocol.LgAirConditioner} };
        yield return new object[] { GetButton4Data(), new SignalData {
            CommandNumber =688,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001010110000",
            Protocol=IRController.Protocol.LgAirConditioner } };
        yield return new object[] { GetButton5Data(), new SignalData {
            CommandNumber =704,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001011000000",
            Protocol=IRController.Protocol.LgAirConditioner} };
        yield return new object[] { GetButton6Data(), new SignalData {
            CommandNumber =720,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001011010000",
            Protocol=IRController.Protocol.LgAirConditioner } };
        yield return new object[] { GetButton7Data(), new SignalData {
            CommandNumber =736,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001011100000",
            Protocol=IRController.Protocol.LgAirConditioner} };
        yield return new object[] { GetButton8Data(), new SignalData {
            CommandNumber =752,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001011110000",
            Protocol=IRController.Protocol.LgAirConditioner} };
        yield return new object[] { GetButton9Data(), new SignalData {
            CommandNumber =752,
            AddressNumber=136,
            RawAddress = "10001000",
            RawCommand="0000001011110000",
            Protocol=IRController.Protocol.LgAirConditioner } };
    }

    private RmtCommand[] GetButton1Data()
    {
        return new RmtCommand[]
        {
           new RmtCommand(8338,false,4226,true),
new RmtCommand(536,false,1304,true),
new RmtCommand(568,false,561,true),
new RmtCommand(568,false,562,true),
new RmtCommand(528,false,600,true),
new RmtCommand(531,false,1310,true),
new RmtCommand(529,false,599,true),
new RmtCommand(537,false,589,true),
new RmtCommand(541,false,589,true),
new RmtCommand(535,false,1305,true),
new RmtCommand(536,false,1303,true),
new RmtCommand(535,false,595,true),
new RmtCommand(542,false,587,true),
new RmtCommand(567,false,562,true),
new RmtCommand(530,false,599,true),
new RmtCommand(529,false,600,true),
new RmtCommand(536,false,591,true),
new RmtCommand(539,false,590,true),
new RmtCommand(533,false,597,true),
new RmtCommand(533,false,595,true),
new RmtCommand(566,false,564,true),
new RmtCommand(541,false,587,true),
new RmtCommand(507,false,1334,true),
new RmtCommand(529,false,600,true),
new RmtCommand(533,false,1307,true),
new RmtCommand(533,false,593,true),
new RmtCommand(536,false,593,true),
new RmtCommand(534,false,596,true),
new RmtCommand(534,false,1306,true),
new RmtCommand(538,false,0,true),

        };
    }
    private static RmtCommand[] GetButton2Data()
    {
        return new RmtCommand[]
        {

            new RmtCommand(8338,false,4226,true),
            new RmtCommand(533,false,1306,true),
            new RmtCommand(565,false,565,true),
            new RmtCommand(562,false,567,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(530,false,1310,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(558,false,569,true),
            new RmtCommand(560,false,569,true),
            new RmtCommand(534,false,595,true),
            new RmtCommand(533,false,597,true),
            new RmtCommand(563,false,566,true),
            new RmtCommand(563,false,566,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(530,false,599,true),
            new RmtCommand(558,false,1282,true),
            new RmtCommand(558,false,569,true),
            new RmtCommand(532,false,1308,true),
            new RmtCommand(532,false,597,true),
            new RmtCommand(533,false,596,true),
            new RmtCommand(563,false,1276,true),
            new RmtCommand(564,false,566,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(530,false,599,true),
            new RmtCommand(557,false,573,true),
            new RmtCommand(556,false,1281,true),
            new RmtCommand(560,false,569,true),
            new RmtCommand(534,false,1306,true),
            new RmtCommand(533,false,1306,true),
            new RmtCommand(534,false,0,true),
        };
    }
    private RmtCommand[] GetButton3Data()
    {
        return new RmtCommand[]
        {

            new RmtCommand(8357,false,4207,true),
            new RmtCommand(569,false,1295,true),
            new RmtCommand(575,false,555,true),
            new RmtCommand(551,false,578,true),
            new RmtCommand(510,false,619,true),
            new RmtCommand(535,false,1304,true),
            new RmtCommand(536,false,594,true),
            new RmtCommand(544,false,585,true),
            new RmtCommand(543,false,586,true),
            new RmtCommand(540,false,587,true),
            new RmtCommand(541,false,589,true),
            new RmtCommand(548,false,581,true),
            new RmtCommand(549,false,580,true),
            new RmtCommand(510,false,618,true),
            new RmtCommand(511,false,619,true),
            new RmtCommand(543,false,1297,true),
            new RmtCommand(543,false,587,true),
            new RmtCommand(537,false,1302,true),
            new RmtCommand(538,false,589,true),
            new RmtCommand(541,false,1298,true),
            new RmtCommand(551,false,579,true),
            new RmtCommand(549,false,580,true),
            new RmtCommand(510,false,619,true),
            new RmtCommand(511,false,618,true),
            new RmtCommand(541,false,567,true),
            new RmtCommand(565,false,1296,true),
            new RmtCommand(544,false,1295,true),
            new RmtCommand(539,false,589,true),
            new RmtCommand(541,false,588,true),
            new RmtCommand(550,false,0,true),
        };
    }
    private static RmtCommand[] GetButton4Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(8343,false,4221,true),
            new RmtCommand(565,false,1300,true),
            new RmtCommand(549,false,580,true),
            new RmtCommand(549,false,558,true),
            new RmtCommand(531,false,620,true),
            new RmtCommand(509,false,1331,true),
            new RmtCommand(508,false,621,true),
            new RmtCommand(541,false,566,true),
            new RmtCommand(565,false,565,true),
            new RmtCommand(559,false,590,true),
            new RmtCommand(539,false,568,true),
            new RmtCommand(569,false,582,true),
            new RmtCommand(547,false,583,true),
            new RmtCommand(508,false,621,true),
            new RmtCommand(509,false,620,true),
            new RmtCommand(539,false,1300,true),
            new RmtCommand(539,false,591,true),
            new RmtCommand(536,false,1303,true),
            new RmtCommand(536,false,591,true),
            new RmtCommand(540,false,1300,true),
            new RmtCommand(548,false,1292,true),
            new RmtCommand(547,false,582,true),
            new RmtCommand(546,false,561,true),
            new RmtCommand(531,false,620,true),
            new RmtCommand(508,false,597,true),
            new RmtCommand(565,false,1299,true),
            new RmtCommand(517,false,1323,true),
            new RmtCommand(540,false,564,true),
            new RmtCommand(537,false,1325,true),
            new RmtCommand(514,false,0,true),
        };
    }


    private static RmtCommand[] GetButton5Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(8343,false,4221,true),
            new RmtCommand(540,false,1325,true),
            new RmtCommand(548,false,582,true),
            new RmtCommand(545,false,559,true),
            new RmtCommand(532,false,598,true),
            new RmtCommand(532,false,1330,true),
            new RmtCommand(510,false,599,true),
            new RmtCommand(562,false,564,true),
            new RmtCommand(539,false,590,true),
            new RmtCommand(561,false,591,true),
            new RmtCommand(514,false,591,true),
            new RmtCommand(570,false,560,true),
            new RmtCommand(571,false,559,true),
            new RmtCommand(531,false,621,true),
            new RmtCommand(507,false,599,true),
            new RmtCommand(563,false,1299,true),
            new RmtCommand(541,false,564,true),
            new RmtCommand(535,false,1329,true),
            new RmtCommand(512,false,1326,true),
            new RmtCommand(514,false,593,true),
            new RmtCommand(567,false,561,true),
            new RmtCommand(568,false,562,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(562,false,567,true),
            new RmtCommand(562,false,1275,true),
            new RmtCommand(564,false,1276,true),
            new RmtCommand(560,false,1281,true),
            new RmtCommand(534,false,594,true),
            new RmtCommand(536,false,0,true),
        };
    }
    private RmtCommand[] GetButton6Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(8342,false,4222,true),
            new RmtCommand(539,false,1304,true),
            new RmtCommand(566,false,561,true),
            new RmtCommand(568,false,562,true),
            new RmtCommand(530,false,600,true),
            new RmtCommand(529,false,1311,true),
            new RmtCommand(530,false,597,true),
            new RmtCommand(565,false,562,true),
            new RmtCommand(567,false,563,true),
            new RmtCommand(536,false,595,true),
            new RmtCommand(535,false,592,true),
            new RmtCommand(567,false,562,true),
            new RmtCommand(569,false,560,true),
            new RmtCommand(531,false,599,true),
            new RmtCommand(531,false,598,true),
            new RmtCommand(563,false,1300,true),
            new RmtCommand(514,false,589,true),
            new RmtCommand(537,false,1305,true),
            new RmtCommand(535,false,1305,true),
            new RmtCommand(533,false,593,true),
            new RmtCommand(570,false,1272,true),
            new RmtCommand(567,false,560,true),
            new RmtCommand(568,false,562,true),
            new RmtCommand(530,false,599,true),
            new RmtCommand(530,false,599,true),
            new RmtCommand(538,false,1303,true),
            new RmtCommand(537,false,1299,true),
            new RmtCommand(564,false,1278,true),
            new RmtCommand(534,false,1303,true),
            new RmtCommand(536,false,0,true),
        };
    }

    private RmtCommand[] GetButton7Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(8342,false,4222,true),
            new RmtCommand(538,false,1304,true),
            new RmtCommand(567,false,561,true),
            new RmtCommand(568,false,560,true),
            new RmtCommand(532,false,597,true),
            new RmtCommand(532,false,1310,true),
            new RmtCommand(528,false,599,true),
            new RmtCommand(537,false,590,true),
            new RmtCommand(562,false,567,true),
            new RmtCommand(536,false,594,true),
            new RmtCommand(535,false,594,true),
            new RmtCommand(539,false,590,true),
            new RmtCommand(563,false,566,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(529,false,601,true),
            new RmtCommand(532,false,1307,true),
            new RmtCommand(532,false,595,true),
            new RmtCommand(532,false,1308,true),
            new RmtCommand(533,false,1307,true),
            new RmtCommand(532,false,1307,true),
            new RmtCommand(533,false,596,true),
            new RmtCommand(561,false,569,true),
            new RmtCommand(561,false,568,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(555,false,572,true),
            new RmtCommand(534,false,595,true),
            new RmtCommand(533,false,596,true),
            new RmtCommand(533,false,597,true),
            new RmtCommand(559,false,0,true),
        };
    }
    private RmtCommand[] GetButton8Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(8341,false,4221,true),
            new RmtCommand(541,false,1325,true),
            new RmtCommand(547,false,560,true),
            new RmtCommand(567,false,561,true),
            new RmtCommand(532,false,598,true),
            new RmtCommand(530,false,1331,true),
            new RmtCommand(508,false,600,true),
            new RmtCommand(561,false,565,true),
            new RmtCommand(542,false,588,true),
            new RmtCommand(538,false,592,true),
            new RmtCommand(535,false,592,true),
            new RmtCommand(568,false,562,true),
            new RmtCommand(544,false,585,true),
            new RmtCommand(530,false,600,true),
            new RmtCommand(529,false,600,true),
            new RmtCommand(562,false,1300,true),
            new RmtCommand(541,false,563,true),
            new RmtCommand(536,false,1329,true),
            new RmtCommand(511,false,1304,true),
            new RmtCommand(536,false,1326,true),
            new RmtCommand(514,false,1303,true),
            new RmtCommand(571,false,557,true),
            new RmtCommand(569,false,561,true),
            new RmtCommand(530,false,599,true),
            new RmtCommand(531,false,598,true),
            new RmtCommand(561,false,568,true),
            new RmtCommand(539,false,588,true),
            new RmtCommand(535,false,594,true),
            new RmtCommand(537,false,1304,true),
            new RmtCommand(536,false,0,true),
        };
    }
    private RmtCommand[] GetButton9Data()
    {
        return new RmtCommand[]
        {
            new RmtCommand(8342,false,4222,true),
            new RmtCommand(537,false,1328,true),
            new RmtCommand(521,false,583,true),
            new RmtCommand(571,false,558,true),
            new RmtCommand(532,false,598,true),
            new RmtCommand(532,false,1332,true),
            new RmtCommand(507,false,599,true),
            new RmtCommand(537,false,588,true),
            new RmtCommand(567,false,562,true),
            new RmtCommand(538,false,591,true),
            new RmtCommand(564,false,565,true),
            new RmtCommand(570,false,561,true),
            new RmtCommand(543,false,587,true),
            new RmtCommand(530,false,599,true),
            new RmtCommand(529,false,599,true),
            new RmtCommand(539,false,1303,true),
            new RmtCommand(536,false,589,true),
            new RmtCommand(536,false,1305,true),
            new RmtCommand(535,false,1305,true),
            new RmtCommand(534,false,1305,true),
            new RmtCommand(535,false,1304,true),
            new RmtCommand(544,false,584,true),
            new RmtCommand(570,false,560,true),
            new RmtCommand(530,false,598,true),
            new RmtCommand(531,false,598,true),
            new RmtCommand(562,false,568,true),
            new RmtCommand(561,false,566,true),
            new RmtCommand(535,false,593,true),
            new RmtCommand(537,false,1305,true),
            new RmtCommand(534,false,0,true),
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