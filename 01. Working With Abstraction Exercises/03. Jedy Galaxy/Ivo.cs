
namespace P03_JediGalaxy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Ivo
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public long Score { get; set; }

        public void UpdateCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public void CollectPoints(int points)
        {
            this.Score += points;
        }
    }
}
