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
            Assert.True(expetedOutput.SequenceEqual(actualOutput));
        }

        [Test]
        public void GetSortedArrayFromString_Should_Return_Correct_Array_With_Same_End_Latters()
        {
            string input = "www how wow are you now";
            string[] expetedOutput = { "are", "you", "www", "how", "wow", "now" };
            string[] actualOutput = WordManager.GetSortedsArrayFromString(input);
            Assert.True(expetedOutput.SequenceEqual(actualOutput));
        }

        [Test]
        public void GetSortedArrayFromString_Should_Deal_With_EmptySpace_String()
        {
            string[] expetedOutput = new string[0];
            string[] actualOutput = WordManager.GetSortedsArrayFromString("");
            Assert.True(expetedOutput.SequenceEqual(actualOutput));
        }

        [Test]
        public void GetSortedArrayFromString_Should_Deal_With_Null()
        {
            string[] expetedOutput = new string[0];
            string[] actualOutput = WordManager.GetSortedsArrayFromString(null);
            Assert.True(expetedOutput.SequenceEqual(actualOutput));
        }

        [Test]
        public void GetSortedArrayFromString_Should_Return_Correct_Array_For_Diff_End_Leters()
        {
            string input = "ag bf ce dd ec fb ga";
            string[] expetedOutput = { "ga", "fb", "ec", "dd", "ce", "bf", "ag" };
            string[] actualOutput = WordManager.GetSortedsArrayFromString(input);
            Assert.True(expetedOutput.SequenceEqual(actualOutput));
        }

        [Test]
        public void CompareByLastLetter_Should_Return_Correct_Answer()
        {
            Assert.True(WordManager.CompareByLastLetter("bb", "af") < 0);
            Assert.True(WordManager.CompareByLastLetter("abz", "uvw") > 0);
            Assert.True(WordManager.CompareByLastLetter("how", "wow") == 0);
            Assert.True(WordManager.CompareByLastLetter("abc", "abc") == 0);
            Assert.True(WordManager.CompareByLastLetter("how", "are") > 0);
            Assert.True(WordManager.CompareByLastLetter("you", "are") > 0);

        }

    }
}