using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Maze2SL5.Web
{
    [DataContract]
    public class clsRace
    {
        private int _raceTime;
        private string _racerName;
        private string _os;
        private string _mouse;
        private string _computer;
        private string _level;
        private String _hashgroup = null;
        private int _id;
        private int _rank;
        private int _hashrank;

        [DataMember]
        public int Maze_Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }

        [DataMember]
        public int Maze_Rank
        {
            get { return _hashrank; }
            set { _hashrank = value; }
        }

        [DataMember]
        public string Maze_HashGroup
        {
            get { return _hashgroup; }
            set { _hashgroup = value; }
        }

        [DataMember]
        public int Race_ID
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        public string Maze_MaxLevel
        {
            get { return _level; }
            set { _level = value; }
        }

        [DataMember]
        public string Maze_Computer
        {
            get { return _computer; }
            set { _computer = value; }
        }

        [DataMember]
        public string Maze_Mouse
        {
            get { return _mouse; }
            set { _mouse = value; }
        }

        [DataMember]
        public string Maze_OS
        {
            get { return _os; }
            set { _os = value; }
        }

        [DataMember]
        public string Maze_Name
        {
            get { return _racerName; }
            set { _racerName = value; }
        }

        [DataMember]
        public int Maze_Time
        {
            get { return _raceTime; }
            set { _raceTime = value; }
        }
    }
}
