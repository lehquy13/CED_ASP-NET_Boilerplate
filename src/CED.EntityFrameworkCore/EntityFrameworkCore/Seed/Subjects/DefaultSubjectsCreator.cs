using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CED.Subjects;

namespace CED.EntityFrameworkCore.Seed.Host
{
    public class DefaultSubjectsCreator
    {
        public static List<Subject> InitialSubjects => GetInitialSubjects();

        private readonly CEDDbContext _context;

        private static List<Subject> GetInitialSubjects()
        {
            return new List<Subject>
            {
                new Subject
                {
                    Name = "Maths"
                },
                new Subject
                {
                    Name = "Programming"
                },
                new Subject
                {
                    Name = "Psychology"
                },
                new Subject
                {
                    Name = "English"
                },
                new Subject
                {
                    Name = "Vietnamese"
                },
                new Subject
                {
                    Name = "Korean"
                },
                new Subject
                {
                    Name = "German"
                },
                new Subject
                {
                    Name = "Russian"
                },
                new Subject
                {
                    Name = "French"
                },
                new Subject
                {
                    Name = "Mandarin"
                },
                new Subject
                {
                    Name = "Chemistry"
                },
                new Subject
                {
                    Name = "Physics"
                },
                new Subject
                {
                    Name = "Chemistry"
                },
                new Subject
                {
                    Name = "Biology"
                },
                new Subject
                {
                    Name = "Information technology"
                },
                new Subject
                {
                    Name = "Algebra"
                },
                new Subject
                {
                    Name = "Geometry"
                },
                new Subject
                {
                    Name = "Geography"
                },
                new Subject
                {
                    Name = "Literature"
                },
                new Subject
                {
                    Name = "Martial Art"
                },
                new Subject
                {
                    Name = "Guitar"
                },
                new Subject
                {
                    Name = "Design"
                },

                new Subject
                {
                    Name = "Visual Art"
                },
                new Subject
                {
                    Name = "Music"
                },
                new Subject
                {
                    Name = "Singing"
                },
                new Subject
                {
                    Name = "Statistic"
                },
                new Subject
                {
                    Name = "Others"
                }
            };
        }
            

        public DefaultSubjectsCreator(CEDDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateSubjects();
        }

        private void CreateSubjects()
        {
            foreach (var subject in InitialSubjects)
            {
                AddSubjectIfNotExists(subject);
            }
        }

        private void AddSubjectIfNotExists(Subject subject)
        {
            if (_context.Subjects.IgnoreQueryFilters().Any(l => l.Name == subject.Name))
            {
                return;
            }

            _context.Subjects.Add(subject);
            _context.SaveChanges();
        }
    }
}
