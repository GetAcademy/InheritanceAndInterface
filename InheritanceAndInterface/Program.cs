using System;
using InheritanceAndInterface.Inheritance;

namespace InheritanceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            //var lineStream = new LineStreamC(new DummyStream());
            //var lineStream = new LineStreamI();
            //var line = lineStream.ReadLine();
            //while(line != null)
            //{
            //    Console.WriteLine(line);
            //    line = lineStream.ReadLine();
            //}

            var pointStream = new PointStream();
            var point = pointStream.ReadPoint();
            while (point != null)
            {
                Console.WriteLine(point);
                point = pointStream.ReadPoint();
            }

            //var sum = NumberFileSumCalculator.GetSum();
            //var lineReader = new FileLineReader("Numbers.txt");
            //var lineReader = new KeyboardLineReader();
            //var calculator = new NumberLinesSumCalculator(lineReader);
            //Console.WriteLine(calculator.GetSum());
            /*
               - Interface 
                    - kontrakt - standard
                    - dependency inversion
                    - eks: 
                        - PC-komponenter, WC, strøm, lyspære
                        - bygge en tjeneste uavhengig av konkrete underliggende tjenester 
                          summere tall fra fil - eller tastatur - eller fra nettverk
                            => (videre til arv, lage NumberReader: LineReader )
               - Arv
                    - "is a"
                    - en relasjon fra virkeligheten
                    - mer generelt/abstrakt i toppen av arvehierarkiet
                    - mer konkret i bunnen av arvehierarkiet
                    - eks: 
                        - Menneske : Primat : Pattedyr : Ryggstrengdyr : Dyr : Organisme
                          https://no.wikipedia.org/wiki/Menneske
                        - streams, enten se på innebygde eller lagen egen som leser bytes + arve 
                          for mer spesifikt - feks. PointReader og TextLineReader
                        - brukergrensesnittkomponenter
                        - HvetebolleOppskrift : GjærbakstOppskrift : BakeOppskrift : Oppskrift
                        -   class Part
                            {
                                OEM
                                Manufacturer
                                Number
                                Description
                            }

                            class Tire extends Part
                            {
                               Speed
                               Rating
                            }
                - Composition
                    - "has a"
                    - eks:  class House { 
                                Door[] Doors;    
                            }
             */
        }
    }
}
