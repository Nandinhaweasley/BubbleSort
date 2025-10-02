// See https://aka.ms/new-console-template for more information
using BubbleSort;
string[] arrNumbers = new string[] {
    "Nanda", "Erick", "Tcholinha", "Amor"
};

foreach (var number in arrNumbers)
    Console.Write($"[{number}]");
    
var arrOrdered = BubbleSortOrder.Sort<string>(arrNumbers);
Console.WriteLine("");
Console.WriteLine("vetor Ordenado Decrescente:");
foreach (var number in arrOrdered)
    Console.Write($"[{number}]"); 