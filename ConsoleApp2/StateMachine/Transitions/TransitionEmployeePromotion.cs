using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.StateMachine
{
    public class TransitionPromotionEmployee : Transition
    {
        public int Bonus;

        public TransitionPromotionEmployee(State sourceState, State destinationState, Action action) : base(sourceState, destinationState, action)
        {
        }
        public override void changeValue()
        {
            for(int i =0; i< SourceState.numberOfProducts; i++)
            {
                SourceState.employeeArr[i].setManagementLevel(SourceState.employeeArr[i].getManagementLevel() + 1);
                SourceState.employeeArr[i].setSalary(SourceState.employeeArr[i].getSalary() + Bonus * SourceState.employeeArr[i].getManagementLevel());
            }
        }
    }
}
