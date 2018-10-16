using System;
using Xunit;
using lab05_zoo.classes;

namespace zooTest
{
    public class UnitTest1
    {
        [Fact]
        public void VampireSpeaksMotto()
        {
            Vampire vamp1 = new Vampire();
            
            Assert.Equal("I live to drink the sweetest blood.", vamp1.MyMotto());
        }

        [Fact]
        public void VampireSpeaksGoal()
        {
            Vampire vamp1 = new Vampire();

            Assert.Equal("I must ensure my survival.", vamp1.GoalInLife());
        }

        [Fact]
        public void MermaidIsUnique()
        {
            Mermaid merm = new Mermaid();

            Assert.Equal("I can swim.I have arms.", merm.MyUniqueness());
        }

        [Fact]
        public void MermaidHasChildren()
        {
            Mermaid merm = new Mermaid();

            Assert.Equal("Hundreds!", merm.WhatAboutChildren());
        }

        [Fact]
        public void UnicornMagicalPowers()
        {
            Unicorn uni = new Unicorn();

            Assert.Equal("Everything my horn touches turns to gold.", uni.MagicalPower());
        }
        
        [Fact]
        public void UnicornSpouses()
        {
            Unicorn uni = new Unicorn();

            Assert.Equal(2, uni.HowManySpouses());
        }

        [Fact]
        public void CentaurMagicalPowers()
        {
            Centaur cent = new Centaur();

            Assert.Equal("I have superior strength and speed.", cent.MagicalPower());
        }

        [Fact]
        public void CentaurSpouses()
        {
            Centaur cent = new Centaur();

            Assert.Equal(2, cent.HowManySpouses());
        }

        [Fact]
        public void PegasusMagicalPowers()
        {
            Pegasus peggie = new Pegasus();

            Assert.Equal("I can fly at incredible speeds.", peggie.MagicalPower());
        }

        [Fact]
        public void PegasusSpouses()
        {
            Pegasus peggie = new Pegasus();

            Assert.Equal(2, peggie.HowManySpouses());
        }
    }
}
