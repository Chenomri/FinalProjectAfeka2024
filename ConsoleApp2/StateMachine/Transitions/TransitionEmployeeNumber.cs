using ConsoleApp2.Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.StateMachine
{
    public class TransitionNumberEmployee : Transition
    {
        public TransitionNumberEmployee(State sourceState, State destinationState, Action action) : base(sourceState, destinationState, action)
        {
        }

        public override void changeValue()
        {
            int numChangeEmploy = (int)(this.SourceState.numberOfEmployees * calcChangeCost() - this.SourceState.numberOfEmployees);

            if (numChangeEmploy < 0)
            {
                for (int i = 0; i < numChangeEmploy; i++)
                {

                    SourceState.RemoveEmployee(i);
                }
            }
            else
                for (int i = 0; i < numChangeEmploy; i++)
                {
                    SourceState.AddEmployee(1, DataFolder.AddData.);
                }
        }
    }
}
