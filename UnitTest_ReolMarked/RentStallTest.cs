using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReolmarkedTeam15.Models;
using ReolmarkedTeam15.Repos;

namespace UnitTest_ReolMarked
{
    [TestClass]
    public sealed class RentStallTest
    {
        [TestMethod]
        public void AssignRenter_ShouldAssignRenterID_WhenCalled()
        {
            // Arrange
            var stallRepo = new MemoryStallRepo();
            var renterRepo = new MemoryRenterRepo();
            var stall = stallRepo.GetById(10); // Sample stall
            var renter = renterRepo.GetById(10); // Sample renter

            // Act
            stall.AssignRenter(renter.RenterID); // Assign renter to stall

            // Assert
            Assert.AreEqual(renter.RenterID, stall.RenterID); // Verify same ID exist
            Assert.AreEqual(Stall.AvailabilityStatus.Optaget, stall.Availability); // Verify status is updated
        }
    }
}