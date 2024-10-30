//using AddNumber.Core;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Workout.Test.Level4
//{
//    [TestClass]
//    public class AddNumberEngineTests
//    {
//        [TestMethod]
//        [DataRow("3", "6", 3 + 4 + 5 + 6)]
//        [DataRow("-2", "4", -2 + -1 + 0 + 1 + 2 + 3 + 4)]
//        [DataRow("105", "107", 105 + 106 + 107)]
//        public void happy_path(string firstNumber, string secondNumber, int expectedResult)
//        {
//            // happy path
//            var x = new AddNumberEngine();
//            x.TryAddNumber(firstNumber);
//            x.TryAddNumber(secondNumber);
//            int result = x.Result();
//            Assert.AreEqual(expectedResult, result);
//        }

//        [TestMethod]
//        public void engine_should_just_accept_whole_numbers()
//        {
//            var x = new AddNumberEngine();

//            Assert.ThrowsException<AddNumberEngine.InputIsNotNumberException>(() => x.TryAddNumber(null));
//            Assert.ThrowsException<AddNumberEngine.InputIsNotNumberException>(() => x.TryAddNumber(""));
//            Assert.ThrowsException<AddNumberEngine.InputIsNotNumberException>(() => x.TryAddNumber("a"));

//            x.TryAddNumber("3");

//            Assert.ThrowsException<AddNumberEngine.InputIsNotNumberException>(() => x.TryAddNumber("b"));
//            Assert.ThrowsException<AddNumberEngine.InputIsNotNumberException>(() => x.TryAddNumber(null));
//            Assert.ThrowsException<AddNumberEngine.InputIsNotNumberException>(() => x.TryAddNumber("c"));
//            x.TryAddNumber("6");
//        }

//        [TestMethod]
//        public void should_ask_for_number_1_and_then_number_2()
//        {
//            var x = new AddNumberEngine();
//            Assert.AreEqual(1, x.NumberToAskFor);

//            x.TryAddNumber("3");

//            Assert.AreEqual(2, x.NumberToAskFor);

//            x.TryAddNumber("7");

//            Assert.ThrowsException<AddNumberEngine.AlreadyHaveTwoValuesException>(() => x.NumberToAskFor);


//        }

//        [TestMethod]
//        public void ready_for_calculation_should_be_set_after_two_numbers()
//        {
//            var x = new AddNumberEngine();
//            Assert.IsFalse(x.ReadyForCalculation);

//            x.TryAddNumber("3");
//            Assert.IsFalse(x.ReadyForCalculation);

//            x.TryAddNumber("6");
//            Assert.IsTrue(x.ReadyForCalculation);
//        }

//        [TestMethod]
//        public void result_should_need_two_numbers()
//        {
//            var x = new AddNumberEngine();
//            Assert.ThrowsException<AddNumberEngine.NotReadyForResultException>(() => x.Result());

//            x.TryAddNumber("3");
//            Assert.ThrowsException<AddNumberEngine.NotReadyForResultException>(() => x.Result());

//            x.TryAddNumber("6");

//            var result = x.Result();

//        }

//        [TestMethod]
//        public void end_number_cant_be_lower_than_start_number()
//        {
//            var x = new AddNumberEngine();
//            x.TryAddNumber("3");

//            Assert.ThrowsException<AddNumberEngine.EndNumberCantBeLowerThanStartException>(() => x.TryAddNumber("1"));
//        }

//        [TestMethod]
//        public void three_numbers_or_more_cant_be_added()
//        {
//            var x = new AddNumberEngine();
//            x.TryAddNumber("3");
//            x.TryAddNumber("6");

//            Assert.ThrowsException<AddNumberEngine.AlreadyHaveTwoValuesException>(() => x.TryAddNumber("9"));
//        }

//    }
//}
