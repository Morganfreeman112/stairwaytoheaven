using System;
using System.IO;

namespace bobs_boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("input.txt");
            StreamWriter writer = new StreamWriter("output.txt");
            double price = Convert.ToDouble(reader.ReadLine());
            double ordertotal = 0;
            writer.WriteLine("");
            while (reader.Peek() != -1)
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(',');
                    string colour = (parts[0]);
                    double innerLength = Convert.ToDouble(parts[1]);
                    double innerWidth = Convert.ToDouble(parts[2]);
                    double innerHeight = Convert.ToDouble(parts[3]);
                    double thickness = Convert.ToDouble(parts[4]) / 10;
                    double offBoxes = Convert.ToDouble(parts[5]);
                    double innerVolume = innerLength * innerWidth * innerHeight;
                    double outerLength = (innerLength + thickness * 2);
                    double outerHeight = (innerHeight + thickness * 2);
                    double outerWidth = (innerWidth + thickness * 2);
                    double outerVolume = outerLength * outerWidth * outerHeight;
                    double plasticPerBox = (outerVolume - innerVolume);
                    double perbox = plasticPerBox * price;
                    double perOrder = offBoxes * perbox;
                    writer.WriteLine("Box Colour: {0}", colour);
                    writer.WriteLine("---------------------------------------------");
                    writer.WriteLine("Cost per box {0}", perbox.ToString("C"));
                    writer.WriteLine("Cost for {0} boxes {1}", offBoxes, perOrder.ToString("C"));
                    writer.WriteLine("---------------------------------------------");
                    double totalcost = perbox * plasticPerBox;
                    ordertotal += perOrder;
                }

            writer.WriteLine("Total Cost: {0}", ordertotal.ToString("C"));
            writer.Close();
            reader.Close();
        }
    }
}