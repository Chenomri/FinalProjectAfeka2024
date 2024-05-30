using System;
using System.Collections.Generic;

public class StateMachine
{
    private State currentState;
    private List<State> states;
    private List<Transition> transitions;

    public StateMachine()
    {
        // Initialize the list of states
        states = new List<State>();

        // Initialize the list of transitions
        transitions = new List<Transition>();
    }

    public void AddState(State state)
    {
        states.Add(state);
    }

    public void AddTransition(Transition transition)
    {
        transitions.Add(transition);
    }

    public void PerformAction(Action action)
    {

    }  
}
