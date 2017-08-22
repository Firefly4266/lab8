using System;

public class TestHotel
{
    public static void Main(string[] args)
    {
        Hotel[] hotelArr = new Hotel[5];
        hotelArr[0].init("Chicago", "Drake", 150, 250.00m);
        hotelArr[1].init("Omaha", "Todd", 155, 250.00m);
        hotelArr[2].init("Boston", "Mariott", 113, 200.00m);
        hotelArr[3].init("Detroit", "Hilton", 127, 150.00m);
        hotelArr[4].init("Portland", "Tree", 90, 170.00m);
        foreach (Hotel hot in hotelArr)
            {
            hot.Show();
            }
        Hotel[] hotCopy = new Hotel[5];
        for (int i = 0; i < 5; i++)
        {
            hotCopy[i] = new Hotel (hotelArr[i]);
            hotelArr[i].init("", "", 0, 0);
        }
        foreach (Hotel hot in hotelArr)
        {
            hot.Show();
        }
        foreach (Hotel hot in hotCopy)
        {
            hot.Show();
        }
    }
}