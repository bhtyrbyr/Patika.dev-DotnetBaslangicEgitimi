using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace _7_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> a = new List<int>{ 17,28,30 };
            List<int> b = new List<int>{ 99,16,8 };
            listecevirici(a,b).ForEach(s=> Console.WriteLine(s + " "));*/
            string flPath = @"input.txt";

            FileStream fs = new FileStream(flPath, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            
            string text = sr.ReadLine();

            sr.Close();
            fs.Close();

            List<int> liste = text.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Console.WriteLine(migratoryBirds(liste));
        }
    public static int migratoryBirds(List<int> arr)
    {
        List<int> birdsIds = new List<int>();
        List<int> birdsIdsCount = new List<int>();
        int counter= 0;
        int birdsIdsReadIndex = 0;
        int birdsIdsWriteIndex = 1;
        int birdsIdsCountIndex = 0;
        int minVal;
        int returnVal;
        int tempp = 1;

        arr.Sort();

        for (int i = 0; i < arr.Count-1; i++)
        {
            if(arr[i] != arr[i+1]){
                tempp++;
            }
        }

        for (int i = 0; i < tempp; i++)
        {
            birdsIds.Insert(0, 0);
            birdsIdsCount.Insert(0, 0);
        }

        birdsIds[0] = arr[0];

        do{
            if(birdsIds[birdsIdsReadIndex] != arr[counter]){
                birdsIds[birdsIdsWriteIndex] = arr[counter];
                birdsIdsReadIndex++;
                birdsIdsWriteIndex++;
                birdsIdsCountIndex++;
            }else{
            }
            birdsIdsCount[birdsIdsCountIndex]++;
            counter++;
        }while(counter <= arr.Count - 1);

        minVal = birdsIdsCount[0];
        returnVal = birdsIds[0];
        for(int i = 0; i < birdsIdsCount.Count; i++){
            if(birdsIdsCount[i] > minVal){
                minVal = birdsIdsCount[i];
                returnVal = birdsIds[i];
            }
        }
        
        for(int i = 0; i < birdsIds.Count; i++){
            Console.WriteLine($"BirdsID : {birdsIds[i]} adet : {birdsIdsCount[i]}");
        }

        return minVal;
    }
        static List<int> listecevirici(List<int> a, List<int> b){

            byte aListPoint = 0;
            byte bListPoint = 0;

            for(int i = 0; i < Math.Min(a.Capacity-1, b.Capacity-1); i++){
                if( a[i]> b[i] ) aListPoint++; 
                else if( b[i] > a[i] ) bListPoint++;                 
            }
            return new List<int>{aListPoint, bListPoint};
        }

        static void ders3foreach(int[] list){
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void ders2while(){
            int n = int.Parse(Console.ReadLine());
            int i = -1;
            int tot = 0;
            float ort = 0;
            while(true){
                i++;
                tot += i;
                Console.WriteLine(tot);
                if(i == n)
                    break;
                else{
                }
            }
            ort = (float)tot / i;
            Console.WriteLine("Girilen sayi " + n + "\nToplam " + tot + "\nOrt " + ort);
        }
        static void hackerRank(){
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++){

                for(int j = 0; j < (n - (i + 1)); j++){
                    Console.Write(" ");
                }

                for(int k = 0; k < (i + 1); k++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
