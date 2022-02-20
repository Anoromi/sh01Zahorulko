using sh01Zahorulko;
using System;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BirthdayDate Check(DateTime d)
            {
                BirthdayChooser.TryValidate(d, out var res);
                return res;
            }
            string? s = BirthdayChooser.TryValidate(new(2003, 12, 12), out var res);

            Assert.Null(s);
            Assert.Equal(ChineseZodiac.Goat, res.ChineseZodiac);
            Assert.Equal(WesternZodiac.Archer, res.WesternZodiac);

            s = BirthdayChooser.TryValidate(new(2003, 1, 20), out res);
            Assert.Equal(WesternZodiac.Water, res.WesternZodiac);

            Assert.Equal(WesternZodiac.Water, Check(new(2003, 2, 18)).WesternZodiac);


            s = BirthdayChooser.TryValidate(new(2004, 1, 3), out res);

            Assert.Null (s);
            Assert.Equal(ChineseZodiac.Monkey, res.ChineseZodiac);
            Assert.Equal(WesternZodiac.Goat, res.WesternZodiac);
        }
    }
}