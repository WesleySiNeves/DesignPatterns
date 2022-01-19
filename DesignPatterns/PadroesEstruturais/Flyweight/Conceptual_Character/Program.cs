// Arbitrary extrinsic state
using Conceptual_Character;

int extrinsicstate = 22;
FlyweightFactory factory = new FlyweightFactory();


// Work with different flyweight instances
Flyweight fx = factory.GetFlyweight("X");


fx.Operation(--extrinsicstate);

Flyweight fy = factory.GetFlyweight("Y");

fy.Operation(--extrinsicstate);

Flyweight fz = factory.GetFlyweight("Z");

fz.Operation(--extrinsicstate);



