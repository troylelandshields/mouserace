using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace Maze2SL5.Web
{
    [ServiceContract(Namespace = "www.troylelandshields.me")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ServiceDB
    {
        [OperationContract]
        public List<clsRace> getRaces()
        {
            var db = new DataClasses1DataContext();
            
            var races = (from Maze_Race in db.Maze_Races
                        orderby Maze_Race.Maze_Time
                        select Maze_Race);
            
            List<clsRace> raceList = new List<clsRace>();

            foreach (var race in races)
            {
                if (!race.Maze_Name.Contains("test") && (!race.Maze_Name.Contains("Test")))
                {
                    raceList.Add(new clsRace(){
                        Maze_Name = race.Maze_Name,
                        Maze_Time = (int)race.Maze_Time,
                        Maze_Mouse = race.Maze_Mouse,
                        Maze_OS = race.Maze_OS,
                        Maze_Computer = race.Maze_Computer,
                        Maze_MaxLevel = race.Maze_MaxLevel
                        Maze_Rank;
                    });
                }
            }

            return raceList;
        }

        [OperationContract]
        public List<clsRace> getHashRaces(string hashtag)
        {
            List<clsRace> hashedRaces = new List<clsRace>();

            var db = new DataClasses1DataContext();

            var races = (from Maze_Race in db.Maze_Races
                         where Maze_Race.Maze_HashGroup == hashtag
                         orderby Maze_Race.Maze_Time
                         select Maze_Race);

            foreach (var race in races)
            {
                //if (!race.Maze_Name.Contains("test") && !race.Maze_Name.Contains("Test"))
                //{
                    hashedRaces.Add(new clsRace()
                    {
                        Maze_Name = race.Maze_Name,
                        Maze_Time = (int)race.Maze_Time,
                        Maze_Mouse = race.Maze_Mouse,
                        Maze_OS = race.Maze_OS,
                        Maze_Computer = race.Maze_Computer,
                        Maze_MaxLevel = race.Maze_MaxLevel,
                        Maze_HashGroup = race.Maze_HashGroup
                    });
                //}
            }

            return hashedRaces;
        }

        [OperationContract]
        public void addRace(clsRace r)
        {
            var db = new DataClasses1DataContext();

            Maze_Race rt = new Maze_Race();

            rt.Maze_Computer = r.Maze_Computer;
            rt.Maze_MaxLevel = r.Maze_MaxLevel;
            rt.Maze_Mouse = r.Maze_Mouse;
            rt.Maze_Name = r.Maze_Name;
            rt.Maze_OS = r.Maze_OS;
            rt.Maze_Time = r.Maze_Time;
            rt.Maze_HashGroup = r.Maze_HashGroup;

            db.Maze_Races.InsertOnSubmit(rt);

            db.SubmitChanges();


        }

        // Add more operations here and mark them with [OperationContract]
    }
}
