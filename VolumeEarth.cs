using System;

class VolumeEarth
{
    static void Main()
    {
        // radius of the Earth in kilometers
        double radiusKm = 6378;

        // volume in cubic kilometers
        double volumeKm3 = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);

        // convert volume to cubic miles
        double volumeMiles3 = volumeKm3 * 0.239913;

        // display
        Console.WriteLine(string.Format("The volume of Earth in cubic kilometers is {0} and cubic miles is {1}",volumeKm3,volumeMiles3));
    }
}