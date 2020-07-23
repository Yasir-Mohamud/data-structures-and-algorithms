using System;
using Xunit;
using static MultiBracketValidation.Program;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnsFalseForEdgeCases()
        {

            // Arrange/Act/Assert
            Assert.False(MultiBracketValidationMethod(""));
            Assert.False(MultiBracketValidationMethod("}"));
            Assert.False(MultiBracketValidationMethod(")))"));
            Assert.False(MultiBracketValidationMethod("[[["));
            Assert.False(MultiBracketValidationMethod("CODEFELLOWS"));

        }

        [Fact]
        public void CanValidateAsTrue()
        {

            // Arrange/Act/Assert
            Assert.True(MultiBracketValidationMethod("{}"));
            Assert.True(MultiBracketValidationMethod("{}(){}"));
            Assert.True(MultiBracketValidationMethod("()[[Extra Characters]]"));
            Assert.True(MultiBracketValidationMethod("(){}[[]]"));
            Assert.True(MultiBracketValidationMethod("{}{Code}[Fellows](())"));
            Assert.True(MultiBracketValidationMethod("()"));

        }

        [Fact]
        public void CanValidateAsFalse()
        {

            // Arrange/Act/Assert
            Assert.False(MultiBracketValidationMethod("[({}]"));
            Assert.False(MultiBracketValidationMethod("(]("));
            Assert.False(MultiBracketValidationMethod("{(})"));

        }
    }
}
