﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes
{
    public class StringInstrumentMusicians
    {
        private List<Piece> pieces;

        public StringInstrumentMusicians(List<Piece> pieces)
        {
            this.pieces = pieces;
        }

        public StringInstrumentMusicians() {
        }

        public void PlayViolin(int y, int z)
        {
            if (pieces[y].ListOfParts[z].TempoOfPart != "PRETISSIMO")
            {
                Console.WriteLine("Violin is played:");
                Console.Write("Part" + (z + 1) + ": ");
                for (int i = 0; i < pieces[y].ListOfParts[z].Notes.Count; i++)
                {
                    Console.Write(pieces[y].ListOfParts[z].Notes[i].Symbol + " ");
                }
                Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                Console.WriteLine();
            }
        }
        public void PlayCello(int y,int z)
        {
            if (pieces[y].TempoOfPiece!= "RITENUTO")
            {
                Console.WriteLine("Cello is played:");
                Console.Write("Part" + (z + 1) + ": ");
                for (int i = 0; i < pieces[y].ListOfParts[z].Notes.Count; i++)
                {
                    Console.Write(pieces[y].ListOfParts[z].Notes[i].Symbol + " ");
                }
                Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                Console.WriteLine();
            }
            else
            {
                if (z<2)
                {
                    Console.WriteLine("Cello is played:");
                    Console.Write("Part" + (z + 1) + ": ");
                    for (int i = 0; i < pieces[y].ListOfParts[z].Notes.Count; i++)
                    {
                        Console.Write(pieces[y].ListOfParts[z].Notes[i].Symbol + " ");
                    }
                    Console.Write(pieces[y].ListOfParts[z].TempoOfPart);
                    Console.WriteLine();
                }
                
            }
            
        }

        public virtual void Play()
        {
            Console.WriteLine("Telli çalgı çalar.");
        }
    }
}
