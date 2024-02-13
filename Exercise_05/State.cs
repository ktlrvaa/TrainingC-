using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_05
{
    public class State
    {
        public double Population { get; set; } // население
        public double Area { get; set; }       // территория

        public State AddOfStates(State state1, State state2, State state3)
        {
            state3.Area = state1.Area + state2.Area;
            state3.Population = state1.Population + state2.Population;
            return state3;
        }
    }
}

