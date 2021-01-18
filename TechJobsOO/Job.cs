﻿using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: ++Add the two necessary constructors.

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location location, PositionType jobType, CoreCompetency coreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = location;
            JobType = jobType;
            JobCoreCompetency = coreCompetency;
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return $" \n\nID : {Id}\nName : {Name}\nEmployer : {EmployerName}\nLocation : {EmployerLocation}\nPosition Type : {JobType}\nCore Competency : {JobCoreCompetency}  \n\n ";
        }

    }
}
