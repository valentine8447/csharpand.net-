﻿using static System.Console;

static double Add (double a, double b)
{
    return a + b; //deliberate bug!
}

double a = 4.5;
double b = 2.5;
//double answer = Add(a, b);
WriteLine ($"{a} + {b} = {a + b}");
WriteLine("Press ENTER to end the app.");
ReadLine ();//wait for user to press the enter