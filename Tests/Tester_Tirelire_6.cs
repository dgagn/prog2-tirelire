using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TirelireLib;
using System.Reflection;

namespace Tests
{
    [TestClass, TestCategory("DG")]
    public class Tester_Tirelire_6
    {
        [TestMethod]
        public void T0_Réflexion()
        {
            // La tirelire 6 est comparable à la tirelire 5
            AreEqual(
                typeof(Tirelire5).GetMembers().Length,
                typeof(Tirelire6).GetMembers().Length);

            // La propriété n'est pas statique et est publique
            AreEqual(1, typeof(Tirelire6).GetProperties(BindingFlags.Instance | BindingFlags.Public).Length);
        }

        [TestMethod]
        public void T1_Déposer()
        {
            var tirelire = new Tirelire6();
            AreEqual(0, tirelire.MontantTotal);

            IsFalse(tirelire.Déposer(0));
            IsFalse(tirelire.Déposer(-10));

            IsTrue(tirelire.Déposer(100));
            IsTrue(tirelire.Déposer(50));

            AreEqual(150, tirelire.MontantTotal);

            IsFalse(tirelire.Déposer(0));
            IsFalse(tirelire.Déposer(-10));

            AreEqual(150, tirelire.MontantTotal);
        }

        [TestMethod]
        public void T2_Vider()
        {
            var tirelire = new Tirelire6();
            AreEqual(0, tirelire.MontantTotal);

            AreEqual(0, tirelire.Vider());
            IsTrue(tirelire.Déposer(100));
            AreEqual(100, tirelire.Vider());
            AreEqual(0, tirelire.MontantTotal);
            IsTrue(tirelire.Déposer(500));
            AreEqual(500, tirelire.Vider());
            AreEqual(0, tirelire.MontantTotal);
        }

        [TestMethod]
        public void T3_Retirer()
        {
            var tirelire = new Tirelire6();
            AreEqual(0, tirelire.MontantTotal);

            IsFalse(tirelire.Retirer(0));
            IsFalse(tirelire.Retirer(-10));
            IsFalse(tirelire.Retirer(1));

            IsTrue(tirelire.Déposer(1000));
            IsTrue(tirelire.Retirer(50));
            IsTrue(tirelire.Retirer(100));

            IsFalse(tirelire.Retirer(0));
            IsFalse(tirelire.Retirer(-10));
            IsFalse(tirelire.Retirer(851));

            AreEqual(850, tirelire.MontantTotal);
        }

    }
}
