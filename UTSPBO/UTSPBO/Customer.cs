using System;

public class CustomerOrder
{
    private static int StartingId = 1;
    public int Id { get; private set; }
    public string Name { get; set; }
    public int TotalCups { get; set; }

    public CustomerOrder()
    {
        this.Id = GetId();
    }

    private static int GetId()
    {
        return StartingId++;
    }
}