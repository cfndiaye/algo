// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using CloseToZero;

Console.WriteLine("Close to zero");
var list = new List<int>(){11,2,2,3,4,5,6,7,8,9,-1,-2};
var closer = new CloserToZero(list);
Console.WriteLine($"{closer.TheMostCloserToZero()} is most closer to zero.");