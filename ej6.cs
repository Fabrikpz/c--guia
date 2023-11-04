using System;
using System.Collections;

class Program6
{
    static bool BinarySearch(ArrayList list, int num, int posMedia)
    {
        posMedia = list.Count / 2;

        if ((int)list[posMedia] == num) {
            return true;
        }

        if (list.Count == 1) {
            return false;
        }

        if (num < (int)list[posMedia]) {
            ArrayList auxList = new ArrayList(list.GetRange(0, posMedia));
            posMedia -= posMedia / 2;
            return BinarySearch(auxList, num, posMedia);
        }

        if (num > (int)list[posMedia]) {
            ArrayList auxList = new ArrayList(list.GetRange(posMedia + 1, list.Count - posMedia - 1));
            posMedia += posMedia / 2;
            return BinarySearch(auxList, num, posMedia);
        }

        return false;
    }

    static void Main(string[] args)
    {
        ArrayList list = new ArrayList() { 2, 10, 15, 33, 49, 51, 65 };
        int target = 65;

        bool found = BinarySearch(list, target, 0);

        if (found) {
            Console.WriteLine("El número " + target + " se encontró en la lista.");
        } else {
            Console.WriteLine("El número " + target + " no se encontró en la lista.");
        }
    }
}
