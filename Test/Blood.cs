using System;

namespace Test 
{
    public enum AB0System
    { A, B, AB, 0 }
    
    public class Blood 
    {
        public AB0System Group { get; private set; }
        
        public Blood(AB0System group)
        {
            Group = group;
        }
    }
}
