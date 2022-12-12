using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppSnake
{
    
    internal class Record
    {
        
        ArrayList records = new ArrayList();
        public Record()
        {

            using (StreamReader sr = new StreamReader("TextFileScore.txt"))
            {
                do
                {
                    records.Add(sr.ReadLine());

                } while (!sr.EndOfStream);
                sr.Close();
            }
        }
        public void getRecord(ArrayList parRecords)
        {
            Console.CursorVisible = false;
            Console.Clear();
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            foreach (String record in parRecords)
            { 
            Console.WriteLine(record);
            }

        }
        public void sortByName()
        {
            ArrayList auxRecords = new ArrayList();
            foreach (String record in records)
            {
                auxRecords.Add(record);
            }
            auxRecords.Sort();
            this.getRecord(auxRecords);
        }
        public void sortByDate()
        {
            this.getRecord(this.records);
        }
        public void sortByScore()
        {
            String[] aux1 = new String[2];
            ArrayList auxRecords = new ArrayList();
            foreach (String record in records)
            {
                auxRecords.Add(record);
            }
            
            ArrayList sortByScore = new ArrayList();
            int aux3 = -1;
            int index = 0;
            int j = 0;
            for (int i = 0; i < 15; i++)
            {
                index = 0;
                aux3 = -1;
                for (j = 0; j < auxRecords.Count; j++)
                {
                    aux1 = ((String)auxRecords[j]).Split(' ');
                    if(aux3 < Convert.ToInt32(aux1[1]))
                    {
                        //Console.WriteLine(Convert.ToInt32(aux1[1]));
                        aux3 = Convert.ToInt32(aux1[1]);
                        index = j;
                    }
                }
                sortByScore.Add(((String)auxRecords[index]));
                auxRecords.RemoveAt(index);
                
            }
            this.getRecord(sortByScore);
        }
    }
    
}
