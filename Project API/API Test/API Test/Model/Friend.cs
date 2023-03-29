using System.Collections.Generic;

namespace API_Test.Model
{
    public class Friend
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        // public DateTime Birthday having trouble with DateTime will fix it later { get; set; }
        public string Likes { get; set; }
        public string Dislikes { get; set; }
        //public DateTime ImportantDates { get; set; }

        public Friend(int id, string firstName, string lastName, int age, string likes, string dislikes)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            //Birthday = birthday;
            Likes = likes;
            Dislikes = dislikes;
            //ImportantDates = importantDates;
        }

        
        
        public static List<Friend> GetFriends() => new List<Friend>
            // random list of names from "behindthename.com" I personally love this site and use it a lot in creative writing
            {
                new Friend(1,"John","Doe", 37, "Hiking, Camping", "Shopping, Movie Theaters"),
                new Friend(2,"Leonardo","Paternoster", 77, "Puzzles", "Movie Theaters"),
                new Friend(3,"Angelica","Dunbar", 19, "Exercise", "Drawing"),
                new Friend(4,"Irene","Dunbar", 27, "Gardening", "Running"),
                new Friend(5,"Noah","Jones", 23, "Dancing", "Hiking")

            };

    }
}
