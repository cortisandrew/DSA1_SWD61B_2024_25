// See https://aka.ms/new-console-template for more information
using ADTs_and_DSs.ABV;
using ADTs_and_DSs.Interfaces;

ArrayBasedVector<string> arrayBasedVector = new ArrayBasedVector<string>(new [] {"Mavis", "Francis", "Adam", "Bernice"});

Console.WriteLine(arrayBasedVector);

arrayBasedVector.InsertElementAtRank(0, "Charles");

Console.WriteLine(arrayBasedVector);

