namespace RollTheDiceTest;

[TestClass]
public class RollTheDiceTest
{
    /*
        Test the creation of a die. Check if the value of a die does not exceed the specified sides. For example a six sided dice should have a rolled a value BETWEEN 1 and 6 (inclusive). Also check if both fields have been set correctly.

        Use the following Assert methods:
        - Assert.AreEqual
        - Assert.IsNotNull
        - Assert.IsTrue
    */
    [TestMethod]
    public void Create_Die()
    {
        Die testDie = new(6, "blue");
        Assert.AreEqual(6, testDie.Sides);
        testDie.Roll();
        Assert.IsTrue(testDie.Value <= 6 && testDie.Value >= 1);
        Assert.IsNotNull(testDie.Color);
    }

    /*
        Test the Roll method of multiple dice (4,6,8,10 and 20 sided). Like in the Create_Die test, check if the value of a die does not exceed the specified sides. For each die, call the Roll method 10 times (in a for loop) and assert the result after each method call.

        Use the following Assert methods:
        - Assert.IsTrue
    */
    [DataTestMethod]
    [DataRow(4)]
    [DataRow(6)]
    [DataRow(8)]
    [DataRow(10)]
    [DataRow(20)]
    public void Roll_Die(int sides)
    {
        Die testDie = new(sides, "purple");

        for (int roll = 0; roll < 10; roll++)
        {
            testDie.Roll();
            Assert.IsTrue(testDie.Value <= sides && testDie.Value >= 1);
        }
    }

    /*
        Test the creation of an empty DiceBag object. Check that the Dice field is not NULL and contains zero dice objects.
        
        Use the following Assert methods:
        - Assert.IsNotNull
        - Assert.AreEqual
    */
    [TestMethod]
    public void Create_DiceBag()
    {
        DiceBag emptyBag = new();
        Assert.IsNotNull(emptyBag.Dice);
        Assert.AreEqual(0, emptyBag.Dice.Count);
    }

    /*
        Test the Add method by adding multiple sided dice to a dice bag. Check that the Dice field contains the correct number of dice, that all dice contained in the Dice field are not NULL and that the values of all dice do not exceed the specified sides.
        
        Use the following Assert methods:
        - Assert.AreEqual
        - Assert.IsTrue
        - CollectionAssert.AllItemsAreNotNull
    */
    [TestMethod]
    public void Add_DiceToDiceBag()
    {
        List<int> lSides = new() { 4, 6, 8, 10, 20, 100 };

        // create new dice bag
        DiceBag testBag = new();

        foreach (int side in lSides)
        {
            // create a die for each side in the lSides list
            testBag.Add(new Die(side, "pink"));
        }

        // asserts
        int sidesCnt = 0;
        foreach (Die d in testBag.Dice)
        {
            Assert.AreEqual(lSides[sidesCnt], d.Sides);
            sidesCnt += 1;
        }
    }

    /*
        Test the Reroll method of a dice bag after adding multiple sided dice to a dice bag. Check if the current value of all die in the dice bag does not exceed the specified sides.
        
        Use the following Assert methods:
        - Assert.IsTrue
    */
    [TestMethod]
    public void Reroll_AllDiceInDiceBag()
    {
        List<int> lSides = new() { 4, 6, 8, 10, 20, 100 };

        // create new dice bag
        DiceBag testBag = new();

        foreach (int side in lSides)
        {
            // create a die for each side in the lSides list
            testBag.Add(new Die(side, "pink"));
        }

        // reroll all the dice in the bag
        testBag.Reroll();
        
        int sidesCnt = 0;
        foreach (Die d in testBag.Dice)
        {
            // asserts
            Assert.IsTrue(d.Value <= lSides[sidesCnt] && d.Value >= 1);
            sidesCnt += 1;
        }
    }
}