using Collections;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
       //Empty test class
       //please add your tests about Collection.cs here 
     

      [Test]
      public void Test_Add_Three_Items()
        {
            // this works only for INT items 

            //this is arrange section
            Collection<int> nums = new Collection<int>();

            //Act
            nums.Add(5);
            nums.Add(10);
            nums.Add(15);

            //Assert
            Assert.AreEqual(3, nums.Count);


        }

    }
}