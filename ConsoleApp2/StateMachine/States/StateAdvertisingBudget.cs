using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace ConsoleApp2.StateMachine.States
{
    public class StateAdvertisingBudget
    {
       public State previousState;
       public Action act;
       
        public StateAdvertisingBudget(State previousState, Action act)
        {
            this.previousState = previousState;
            this.act = act;
        }

        public void UpdateStoreValues()
        {

        }


    }


}
