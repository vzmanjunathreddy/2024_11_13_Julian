// See https://aka.ms/new-console-template for more information
using Qeustion4;

Console.WriteLine("Hello, World!");

var fetchData = new FetDataAsync();

var data1 = await fetchData.FetchDataFromAPI1();
Console.WriteLine(data1);
var data2 = await fetchData.FetchDataFromAPI2();
Console.WriteLine(data2);

var data3 = fetchData.FetchDataFromAPI1();
var data4 = fetchData.FetchDataFromAPI2();


var resultAll = await Task.WhenAll(data3, data4);
Console.WriteLine(resultAll);

var resultAny = await Task.WhenAny(data3,data4);
Console.WriteLine(resultAny);