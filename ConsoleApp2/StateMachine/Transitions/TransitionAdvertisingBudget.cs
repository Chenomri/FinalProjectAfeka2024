using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.StateMachine
{
    public class TransitionAdvertisingBudget : Transition
    {
        public TransitionAdvertisingBudget(State sourceState, State destinationState, Action action) : base(sourceState, destinationState, action)
        {
        }

        public override void changeValue()
        {
            this.SourceState.advertisingBudget=(int)(calcChangeCost() * SourceState.advertisingBudget);
        }
    }
}
