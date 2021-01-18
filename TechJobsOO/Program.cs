using System.Collections.Generic;
using System;

namespace TechJobsOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Job emptyJob = new Job("omg wtf", new Employer(), new Location(), new PositionType(), new CoreCompetency());
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));

            List<Job> jobs = new List<Job>();
            {
                jobs.Add(emptyJob);
                jobs.Add(job1);
                jobs.Add(job2);
                jobs.Add(job3);
            }
            var dataNA = "Data not available";
            var wtfJob = jobs[0];
            var jobString = wtfJob.ToString();

            Console.WriteLine(jobString.Contains(dataNA));
            var field = jobString.Split("\n");


            //foreach (Job job in jobs)
            //{
            //    Console.WriteLine(job);
            //}
            Console.WriteLine( field);
            Console.WriteLine(string.Join("\n", field));
            Console.WriteLine(field[4]);
        }
    }
}
