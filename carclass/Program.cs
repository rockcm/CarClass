Car car1 = new Car('H');

System.Console.WriteLine(car1);

Car car2 = new Car(car1);

System.Console.WriteLine(car1.Equals(car2));




car2.SetType('s');


System.Console.WriteLine(car2.Equals(car1));


car1.SetType("s");


System.Console.WriteLine(car2.Equals(car1));


System.Console.WriteLine(car1);


System.Console.WriteLine(car2);


System.Console.WriteLine(car1.GetType()); 


System.Console.WriteLine(car1.GetTypeAsString());


System.Console.WriteLine(car1.GetTankSize());


System.Console.WriteLine(car1.GetMPG());






