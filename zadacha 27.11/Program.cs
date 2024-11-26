namespace zadacha_27._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(/*Console.ReadLine().Split().Select(int.Parse)*/);
            LinkedList<int> even = new LinkedList<int>();
            LinkedList<int> odd = new LinkedList<int>();
            Input(list);
            ListSorting(list, even, odd);
            Print(list, even, odd);
        }

        /*Malko bezmislen method koito vuvejda elementite kato moje da se vuvedat
         direktno ot ctor, no ste napisali che jelaete 3 methoda.*/
        static void Input(LinkedList<int> list)
        {    
            // Pulnene na linkedlist s elementi
            Console.Write("How many numbers do you want: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                list.AddLast(number);
                number = 0;
            }
        }
        static void ListSorting(LinkedList<int> list, LinkedList<int> even, LinkedList<int> odd)
        {
            //Tuk sortiram elementite ot glavniq list
            foreach (var VARIABLE in list)
            {
                if (VARIABLE % 2 == 0)
                {
                    even.AddFirst(VARIABLE);
                }

                else
                {
                    odd.AddFirst(VARIABLE);
                }
            }
        }
        
        static void Print(LinkedList<int> list, LinkedList<int> even, LinkedList<int> odd)
        {
            // tuk printiram elementite ot glavniq list, lista s chetnite i list s nechetnite chisla.
            Console.WriteLine("All numbers: " + string.Join(", ", list));
            Console.WriteLine("Even numbers: " + string.Join(", ", even));
            Console.WriteLine("Odd numbers: " + string.Join(", ", odd));
        }
    }
}

// izpolzvam static samo pri methodite koeto e pozvoleno
// kakto pojelahte ima 3 methoda
