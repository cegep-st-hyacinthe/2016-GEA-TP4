using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JeuEchec;
using VisualArrays;
using JeuEchec.Librairie;
using JeuEchec.Librairie.Pieces;

namespace JeuEchec.Tests.Librairie
{
    [TestClass]
    public class JoueurTest
    {
        [TestMethod]
        public void TestDeplacerPiece()
        {
            Joueur joueurBlanc = new Joueur("Joueur blanc", Couleurs.Blanc);
            Tour tourNoir = new Tour(new Position('D', 1), Couleurs.Noir);

            bool resultat = joueurBlanc.DeplacerPiece(tourNoir, new Position('D', 6));

            Assert.AreEqual(resultat, false);
        }

    }
}

