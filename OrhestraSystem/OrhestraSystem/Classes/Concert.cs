using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrhestraSystem.Classes
{
    public class Concert
    {

        private List<Piece> pieces;

        private Maestro maestro;
        StringInstrumentMusicians sim = new StringInstrumentMusicians();
        WoodwindInstrumentMusicians wwim = new WoodwindInstrumentMusicians();
        PercussionInstrumentMusicians pim = new PercussionInstrumentMusicians();
        public Concert(List<Piece> pieces)
        {
            this.pieces = pieces;
            setChoros();
            maestro = new Maestro(pieces);
            sim = new StringInstrumentMusicians(pieces);
            wwim = new WoodwindInstrumentMusicians(pieces);
            pim = new PercussionInstrumentMusicians(pieces);

        }

        public void setChoros()
        {
            for (int i = 0; i < this.pieces.Count; i++)
            {
                this.pieces[i].SetChorosOfPieces();
            }
        }

        public void CreateMusicians()
        {
            for (int i = 0; i < pieces.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Piece " + (i + 1) + " is played " + pieces[i].TempoOfPiece);

                for (int j = 0; j < pieces[i].ListOfParts.Count; j++)
                {
                    sim.PlayViolin(i, j);
                    sim.PlayCello(i, j);
                    wwim.PlayFlute(i, j);
                    if (pieces[i].ListOfParts.Count - j < 3)
                    {
                        pim.drum(i, j);
                        pim.bell(i, j);
                    }
                }
                Console.WriteLine();
            }
        }
        public void Start()
        {
            CreateMusicians();
        }
    }
}
