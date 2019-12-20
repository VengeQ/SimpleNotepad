using NUnit.Framework;

namespace NoteModelTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SpendType_Test()
        {
            var rent = Note.SpendType.Rent;
            Assert.AreEqual(rent, Note.SpendType.Rent);

            var food = rent+1;
            Assert.AreEqual(food, Note.SpendType.Food);

            var rest = food + 1;
            Assert.AreEqual(rest, Note.SpendType.Rest);
        }
    }
}