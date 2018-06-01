//Publisher class components
public class publisher{
  
  public event EventHandler EventName; //define the event if no custom data
  public void Raiser(EventArg e){
    if(EventHandler!=null){
      EventHandler(this, e); //raise the event
    }
  }
}
public class listeners{
  private void response(object sender, TemperatureEven){
  //do things here, every class can have unique response and will be execute when event is raised
  }
}
public Main(){
  publisher exp=new publisher();
  listener lsn=new Listener();
  publisher.EventName+=lsn.response; //register the respons in instance
}
