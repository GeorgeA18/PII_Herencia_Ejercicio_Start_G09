namespace RideShare;

public interface IConductor{
    public string Vehicle{get; set;}
    public string Bio{get; set;}
    public int MaxPassenger{get; set;}
    public void PostOnTwitter();
}