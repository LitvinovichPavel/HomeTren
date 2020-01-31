using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GlobalMotocycleServiceModule
{
    public class MotocycleService
    {
        //public static int TotalDistance { get; set; }
        public static int DistanceFromLastService { get; set; }
        public MotocycleService()
        {
            CheckDistance();
        }
        void CheckDistance()
        {
            if (DistanceFromLastService >= 9_800)
            {
                //Notify
                NotifyAboutService();
            }
        }
        void NotifyAboutService()
        {
            //?
        }
        void ResetDistance()
        {
        }

    }
}
