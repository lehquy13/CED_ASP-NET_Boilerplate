﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;

namespace CED.ClassInformations
{
    public class ClassInformation : FullAuditedAggregateRoot<Guid>
	{
		public string Title { get; set; } 
		public string Description { get; set; } 
		public Status Status { get; set; } 
		public LearningMode LearningMode { get; set; }

		public float Fee { get; set; } 
		public float ChargeFee { get; set; }

		//Tutor related information
		public Gender GenderRequirement { get; set; }
		public AcademicLevel AcademicLevel { get; set; }

		//Student related information
		public Gender StudentGender { get; set; }
		public int NumberOfStudent { get; set; }

		// Time related information
		public int MinutePerSession { get; set; }
		public int SessionPerWeek { get; set; }
		public List<AvailableDate> AvailableDates { get; set; }

		// Address related information
		public string Address { get; set; }

		//Subject related information
		public Guid SubjectId { get; set; }

	}

    public enum AcademicLevel
    {
        Optional,
        Student,
        Teacher,
    }

    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Gender
    {
        Male,
        Female,
        Other,
        Both
    }

    public enum LearningMode
    {
        Online,
        Offline,
        Hybrid
    }

    public enum Status
    {
        Waiting,
        Confirmed,
        Canceled,
        OnConfirming
    }
    public enum UserRole
    {
        Undefined,
        Admin,
        Tutor,
        Student
    }
}
