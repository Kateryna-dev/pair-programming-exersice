using NUnit.Framework;
using FluentAssertions;
using PairExersice;

namespace PairExersice.Tests
{
    public class PairTests
    {
        private WordManager WordManager;

        [SetUp]
        public void Setup()
        {
            WordManager = new WordManager();
        }

        [Test]
        public void GetArrayFromString_Should_Return_Array_In_Alphabet_Order()
        {
            //arrange
            string input = "how are you";
            string[] expetedOutput = new string[] { "are", "how", "you" };

            //act
            string[] actualOutput = WordManager.GetArrayFromString(input);

            //assert
            actualOutput.Should().BeEquivalentTo(expetedOutput);
        }
    }
}