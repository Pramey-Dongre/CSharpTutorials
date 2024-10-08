﻿using _2_NamesBeforeRefactorToSRP.DataAccess;
var names = new Names();
var stopWatch = Stopwatch.StartNew();
//for(int i= 0;i<1000;i++)
//{
//    Console.WriteLine($"Loop {i}");
//}
//stopWatch.Stop();
//Console.WriteLine("Time in ms: "+ stopWatch.ElapsedMilliseconds);
//var path = names.BuildFilePath();
var path = NamesFilePathBuilder.BuildFilePath();
var stringsTextualRepository = new StringsTextualRepository();
if (File.Exists(path))
{
Console.WriteLine("Names file already exists. Loading names.");
var stringsFromFile = stringsTextualRepository.Read(path);
names.AddNames(stringsFromFile);
}
else
{
Console.WriteLine("Names file does not yet exist.");

//let's imagine they are given by the user
names.AddName("John");
names.AddName("not a valid name");
names.AddName("Claire");
names.AddName("Sdbsb");
names.AddName("Hearnan");
names.AddName("65uhbtr");
names.AddName("123 definitely not a valid name");

Console.WriteLine("Saving names to the file.");
stringsTextualRepository.Write(path, names.All);
}
Console.WriteLine(names.Format());

Console.ReadLine();
