﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace WOFClassLib.Tests
{
    public class PhraseTests
    {
        [Fact]
        public void GetPhrase_Tests()
        {
            var sut = new Phrase();

            string phrase = sut.GetPhrase();
            for (int i = 0; i < 50; i++)
            {
                string newPhrase = sut.GetPhrase();
                Assert.NotEqual(newPhrase, phrase);

                phrase = newPhrase;
            }
            
        }
    }
}
