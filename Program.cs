using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

        
            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // Artist vernonPerson = Artists.Where(person => person.Hometown == "Mount Vernon").Single();
            // System.Console.WriteLine(vernonPerson.RealName+" "+vernonPerson.Age);

            // //Who is the youngest artist in our collection of artists?
            // IEnumerable<Artist> youngins = Artists.OrderBy(ageList => ageList.Age).ToList();
            // foreach(Artist artist in youngins)
            // {
            //     System.Console.WriteLine(artist.ArtistName +" "+ artist.Age);
            // }

            // //Display all artists with 'William' somewhere in their real name
            // IEnumerable<Artist> wills = Artists.Where(n => n.RealName.Contains("William"));
            // foreach(Artist artist in wills)
            // {
            //     System.Console.WriteLine(artist.ArtistName +" - "+ artist.RealName);
            // }

            // //Display the 3 oldest artist from Atlanta
            // List<Artist> oldATL = Artists.Where(a => a.Hometown == "Atlanta" ).OrderBy(a => a.Age).Reverse().Take(3).ToList();
            // foreach(Artist artist in oldATL)
            // {
            //     System.Console.WriteLine($"{artist.ArtistName} - {artist.Age}");
            // }

            // //(Optional) Display the Group Name of all groups that have members that are not from New York City
            // IEnumerable<Artist> notNYC = Artists.Where(m => m.Hometown != "New York City");
            // List<Group> squad = Groups.Join(notNYC, group => group.Id, member => member.GroupId, (group, member) => {return group;}).Distinct().ToList();
            // foreach(Group s in squad)
            // {
            //     System.Console.WriteLine(s.GroupName);
            // }
            

            // //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            // Group wutang = Groups.Where(g => g.GroupName == "Wu-Tang Clan").Single();
            // IEnumerable<Artist> wutangMembers = Artists.Where(m => m.GroupId == wutang.Id);
            // foreach(Artist m in wutangMembers)
            // {
            //     System.Console.WriteLine(m.ArtistName);
            // }

            //Display all groups with names less than 8 characters in length.
            IEnumerable<Group> shortGroups = Groups.Where(g => g.GroupName.Length < 8);
            foreach(Group g in shortGroups)
            {
                System.Console.WriteLine(g.GroupName);
            }
        }
    }
}
