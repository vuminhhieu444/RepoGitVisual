using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingGitInVisual.Model
{
    public class Person
    {
        int hand;
        int leg;
        string name;

        public int Hand { get => hand; set => hand = value; }
        public int Leg { get => leg; set => leg = value; }
        public string Name { get => name; set => name = value; }
    }
}
