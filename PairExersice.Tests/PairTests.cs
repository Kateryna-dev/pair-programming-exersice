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
        public void GetSortedArrayFromString_Should_Return_Correct_Array()
        {
            //arrange
            string input = "how are you";
            string[] expetedOutput = new string[] { "are", "you", "how" };

            //act
            string[] actualOutput = WordManager.GetSortedsArrayFromString(input);

            //assert
            actualOutput.Should().BeEquivalentTo(expetedOutput);
        }


        [Test]
        public void ReverseWordsInArray_Should_Return_Correct_Array()
        {
            string[] input = { "how", "are", "you" };
            string[] expetedOutput = { "woh", "era", "uoy" };
            string[] actualOutput = WordManager.ReverseWordsInArray(input);
            actualOutput.Should().BeEquivalentTo(expetedOutput);
        }

        [Test]
        public void GetSortedArrayFromString_Should_Return_Correct_Array_With_Same_End_Latters()
        {
            string input = "www how wow are you now";
            string[] expetedOutput = { "are", "you", "www", "wow", "how", "now" };
            string[] actualOutput = WordManager.GetSortedsArrayFromString(input);
            actualOutput.Should().BeEquivalentTo(expetedOutput);
        }
    }
}