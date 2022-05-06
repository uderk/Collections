using Collections;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
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

            int result = nums[0];
            //Assert
            Assert.AreEqual(3, nums.Count);
            
        } 

      [Test]
      public void Test_AddRange()
        {
            //arange 
            Collection<int> nums = new Collection<int>();
            //act
            nums = new Collection<int>(new int[] { 10, 20, 30,45,55 });
            int counted = nums.Count;
            //Assert 
            Assert.AreEqual(5, nums.Count);
        }

        [Test]
        public void Test_InsertAt_Shoud_Throw_Exeption()
        {
           
            //Arange
            Collection<int> nums = new Collection<int>();
           
            //Act and Assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => nums.InsertAt(10, 15));
        }
       
        [Test]
        public void Test_InsertAt_ShouldWork()
        { 
            //Arrage
            Collection<int> nums = new Collection<int>(20);

            // nums = new Collection<int>(new int[] { 10, 20, 30, 45, 55 });
            //  nums.InsertAt(2, 15);

            for (int i = 0; i < 20; i++)
            {
                nums.Add(0);
            }

            nums.InsertAt(10, 15);

            Assert.AreEqual(15, nums[10]);
        }  

        [Test] 
        public void Test_Exchange()
        {
            // Arrange 
            Collection<int> nums = new Collection<int>();
            nums = new Collection<int>(new int[] { 10, 20, 30, 45, 55 });
            //Act 
            nums.Exchange(0, 1);
            //Assert 
            Assert.AreEqual(20, nums[0]);
            Assert.AreEqual(10, nums[1]);
        }

        [Test]
        public void Test_RemoveAt()
        {
            // Arrange 
            Collection<int> nums = new Collection<int>();
            nums = new Collection<int>(new int[] { 10, 20, 30, 45, 55 });
            //Act 
            nums.RemoveAt(1);
            //Assert
            Assert.AreNotEqual(20, nums[1]);
        }

        [Test]
        public void Test_Clear()
        {
            //Arrange
            Collection<int> nums = new Collection<int>();
            nums = new Collection<int>(new int[] { 10, 20, 30, 45, 55 });
            //Act
            nums.Clear();
            //Arrange
            Assert.IsEmpty(nums.ToString()); //probably method is not correct, should be discussed 
        }
    }
}