using Xunit;
using LeetSpeakNS.Objects;

namespace LeetSpeakNS
{
  public class LeetSpeakTest
  {
    // The letter e should be replaced with 3
    [Fact]
    public void Translate_ForLetterE_ReplaceWith3()
    {
      Assert.Equal("3", LeetSpeak.Translate("e"));
    }

    // The letter o should be replaced with 0
    [Fact]
    public void Translate_ForLetterO_ReplaceWith0()
    {
      Assert.Equal("0", LeetSpeak.Translate("o"));
      Assert.Equal("0", LeetSpeak.Translate("O"));
    }

    // The capital letter I should be replaced with 1
    [Fact]
    public void Translate_ForCapitalI_ReplaceWith1()
    {
      Assert.Equal("1", LeetSpeak.Translate("I"));
    }

    // The letter t should be replaced with 7
    [Fact]
    public void Translate_ForLetterT_ReplaceWith7()
    {
      Assert.Equal("7", LeetSpeak.Translate("t"));
      Assert.Equal("7", LeetSpeak.Translate("T"));
    }

    // the letter s should be replaced with z, keeping case, unless at the front of the word
    [Fact]
    public void Translate_ForLetterS_ReplaceWithZKeepCase()
    {
      Assert.Equal("Sz", LeetSpeak.Translate("Ss"));
      Assert.Equal("sZ", LeetSpeak.Translate("sS"));
    }

    // the letter g should be replaced by 9
    [Fact]
    public void Translate_ForLetterG_ReplaceWith9()
    {
      Assert.Equal("9", LeetSpeak.Translate("g"));
      Assert.Equal("9", LeetSpeak.Translate("G"));
    }

    //Lowercase l to 1
    [Fact]
    public void Translate_ForLowerI_ReplaceWith1()
    {
      Assert.Equal("1", LeetSpeak.Translate("l"));
    }

    //Translates 'leet' to '1337'
    [Fact]
    public void Translate_WordLeet_Say1337()
    {
      Assert.Equal("1337", LeetSpeak.Translate("leet"));
    }

    //Translate 'this is leet speak' to '7hiz iz 1337 sp3ak'
    [Fact]
    public void Translate_Phrase_ToLeet()
    {
      Assert.Equal("7hiz iz 1337 zp3ak", LeetSpeak.Translate("this is leet speak"));
    }

    // words in quotes should be ignored
    [Fact]
    public void Translate_Phrase_ToLeetIgnoreQuotes()
    {
      Assert.Equal("7hiz iz 'leet' zp3ak", LeetSpeak.Translate("this is 'leet' speak"));
    }
  }
}
