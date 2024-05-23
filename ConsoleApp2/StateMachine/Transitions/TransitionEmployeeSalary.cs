using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.StateMachine.Transitions
{
    public class TransitionEmployeeSalary : Transition
    {
        public TransitionEmployeeSalary(State sourceState, State destinationState, Action action) : base(sourceState, destinationState, action)
        {
        }
        public override void changeValue()
        {
            for (int i = 0; i < SourceState.numberOfEmployees; i++)
            {
                SourceState.employeeArr[i].setSalary((int)(SourceState.employeeArr[i].getSalary() * calcChangeCost()));
            }
        }
    }
}
