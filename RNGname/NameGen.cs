using System;
using System.Collections.Generic;
using System.Text;

namespace RNGname
{
    class NameGen
    {
        string rname;
        string ac;

        public string cName(int x)
        {
            Random rng = new Random();
            string[] ll = {"a","b","c","d","e","f","g",
                "h","i","j","k","l","m","n","o","p","q",
                "r","s","t","u","v","w","x","y","z"};
            string[] lu = {"A","B","C","D","E","F","G",
                "H","I","J","K","L","M","N","O","P","Q",
                "R","S","T","U","V","W","X","Y","Z"};
            string[] nn = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string[] oc = { "!", "@", "#", "$", "%" };

            for (int i = 0; i < x; i++)
            {
                int n = rng.Next(1, 8);
                int m;
                

                switch (n)
                {
                    case 1:
                        {
                            m = rng.Next(0, 26);
                            ac = ll[m];
                            break;
                        }

                    case 2:
                        {
                            m = rng.Next(0, 26);
                            ac = lu[m];
                            break;
                        }

                    case 3:
                        {
                            m = rng.Next(0, 10);
                            ac = nn[m];
                            break;
                        }

                    case 4:
                        {
                            m = rng.Next(0, 5);
                            ac = oc[m];
                            break;
                        }

                    case 5:
                        {
                            m = rng.Next(0, 26);
                            ac = ll[m];
                            break;
                        }

                    case 6:
                        {
                            m = rng.Next(0, 26);
                            ac = lu[m];
                            break;
                        }

                    case 7:
                        {
                            m = rng.Next(0, 10);
                            ac = nn[m];
                            break;
                        }



                    default:
                        break;
                }

                rname = rname + ac;
            }

            return rname;
        }
    }
}
