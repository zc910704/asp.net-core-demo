using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonScopeTransientDemo
{
    public interface ISingTest
    {
        int Age { get; set; }
        string Name { get; set; }
    }

    public class SingTest : ISingTest
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    //--------------------------

    public interface ISconTest
    {
        int Age { get; set; }
        string Name { get; set; }
    }
    public class SconTest : ISconTest
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    //--------------------------
    public interface ITranTest
    {
        int Age { get; set; }
        string Name { get; set; }
    }
    public class TranTest : ITranTest
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    //-----------------------
    public interface IAService
    {
        void RedisTest();
    }

    public class AService : IAService
    {
        private ISingTest sing; ITranTest tran; ISconTest scon;
        public AService(ISingTest sing, ITranTest tran, ISconTest scon)
        {
            this.sing = sing;
            this.tran = tran;
            this.scon = scon;
        }
        public void RedisTest()
        {

        }
    }
}
