//using System.Collections.Generic;

//using System;
//using System.Linq;


//class Random : MonoBehaviour
//{
//    static void Main(string[] args)
//    {

//        Random rand = new Random(Guid.NewGuid().GetHashCode());

//        List<int> listLinq = new List<int>(Enumerable.Range(1, 100));
//        listLinq = listLinq.OrderBy(num => rand.Next()).ToList<int>();

//        for (int i = 0; i < 100; i++)
//        {
//            Console.WriteLine(listLinq[i].ToString());
//        }

//    }
//}

