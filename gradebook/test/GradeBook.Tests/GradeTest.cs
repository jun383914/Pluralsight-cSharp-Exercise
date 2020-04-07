using System;
using Xunit;

namespace GradeBook.Tests
{
    public class GradeTests
    {

        [Fact]
        public void Test1()
        {
            InMemoryBook book=new InMemoryBook("");
            book.AddGrade(105);

            Assert.Equal(105,);
        }

        private void SetInt(ref int x)
        {
            x=42;
        }

        private int GetInt()
        {
            return 3;
        }
    }
}
