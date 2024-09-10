﻿using System;
using System.Linq;
using System.Text;

namespace Fizzbuzz
{
    public class CalculationRespository : ICalculation
    {
        public string GetCalculationResults(object[] values)
        {
            StringBuilder str = new StringBuilder();
            if (values!=null)
            {
                foreach (var item in values)
                {
                    if (!string.IsNullOrEmpty(Convert.ToString(item)))
                    {
                        bool charactercheck = item.ToString().All(char.IsDigit);
                        if (charactercheck)
                        {
                            int intValue = Convert.ToInt32(item.ToString());

                            if (intValue > 0)
                            {
                                if (intValue % 3 == 0 && intValue % 5 == 0)
                                {
                                    str.Append(GetFizzBuzz(intValue));
                                }
                                else if (intValue % 5 == 0)
                                {
                                    str.Append(GetBuzz(intValue));
                                }
                                else if (intValue % 3 == 0)
                                {
                                    str.Append(GetFizz(intValue));
                                }
                                else
                                {
                                    str.Append(GetDefault(intValue));
                                }
                            }
                            else
                            {
                                str.Append(GetZero(intValue));
                            }
                        }
                        else
                        {
                            str.Append("Invalid term==>" + item + "\n");
                        }
                    }
                    else
                    {
                        str.Append("Invalid term==>" + item + "\n");
                    }
                }
            }
            else
            {
                return "Invalid term";
            }

            return str.ToString();
        }

        public string GetDefault(int value)
        {
            return "Divided " + value + " by 3\n " + "Divided " + value + " by 5 \n";
        }

        public string GetZero(int value)
        {

            return "Divided " + value + " by 0 ==>0 \n ";
        }

        public string GetFizzBuzz(int value)
        {
            return value + "==>FizzBuzz \n";
        }

        public string GetBuzz(int value)
        {
            return value + "==>Buzz \n";
        }

        public string GetFizz(int value)
        {
            return value + "==>Fizz \n";
        }
    }
}
