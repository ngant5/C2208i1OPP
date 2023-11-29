﻿namespace CalsPoly;
public class BasicMath
{
    public int NumberOne { get; set; }
    public int NumberTwo { get; set; }

    //overload
    //public void Sum()
    //{
    //    Console.WriteLine(NumberOne + NumberTwo);
    //}

    //optional parameter
    public void Sum(int numberOne = 0, int numberTwo = 0)
    {
        this.NumberOne = numberOne;
        this.NumberTwo = numberTwo;
        Console.WriteLine(NumberOne + NumberTwo);
    }

    public void Substract(params int[] nums)
    {
        switch (nums.Length)
        {
            case 0:
                NumberOne = 0;
                NumberTwo = 0;
                break;
            case 1:
                NumberOne = nums[0];
                break;
            case 2:
                NumberOne = nums[0];
                NumberTwo = nums[1];
                break;
        }
        Console.WriteLine(NumberOne - NumberTwo);
    }

    public virtual void Divide()
    {
        Console.WriteLine(NumberOne / NumberTwo);
    }
}