using System;
using System.Security.Cryptography.X509Certificates;

namespace Indexer
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }
            //indexer get and set methods
            public string this[int index]
            {
                get
                {
                    string tmp;
                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return (tmp);
                }//end get
                set
                {
                    if (index >= 0 && index <= Size -1)
                    {
                        Members[index] = value;
                    }
                }//end set
            }//end clubmembers
        }
        static public void Main(string[] args)
        {
            //create a new ClubMembers object
            ClubMembers Member = new ClubMembers();

            Member[0] = "Donald Duck";
            Member[1] = "Goofy";
            Member[2] = "Mickey Mouse";
            Member[3] = "Daisy Duck";
            Member[4] = "Pluto";
            Member.ClubType = "Tennis";
            Member.ClubLocation = "Michigan";
            Member.MeetingDate = "April";


            //Display the club information
            Console.WriteLine("Club Member Information: ");
            for (int i = 0; i < Size; i++)
            {
                if (Member[i] != string.Empty)
                {
                    Console.WriteLine($"{i+1}. {Member[i]}");
                }
            }
            Console.WriteLine($"Club Type: {Member.ClubType}");
            Console.WriteLine($"Club Location: {Member.ClubLocation}");
            Console.WriteLine($"Meeting Date: {Member.MeetingDate}");
        }//end main
    } //end program class
}//end namespace