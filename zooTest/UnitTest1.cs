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


    }
}
