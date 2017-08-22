// Hotel.cs

using System;
public struct Hotel
{
	public void init(string city, string name, int rooms, decimal cost)
	{
		city_ = city;
		name_ = name;
		rooms_ = rooms;
		cost_ = cost;
	}
    public Hotel(Hotel hot)
    {
        city_ = hot.city_;
        name_ = hot.name_;
        rooms_ = hot.rooms_;
        cost_ = hot.cost_;
    }
    public void Show()
	{
		Console.WriteLine("{0} {1} {2} {3:C}",city_, name_, rooms_, cost_);
	}
	private string city_;
	private string name_;
	private int rooms_;
	private decimal cost_;
}
