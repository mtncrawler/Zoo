using System;
using Xunit;
using lab05_zoo.Program;
using lab05_zoo.classes;

namespace zooTest
{
    public class UnitTest1
    {
        [Fact]
        public void VampireSpeaksMotto()
        {
            Vampire vamp1 = new Vampire();

            Console.WriteLine(vamp1.MyMotto());
        }
    }
}
