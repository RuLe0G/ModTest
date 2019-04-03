//подключение NUnit
using ConsoleApp1;
using NUnit.Framework;
using System;

namespace testing_test
{

    [TestFixture]
    class tasteCase
    {
        [TestCase]
        public void Inch()
        {
            functions f = new functions();


            Assert.AreEqual(12.7, f.cnv(5));

            var ex = Assert.Throws<Exception>(() => f.cnv(-5));
            Assert.That(ex.Message, Is.EqualTo("Значения должны быть > 0"));

           Assert.AreEqual(2.54 * double.MaxValue, f.cnv(double.MaxValue));

        }

        [TestCase]
        public void Chet()
        {
            //создание объекта, содержащего функцию
            functions f = new functions();
            //проверка возвращаемого значения, в первом случае оно должно быть истинно
            //во втором ложно
            Assert.IsTrue(f.chet(4));
            Assert.IsFalse(f.chet(5));
        }

        [TestCase]
        public void Mas()
        {
            int[] mas = new int[5] {1,2,3,4,5};
            int[] mas1 = new int[5] { -1, -2, -3, -4, -5 };
            int[] mas2 = new int[] {  };

            functions f = new functions();

            var ex = Assert.Throws<Exception>(() =>  f.masTest(mas2));

            Assert.That(ex.Message, Is.EqualTo("Массив не должен быть пустым"));

            Assert.DoesNotThrow(() => f.masTest(mas));
            Assert.AreEqual(5, f.masTest(mas));
            Assert.AreEqual(-1, f.masTest(mas1));


        }

        [TestCase]
        public void Ost()
        {

            functions f = new functions();

            var ex = Assert.Throws<Exception>(() => f.Ost(5, 0));

            Assert.That(ex.Message, Is.EqualTo("Значения должны быть > 0"));

            Assert.DoesNotThrow(() => f.Ost(5, 2));
            
        }
    }

}
