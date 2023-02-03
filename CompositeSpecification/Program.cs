// See https://aka.ms/new-console-template for more information

using CompositeSpecification;
using CompositeSpecification.Composit;
using CompositeSpecification.Leafs;

//var andSpefication = new AndSpecification<long>(
//    new PositiveNumber(),
//    new EvenNumbers());

var ruls = new EvenNumbers().And(new PositiveNumber());

var zero = new ZeroNumber();
var orSpecification = new OrSpecification<long>(ruls, zero);

Console.WriteLine(orSpecification.IsSatisfied(11));





