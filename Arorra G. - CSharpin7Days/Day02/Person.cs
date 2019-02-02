/* 4. Person */
using System;

namespace Day02
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
    }

    public class Author : Person
    {
        public override string Name { get; set; }
    }

    public class Reviewer : Person
    {
        public override string Name { get; set; }
    }

    public class TeamMember : Person
    {
        public override string Name { get; set; }
        public void GetMemberName()
        {
            Console.WriteLine($"Member name:{Name}");
        }
    }

    public class ContentMember : TeamMember
    {
        public override string Name { get; set; }

        public ContentMember(string name)
        {
            base.Name = name;
        }
        public void GetContentMemberName()
        {
            base.GetMemberName();
        }
    }

    public class Stackholder
    {
        public void GetAuthorName(Person person)
        {
            var authorName = person as Author;
            Console.WriteLine(authorName != null ? $"Author is {authorName.Name}" : "No author");
        }

        public void GetStackholdersName(Person person)
        {
            if (person is Author)
                Console.WriteLine($"Author name: {((Author)person).Name}");
            else if (person is Reviewer)
                Console.WriteLine($"Reviewer name: {((Reviewer)person).Name}");
            else if (person is TeamMember)
                Console.WriteLine($"TeamMember name: {((TeamMember)person).Name}");
            else if (person is ContentMember)
                Console.WriteLine($"Content name: {((ContentMember)person).Name}");
            else
                Console.WriteLine("Not a valid name");
        }
    }
}
