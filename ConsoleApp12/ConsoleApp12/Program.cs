using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Card
    {
        private string Name;
        private long SynCode;
        private long ProjectId;

        public Card(string name, long synCode, long projectId)
        {
            Name = name;
            SynCode = synCode;
            ProjectId = projectId;
        }

        public Card()
        {
            Console.WriteLine($"Name = {Name}, SynCode = {SynCode}, ProjectId = {ProjectId}");
        }

        public string SetNewName(string name)
        {
            Name = name;
            Console.WriteLine("Name your card:");
            name = Convert.ToString(Console.ReadLine()); 
            return Name;
        }

        public long SetNewProjectId()
        {
            Console.WriteLine("Set ProjectId for new card" + ProjectId);
            Console.ReadKey();
            return ProjectId;
        }

        static void Main(string[] args)
        {
            Card pos = new Card();
            string name = pos.SetNewName();
            long synCode = 1;
            long id = pos.SetNewProjectId();
        }

    }
}
