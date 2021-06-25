using System;

namespace InheritanceAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamDemo.Run();
            /*
               - Interface 
                    - kontrakt
                    - dependency inversion
                    - eks: 
                        - PC-komponenter, WC, strøm, lyspære
                        - bygge en tjeneste uavhengig av konkrete underliggende tjenester 
                          summere tall fra fil - eller tastatur - eller fra nettverk
               - Arv
                    - "is a"
                    - en relasjon fra virkeligheten
                    - mer generelt/abstrakt i toppen av arvehierarkiet
                    - mer konkret i bunnen av arvehierarkiet
                    - eks: 
                        - menneske : Primat : Pattedyr : Ryggstrengdyr : Dyr : Organisme
                          https://no.wikipedia.org/wiki/Menneske
                        - streams, enten se på innebygde eller lagen egen som leser bytes + arve 
                          for mer spesifikt - feks. PointReader og TextLineReader
                        - brukergrensesnittkomponenter
                        - HvetebolleOppskrift : GjærbakstOppskrift : BakeOppskrift : Oppskrift
                - Composition
                    - "has a"
                    - eks:  class House { 
                                Door[] Doors;    
                            }
             */
        }
    }
}
