using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    class TheCatAteIt
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] elements = line.Split(' ');
                int firstNumber;
                int secondNumber;

                if (elements[2] == "after")
                {
                    firstNumber = int.Parse(elements[3]);
                    secondNumber = int.Parse(elements[0]);
                }
                else
                {
                    firstNumber = int.Parse(elements[0]);
                    secondNumber = int.Parse(elements[3]);
                }
                // first case
                if (!(list.Contains(firstNumber)) && !(list.Contains(secondNumber)))
                {
                    if (list.Count == 0)
                    {
                        list.Add(firstNumber);
                        list.Add(secondNumber);
                    }
                    else
                    {
                        if (secondNumber < list[0])
                        {
                            list.Insert(0, secondNumber);
                            list.Insert(0, firstNumber);
                        }
                        else if (firstNumber > list[list.Count - 1])
                        {
                            list.Add(firstNumber);
                            list.Add(secondNumber);
                        }
                        else
                        {
                            int tempIndex = 0;
                            for (int j = 0; j < list.Count; j++)
                            {
                                if(firstNumber < list[j])
                                {
                                   list.Insert(j, firstNumber);
                                   tempIndex = j;
                                   break;
                                }
                            }
                            for (int j = tempIndex + 1; j < list.Count; j++)
                            {
                                if(secondNumber < list[j])
                                {
                                   list.Insert(j, secondNumber);
                                   break;
                                }
                            }
                        }
                    }

                }
                // 2nd case
                else if (list.Contains(firstNumber) && !(list.Contains(secondNumber)))
                {
                    int indexOfFirst = list.IndexOf(firstNumber);
                    list.Insert(indexOfFirst + 1, secondNumber);
                }
                //3rd case
                else if (list.Contains(secondNumber) && !(list.Contains(firstNumber)))
                {
                    int indexOfSecond = list.IndexOf(secondNumber);
                    list.Insert(indexOfSecond, firstNumber);
                }
                //4th case
                else
                {
                    //do nothing
                }
            }
            foreach (var num in list)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }
    }

