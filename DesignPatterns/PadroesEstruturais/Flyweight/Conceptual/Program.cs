using Conceptual;


int Quantidade = 10000;

var factory = new FlyweightFactory
            (
               new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
               new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
               new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
               new Car { Company = "BMW", Model = "M5", Color = "red" },
               new Car { Company = "BMW", Model = "X6", Color = "white" }
           );
factory.listFlyweights();



addCarToPoliceDatabase(factory, new Car
{
    Number = "CL234IR",
    Owner = "James Doe",
    Company = "BMW",
    Model = "M5",
    Color = "red"
});


for (int i = 0; i < Quantidade; i++)
{
    addCarToPoliceDatabase(factory, new Car
    {
        Number = "CL234IR",
        Owner = "James Doe",
        Company = "BMW",
        Model = "X1",
        Color = "red"
    });
}

factory.listFlyweights();






static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
{
    Console.WriteLine("\nClient: Adicionando um carro ao banco de dados.");

    var flyweight = factory.GetFlyweight(new Car
    {
        Color = car.Color,
        Model = car.Model,
        Company = car.Company
    });

    // The client code either stores or calculates extrinsic state and
    // passes it to the flyweight's methods.
    flyweight.Operation(car);
}