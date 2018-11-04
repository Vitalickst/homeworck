using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_map
{
    class Program
    {
        static void Main(string[] args)
        {
           TerrainEnum[,] map =
           {
                { TerrainEnum.SAND, TerrainEnum.SAND, TerrainEnum.SAND,
                  TerrainEnum.SAND, TerrainEnum.GRASS, TerrainEnum.GRASS,
                  TerrainEnum.GRASS, TerrainEnum.GRASS, TerrainEnum.GRASS,
                  TerrainEnum.GRASS }, 
                { TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
                  TerrainEnum.WATER, TerrainEnum.WATER, TerrainEnum.WATER,
                  TerrainEnum.WATER, TerrainEnum.WALL, TerrainEnum.WALL,
                  TerrainEnum.WALL}
           };
           Console.OutputEncoding = UTF8Encoding.UTF8;
           for (int row = 0; row < map.GetLength(0); row++)
           {
               for (int column = 0; column < map.GetLength(1); column++)
               {
                   Console.ForegroundColor = map[row, column].GetColor();
                   Console.Write(map[row, column].GetChar() + " ");
               }
               Console.WriteLine();
           }
           Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
