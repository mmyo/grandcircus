using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3b
{
    public class BuildingProgram
    {
        public static Pyramid BuildGreatPyramid()
        {
            Pyramid pyramid = new Pyramid();
            pyramid.Length = 756;
            pyramid.Width = 481;
            pyramid.Height = 756;

            return pyramid;
        }

        public static string DescribeBuilding(Building building)
        {
            return $"Volume: {building.GetVolume()}, First Floor Area: {building.GetFirstFloorArea()}";
        }
    }
}
