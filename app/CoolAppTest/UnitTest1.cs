using CoolApp;

namespace CoolAppTest
{
    public class UnitTest1
    {
        [Fact]
        public void PlusTest()
        {
            var res = Plus.PlusMethod(2, 4);
            Assert.Equal(6, res);
        }
    }
}