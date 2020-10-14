using OrhestraSystem.Interfaces;
using System;
using System.Collections.Generic;

namespace OrhestraSystem.Classes
{
    class WoodwindInstrumentMusicians : IPlayable
    {
        private List<Piece> pieces;


        public WoodwindInstrumentMusicians(List<Piece> pieces)
        {
            this.pieces = pieces;

        }
        public WoodwindInstrumentMusicians() { }
        public void Play()
        {
            throw new NotImplementedException();
        }
        public void PlayFlute(int y, int z)
        {
            if (pieces[y].ListOfParts[z].IsChoros == true)
            {
                Console.WriteLine("Flute is played:");
                Console.Write("Part" + (z + 1) + ": ");
                for (int j = 0; j < pieces[y].ListOfParts[z].Notes.Count; j++)
                {
                    Console.Write(pieces[y].ListOfParts[z].Notes[j].Symbol + " ");
                }
                Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                Console.WriteLine();
            }

        }

    }
}


