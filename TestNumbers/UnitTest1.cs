namespace TestNumbers
{
    public class Tests
    {
        [TestMethod]
        public void TestCheckMark()
        {
            var calc = new NumberClass();
            string text = "‡999‡‡999";
            bool answer = calc.CheckMark(text);

            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestGetNextMarkAfter()
        {
            var calc = new NumberClass();
            string text = "‡999‡‡999";
            string answer = calc.GetNextMarkAfter(text);

            Assert.AreNotEqual(text, answer);
        }
    }
}