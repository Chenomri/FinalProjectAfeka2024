
public abstract class Transition
{
    public State SourceState { get; set; }
    public State DestinationState { get; set; }
    public Action action { get; set; }

    public Transition(State sourceState, State destinationState, Action action)
    {
        SourceState = sourceState;
        DestinationState = destinationState;
        this.action = action;
    }

    public double calcChangeCost()
    {
        double changeCost= action.PercentageChange%100;
        if(action ==null)
            return 0;
        if(action.isMorePercentage==true)
            return 1+changeCost;
        return 1-changeCost;
    }

    public abstract void changeValue();

   
}

