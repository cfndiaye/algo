// See https://aka.ms/new-console-template for more information
var n = 170;
var p = 2;
var factN = Factoriel.FactorielDe(n);
var factDeN_P = Factoriel.FactorielDe(n - p);

//Nommbre de combinaison possible cnp =n!/(n−p)!

var nc = factN/factDeN_P;

Console.WriteLine($"{nc.ToString()} combinaisons possibles.");


