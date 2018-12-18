using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exception = System.Exception;

namespace Tests
{
    [TestClass]
    public class SongTests
    {
        [TestMethod]
        public void ShouldThrowExceptionIfTooManyCharactersInArtistName()
        {
            //Arrange
            const string artistNameInput = "Hermantha Wickramaratne";
            const string songName = "Der Blubbersong";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => new Song(songName, artistNameInput));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfTooManyCharactersInSongName()
        {
            //Arrange
            const string songNameInput = "It's The End Of The World As We Know It (And I Feel Fine)";
            const string artistname = "Hermann Holts";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => new Song(songNameInput, artistname));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfNotEnoughCharactersInSongName()
        {
            //Arrange
            const string songNameInput = "A";
            const string artistName = "Hermann Holts";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => new Song(songNameInput, artistName));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfNotEnoughCharactersInArtistName()
        {
            //Arrange
            const string artistNameInput = "I";
            const string songName = "Ein Lied";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => new Song(songName, artistNameInput));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfArtistIsNullOrEmpty()
        {
            //Arrange
            const string artistNameInput = "";
            const string songname = "Der Blubbersong";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => new Song(songname, artistNameInput));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfSongIsNullOrEmpty()
        {
            //Arrange
            const string songNameinput = "";
            const string artistName = "Hermann Holts";

            //Act & Assert
            Assert.ThrowsException<Exception>(() => new Song(songNameinput, artistName));
        }
    }
}
