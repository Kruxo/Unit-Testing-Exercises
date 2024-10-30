using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workout.Test.Level2
{
    [TestClass]
    public class ElevatorGoUpAndDownTest
    {
        /*
        Hissen börjar på våning 0. 
        För varje "UPP" åker den upp en våning
        För varje "NER" åker den ner en våning
        */
        [TestMethod]
        [DataRow(null, 2, new[] { "UPP", "NER", "UPP", "UPP" })]
        [DataRow(null, -3, new[] { "NER", "NER", "NER" })]
        [DataRow(null, -1, new[] { "NER" })]
        [DataRow(null, 3, new[] { "UPP", "UPP", "UPP" })]
        [DataRow(null, 1, new[] { "UPP" })]
        [DataRow(null, 0, null)]

        public void elevator_go_up_and_down(object dummy, int expected, string[] input)
        {
            throw new NotImplementedException();
        }

        public int ElevatorGoUpAndDown(IEnumerable<string> list)
        {
            throw new NotImplementedException();
        }

        public int ElevatorGoUpAndDown_Linq(IEnumerable<string> list)
        {
            throw new NotImplementedException();
        }

        public int ElevatorGoUpAndDown_Linq_OneLiner(IEnumerable<string> list)
        {
            throw new NotImplementedException();
        }

    }
}
