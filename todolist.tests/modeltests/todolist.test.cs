using Microsoft.VisualStudio.TestTools.UnitTesting;
using todolist.Models;

namespace todolist.tests
{
    [TestClass]
    public class ItemTests
    {

        [TestMethod]
        public void ItemConstructor_CreateInstanceOfItem_Item()
        {
            Item newItem = new Item();
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            string description = "Walk the dog.";
            Item newItem = new Item(description);
            string result = newItem.Description;
            Assert.AreEqual(description, result);
        }
    }
}