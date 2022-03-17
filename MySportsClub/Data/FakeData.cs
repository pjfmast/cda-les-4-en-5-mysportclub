﻿using MySportsClub.Infrastructure;
using MySportsClub.Models;

namespace MySportsClub.Data
{
    public static class FakeData
    {

        public static List<Member> FakeMembers
            = new() {
                new Member{ID= 1, Name = "Esther", Email = "esther@gmail.com", StartMembership = new DateTime(2014, 10, 8)},
                new Member{ID= 2, Name = "Anton", Email = "anton@gmail.com", StartMembership = new DateTime(2018, 1, 5)},
                new Member{ID= 3, Name = "Manon", Email = "manon@avans.com", StartMembership = new DateTime(2016, 6, 1)},
                new Member{ID= 4, Name = "Joke", Email = "joke@avd.com", StartMembership = new DateTime(2019, 1, 10)},
                new Member{ID= 5, Name = "Jeroen", Email = "jeroen@gmail.com", StartMembership = new DateTime(2020, 1, 15)},
                new Member{ID= 6, Name = "Ellen", Email = "ellen@breda.nl", StartMembership = new DateTime(2010, 5, 8)},
                new Member{ID= 7, Name = "Eva", Email = "eva@edu.org", StartMembership = new DateTime(2012, 9, 1)},
                new Member{ID= 8, Name = "Anke", Email = "anke@bandw.com", StartMembership = new DateTime(2015, 12, 10)},
                new Member{ID= 9, Name = "Koen", Email = "koen@gmail.com", StartMembership = new DateTime(2015, 4, 16)},
                new Member{ID= 10, Name = "Paul", Email = "pjfmast@gmail.com", StartMembership = new DateTime(2014, 12, 22)},
            };


        private static readonly DateTime today = DateTime.Now;

        public static List<Workout> FakeWorkouts
            = new() {
                new Workout{ID= 1, Title = "Yin Yoga", Instructor = "Marcel", Location = "Yoga studio", StartTime = today.NextDayAt(DayOfWeek.Monday, 10, 15), EndTime = today.NextDayAt(DayOfWeek.Monday, 11, 0), CapacityLeft = 35},
                new Workout{ID= 2, Title = "Pilates",Instructor = "Babs",  Location = "Yoga studio", StartTime = today.NextDayAt(DayOfWeek.Monday, 17, 0), EndTime = today.NextDayAt(DayOfWeek.Monday, 18, 0), CapacityLeft = 30},
                new Workout{ID= 3, Title = "Hot Yoga",Instructor = "Silvia",  Location ="Yoga studio", StartTime = today.NextDayAt(DayOfWeek.Tuesday, 10, 15), EndTime = today.NextDayAt(DayOfWeek.Tuesday, 11, 15), CapacityLeft=35},
                new Workout{ID= 4, Title = "Club Power", Instructor = "Marie Jose", Location = "Room 1",StartTime = today.NextDayAt(DayOfWeek.Tuesday, 19, 15), EndTime = today.NextDayAt(DayOfWeek.Tuesday, 20, 15), CapacityLeft=30},
                new Workout{ID= 5, Title = "XCO", Instructor = "Eva", Location = "Room 2",StartTime = today.NextDayAt(DayOfWeek.Wednesday, 9, 15), EndTime = today.NextDayAt(DayOfWeek.Wednesday, 10, 15), CapacityLeft=25},
                new Workout{ID= 6, Title = "B&K Training", Instructor = "Emilio", Location = "Boxing Area",StartTime = today.NextDayAt(DayOfWeek.Wednesday, 10, 15), EndTime = today.NextDayAt(DayOfWeek.Wednesday, 11, 15), CapacityLeft= 16},
                new Workout{ID= 7, Title = "Callanetics", Instructor = "Babette", Location = "Room 1", StartTime = today.NextDayAt(DayOfWeek.Wednesday, 19, 15), EndTime = today.NextDayAt(DayOfWeek.Wednesday, 20, 0), CapacityLeft=35},
                new Workout{ID= 8, Title = "Spinning", Instructor = "Jeroen", Location = "Room 4", StartTime = today.NextDayAt(DayOfWeek.Thursday, 10, 15), EndTime = today.NextDayAt(DayOfWeek.Thursday, 11, 15), CapacityLeft=18},
                new Workout{ID= 9, Title = "Vinyasa Yoga", Instructor = "Silvia", Location ="Yoga studio", StartTime = today.NextDayAt(DayOfWeek.Thursday, 17, 15), EndTime = today.NextDayAt(DayOfWeek.Thursday, 18, 15), CapacityLeft=30},
                new Workout{ID= 10, Title = "TBW", Instructor = "Anke", Location = "Room 1", StartTime = today.NextDayAt(DayOfWeek.Friday, 10, 15), EndTime = today.NextDayAt(DayOfWeek.Friday, 11, 0), CapacityLeft=35},
                new Workout{ID= 11, Title = "Shred and Burn", Instructor = "Emilio", Location = "Room 2", StartTime = today.NextDayAt(DayOfWeek.Friday, 10, 30), EndTime = today.NextDayAt(DayOfWeek.Friday, 11, 15), CapacityLeft=12},
                new Workout{ID= 12, Title = "Cycle Interval", Instructor = "Mirjam", Location = "Cycle Area", StartTime = today.NextDayAt(DayOfWeek.Friday, 18, 15), EndTime = today.NextDayAt(DayOfWeek.Friday, 19, 15), CapacityLeft=8},
                new Workout{ID= 13, Title = "Spinning", Instructor = "Ronn", Location = "Cycle Area", StartTime = today.NextDayAt(DayOfWeek.Saturday, 9, 15), EndTime = today.NextDayAt(DayOfWeek.Saturday, 10, 15), CapacityLeft=12},
                new Workout{ID= 14, Title = "SoulRide", Instructor = "Lonneke", Location = "Cycle Area", StartTime = today.NextDayAt(DayOfWeek.Sunday, 10, 15), EndTime = today.NextDayAt(DayOfWeek.Sunday, 11, 15), CapacityLeft=6},
            };


        public static List<Enrollment> FakeEnrollments
            = new() {
                new Enrollment{ID= 1, MemberID=1, WorkoutID=1},
                new Enrollment{ID= 2, MemberID=1, WorkoutID=4},
                new Enrollment{ID= 3, MemberID=2, WorkoutID=2},
                new Enrollment{ID= 4, MemberID=2, WorkoutID=5},
                new Enrollment{ID= 5, MemberID=2, WorkoutID=14},
                new Enrollment{ID= 6, MemberID=3, WorkoutID=4},
                new Enrollment{ID= 7, MemberID=3, WorkoutID=8},
                new Enrollment{ID= 8, MemberID=4, WorkoutID=1},
                new Enrollment{ID= 9, MemberID=4, WorkoutID=4},
                new Enrollment{ID= 10,MemberID=4, WorkoutID=10},
                new Enrollment{ID= 11,MemberID=4, WorkoutID=13},
                new Enrollment{ID= 12,MemberID=10, WorkoutID=5},
            };
    }
}
