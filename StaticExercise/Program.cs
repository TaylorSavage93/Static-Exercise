using System;
using StaticExercise;

var celcius = TempConverter.FarenheitToCelcius(68);
var farenheit = TempConverter.CelciusToFarenheit(10);

Console.WriteLine($"68 degrees farenheit is the same as {celcius} degrees celcius");
Console.WriteLine($"10 degrees  celcius is the same as {farenheit} degrees farenheit");


