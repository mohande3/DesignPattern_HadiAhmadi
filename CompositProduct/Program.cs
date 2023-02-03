// See https://aka.ms/new-console-template for more information

using CompositProduct;

ProductItem p1 = new ProductItem(10);
ProductItem p2 = new ProductItem(20);
ProductItem p3 = new ProductItem(30);
ProductItem p4 = new ProductItem(40);

Box b1 = new Box(p1, p2);
Box box2= new Box(p2, p3);
Box root = new Box(b1, box2);

Console.WriteLine($"Price : {root.GetPrice()}");    