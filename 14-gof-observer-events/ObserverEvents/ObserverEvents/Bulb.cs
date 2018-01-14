using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void FireDelegate(Bulb sender);
        
    public class Bulb
    {
        // observer

        private List<IBulbObserver> observers = new List<IBulbObserver>();

        // del[]

        private List<FireDelegate> delegates = new List<FireDelegate>();

        // event

        public event FireDelegate OnFire;
        


        public bool Lighting { get; private set; }

        public void Fire()
        {
            this.Lighting = true;

            // observer
            this.RaiseFireEvent();

            // del[]
            this.RaiseFireDelegate();

            // event
            this.OnFire(this);
        }


        // observer

        public void RegisterObserver(IBulbObserver observer)
        {
            this.observers.Add(observer);
        }

        private void RaiseFireEvent()
        {
            foreach (IBulbObserver item in this.observers)
            {
                item.OnFire(this);
            }
        }


        // del[]

        public void RegisterDelegate(FireDelegate del)
        {
            this.delegates.Add(del);
        }
        
        private void RaiseFireDelegate()
        {
            foreach (FireDelegate item in this.delegates)
            {
                item(this);
            }
        }
    }
}
