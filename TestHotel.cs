using System;

public class TestHotel
{
    static Hotel[] hotelArr = new Hotel[5];
    public static void Main(String[] args)
    {
        hotelArr[0].init("Chicago", "Drake", 150, 250.00m);
        hotelArr[1].init("Omaha", "Todd", 155, 250.00m);
        hotelArr[2].init("Boston", "Mariott", 113, 200.00m);
        hotelArr[3].init("Detroit", "Hilton", 127, 150.00m);
        hotelArr[4].init("Portland", "Tree", 90, 170.00m);

        for (int i = 0; i < hotelArr.Length; i++)
            {
            hotelArr[i].Show();
            }

    }
}