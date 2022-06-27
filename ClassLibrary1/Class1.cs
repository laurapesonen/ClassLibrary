using System;

namespace ClassLibrary1
{

    
    public class Class1
    {
        public bool timeCheck(DateTime d1)
        {

            DateTime d2 = DateTime.Now;

            int result = DateTime.Compare(d1, d2);


            bool resultb = false;

            if (result < 0)
            {
                resultb = true;

            }
            return resultb;
        }
    }

                
      

    
}


//Metodi, joka tarkistaa onko annettu päivämäärä tulevaisuudessa ja palauttaa true mikäli päivämäärä on tulevaisuudessa ja false mikäli päivämäärä on menneisyydessä
//Metodi, joka kertoo opiskelun aloitusajan ja arvioidun opiskeluajan perusteella onko opiskelu myöhässä vai ei. 