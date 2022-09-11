using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Counter
    {
        private static readonly Counter instance = new Counter();
        
        public static Counter Instance
        {
            get
            {
                return instance;
            }
        }

        public int count;

        public  void Increament() 
        {
            this.count++;
        }

        public void Decreament()
        {
            this.count--;
        }

    }
}
