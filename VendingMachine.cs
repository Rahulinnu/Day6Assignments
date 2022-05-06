using System;
namespace Day6Assignment
{
    public class VendingMachine
    {
        public void ChangeMoney()
        {
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 }; 
            Console.WriteLine("Enter amount in Rupees you want change for this : ");
            int rupee = Convert.ToInt32(Console.ReadLine()); 
            int j = 0;
            int rs = rupee;
            int[] notesFrequency = { 0, 0, 0, 0, 0, 0, 0, 0 };
            bool is_start = true;
            while (true)
            {
                for (int i = 0; i < notes.Length; i++) 
                {
                    if (rs > notes[i] || (rs == notes[i] && !is_start))  
                    {
                        j = i;
                        break;
                    }
                }
                rs = rs - notes[j];
                notesFrequency[j] += 1; 
                if (rs == 0) 
                {
                    break;
                }
                is_start = false;
            }
            for (int i = 0; i < notesFrequency.Length; i++)
            {
                Console.WriteLine($"Frequency of {notes[i]} rupees note : {notesFrequency[i]}");
            }
        }
    }
}
