using CarSharing;
using System.Device.Location;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            Map map = new Map();

            double kilometers = 12.12121;

            var expectedType = typeof(string);
            var actualType = map.GetString(kilometers);

            Assert.AreEqual(actualType is string,true);

        }

        [TestMethod]

        public void TestMethod2() 
        {
            Map map = new Map();

            double lng = 53.92663205;
            double lat = 27.4312147;

            var expectedType = typeof(List<string>);
            var realType = map.Convertion(lng,lat);

            Assert.AreEqual(realType is List<string>, true);
        }
    }
}