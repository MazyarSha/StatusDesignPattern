using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusDesignPattern
{
    public interface MobileAlertState
    {
        public void Alert(AlertStateContext alertStateContext);
    }
    public class Vibration : MobileAlertState
    {
        public void Alert(AlertStateContext alertStateContext)
        {
            Console.WriteLine("Vibration");
        }
    }
    public class Silent : MobileAlertState
    {
        public void Alert(AlertStateContext alertStateContext)
        {
            Console.WriteLine("Silent");
        }
    }
    public class AlertStateContext
    {
        public MobileAlertState CurrentState { get; set; }
        public AlertStateContext()
        {
            CurrentState = new Vibration();   
        }
        public void setState(MobileAlertState State)
        {
            CurrentState = State;
        }
        public void Alert()
        {
            CurrentState.Alert(this);
        }
    }

}
