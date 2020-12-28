using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        //[TestInitialize]
        //public void InitializeJob()
        //{
        //   var _job = new Job();
        //}

        [TestMethod]
        public void TestSettingJobId()
        {
            //arrange
            var _job = new Job();
            var _job2 = new Job();

            Assert.IsTrue(_job2.Id -_job.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            var _job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", _job.Name);
            Assert.IsNotNull(_job.EmployerName);
            Assert.AreEqual("Quality control", _job.JobType.ToString());
            Assert.IsNotNull(_job.JobCoreCompetency);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            var _job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            var _job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(_job.Equals(_job2));
        }
    }
}
