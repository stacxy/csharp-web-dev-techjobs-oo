using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        private Job _job;
        
        [TestInitialize]
        public void InitializeJob()
        {
            _job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            //arrange
            var job = new Job();
            var job2 = new Job();

            Assert.IsTrue(job2.Id - job.Id == 1);
        }
        
        

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //var _job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.AreEqual("Product tester", _job.Name);
            Assert.IsNotNull(_job.EmployerName);
            Assert.AreEqual("Quality control", _job.JobType.ToString());
            Assert.IsNotNull(_job.JobCoreCompetency);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
           // var _job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            var _job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsFalse(_job.Equals(_job2));
        }

        [TestMethod]
        public void TestJobToString_ReturnsBlankLines()
        {
            //var _job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            var jobString = _job.ToString();
            var firstLine = jobString[0];
            var i = jobString.LastIndexOf(' ');
            var lastLine = jobString[i];

            Assert.AreEqual(firstLine, ' ');
            Assert.AreEqual(lastLine, ' ');
        }

        [TestMethod]
        public void TestJobToString_eachFieldContainsOwnLine_LabelThenData()
        {
            var jobString = _job.ToString();
            var fields = jobString.Split("\n");
            var employerData = fields[3];

            Assert.AreEqual(employerData, "Employer : ACME");
        }

        [TestMethod]
        public void TestJobToString_emptyField_dataNotAvailable()
        {
            var emptyJob = new Job("Empty job", new Employer(), new Location(), new PositionType(), new CoreCompetency()); ;
            var jobString = emptyJob.ToString();
            var dataNA = "Data not available";

            Assert.IsTrue(jobString.Contains(dataNA));

        }
    }
}
