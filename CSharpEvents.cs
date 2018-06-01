//Publisher class components
public delegate EventHandler(); //could use the default system one or override custometically with inherited eventargs
public class publisher{
  
  public event EventHandler EventName; //define the event
  public void Raiser(){
    if(EventHandler!=null){
      EventHandler(); //raise the event
    }
  }
}
public class listeners{
  private void response(object sender, TemperatureEven){
  //do things here, every class can have unique response and will be execute when event is raised
  }
}
