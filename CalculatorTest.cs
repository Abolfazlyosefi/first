﻿using Xunit;

public class CalculatorTest
{
    [Fact]
    public void TestAdd()
    {
        //Given
        Calculator calc = new();
        int a = 5;
        int b = 2;
        int expectedResult = 7;

        //When
        int result = calc.Add(a, b);

        //Then
        Assert.Equal(expectedResult, result);

    }

}