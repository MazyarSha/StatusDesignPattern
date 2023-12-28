using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatusDesignPattern
{
    public interface TvPowerAction
    {
        void Status(Tv tv);
    }
    public class OnStatus : TvPowerAction
    {
        public void Status(Tv tv)
        {
            Console.WriteLine("Off");
            tv.tvPowerAction = new OffStatus();
        }
    }
    public class OffStatus: TvPowerAction 
    {
        public void Status(Tv tv)
        {
            Console.WriteLine("On");
            tv.tvPowerAction = new OnStatus();

        }
    }
    public class Tv
    {
        public Tv()
        {
            tvPowerAction = new OffStatus();
        }
        public TvPowerAction tvPowerAction { get; set; }
        public void PowerPush()
        {
            tvPowerAction.Status(this);
        }
    }
}
