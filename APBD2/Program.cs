using APBD2;

Ship ship = new Ship(200, 3, 2);
try
{
    CContainer cContainer = new CContainer(100, 100, 100, 1000, Product.FrozenPizza);

    cContainer.Load(100, -1000);
    cContainer.Load(100, 30);
    cContainer.Load(1001, 30);
    cContainer.EmptyLoading();
    cContainer.Load(1000, 30);
    ship.LoadContainer(cContainer);

} catch(OverfillException e)
{
    Console.WriteLine(e.Message);
}

try
{

    LContainer lContainer = new LContainer(100, 100, 100, 1000, LoadType.Safe);

    lContainer.Load(900);
    lContainer.EmptyLoading();
    lContainer.Load(901);
    ship.LoadContainer(lContainer);
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}

try
{

    LContainer lContainer = new LContainer(100, 100, 100, 1000, LoadType.Hazard);
    lContainer.Load(500);
    lContainer.EmptyLoading();
    lContainer.Load(501);
    Console.WriteLine(ship);
    Ship ship2 = new Ship(100, 5, 5);
    ship.MoveContainerToOtherShip(ship2, lContainer);
    Console.WriteLine(ship2);
    ship.LoadContainer(lContainer);
    Console.WriteLine(lContainer);
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}



try
{
    GContainer gContainer = new GContainer(100, 100, 100, 1000);
    gContainer.Load(999);
    gContainer.EmptyLoading();
    gContainer.Load(995);
    ship.LoadContainer(gContainer);
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}
