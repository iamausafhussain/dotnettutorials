namespace atmtransactionTest
{
    [TestClass]
    public class AtmTransactionTest
    {
        [TestMethod]
        public void transaction_showbalance_test()
        {
            //Arrange
            var expected = true;
            var current_object = new ATM();

            //Act
            var result = current_object.showBalance();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void transaction_createtransaction_test()
        {
            //Arrange
            var expected = false;
            var input = "-100";
            var current_object = new ATM();

            //Act
            var reader = new StringReader(input);
            Console.SetIn(reader);
            var result = current_object.createTransaction();

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void transaction_cashdeposit_test()
        {
            //Arrange
            var current_object = new ATM();

            var expected = true;
            var input = "100";

            var expectedString = false;
            var inputString = "100f";

            //Act
            var reader = new StringReader(input);
            Console.SetIn(reader);
            var result = current_object.cashDeposit();

            var readerString = new StringReader(inputString);
            Console.SetIn(readerString);
            var resultString = current_object.cashDeposit();


            //Assert
            Assert.AreEqual(expected, result);

            Assert.AreEqual(expectedString, resultString);
        }
    }
}