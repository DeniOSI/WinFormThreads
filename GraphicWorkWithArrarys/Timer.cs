using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace GraphicWorkWithArrarys
{
   public class Timer
    {
     public   Thread thrd;
        Timess _tm;
        public string CurrentTime { get; set; }
        public Timer(Timess tm)
            {
            _tm = tm;
            thrd = new Thread(new ThreadStart(this.Run));
            thrd.IsBackground = true;
            thrd.Start();
      
            }
        public void Run()
        {
            
            while(true)
            {

                _tm(DateTime.Now.ToString("T"));
            //    Thread.Sleep(100);
            }
        }
    }
}
