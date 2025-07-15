using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        
            [Theory]
            [InlineData("kayak", true)]
            [InlineData("Goodbye", false)]
            public void TestPalindrome(string word, bool expected)
            {
                //Arrange - 
                var tester = new WordSmith();

                //Act
                var actual = tester.IsAPalindrome(word);

                //Assert
                Assert.Equal(expected, actual);

            }
        }
    }
