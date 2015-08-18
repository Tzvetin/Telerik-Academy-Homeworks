using System;
using System.Text;
using System.Collections.Generic;

    class PHPVariables
    {
        public static string ReadInput()
        {
            string currentLine = Console.ReadLine().Trim();

            StringBuilder phpCode = new StringBuilder();

            while (currentLine != "?>")
            {
                phpCode.AppendLine(currentLine);
                currentLine = Console.ReadLine().Trim();
            }

            return phpCode.ToString();
        }

        public static bool IsValidVariableSymbol(char symbol)
        {
            if (char.IsLetterOrDigit(symbol) || symbol == '_')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static HashSet<string> ExtractWords(string input)
        {
            bool inOneLineComment = false;
            bool inMultiLineComment = false;
            bool inSingleQuotedString = false;
            bool inDoubleQuotedString = false; 
            bool inVariable = false;
           
            HashSet<string> variables = new HashSet<string>();

            StringBuilder currentVariable = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (inOneLineComment)
                {
                    if (currentSymbol == '\n') inOneLineComment = false;
                    continue;
                }

                if (inMultiLineComment)
                {
                    if (currentSymbol == '*' && i + 1 < input.Length && input[i + 1] == '/') inMultiLineComment = false;
                    continue;
                }

                if (inSingleQuotedString)
                {
                    if (currentSymbol == '\'')
                    {
                        inSingleQuotedString = false;
                        continue;
                    }
                }

                if (inDoubleQuotedString)
                {
                    if (currentSymbol == '"')
                    {
                        inDoubleQuotedString = false;
                        continue;
                    }
                }

                if (inVariable)
                {
                    if (char.IsLetterOrDigit(currentSymbol) || currentSymbol == '_')
                    {
                        currentVariable.Append(currentSymbol);
                        continue;
                    }
                    else
                    {
                        if (currentVariable.Length > 0) variables.Add(currentVariable.ToString());
                        currentVariable.Clear();
                        inVariable = false;
                    }
                }

                if (!inSingleQuotedString && !inDoubleQuotedString)
                {
                    if (currentSymbol == '#' || (currentSymbol == '/' && i + 1 < input.Length && input[i + 1] == '/'))
                    {
                        inOneLineComment = true;
                        i++;
                        continue;
                    }

                    if (currentSymbol == '/' && i + 1 < input.Length && input[i + 1] == '*')
                    {
                        inMultiLineComment = true;
                        i++;
                        continue;
                    }
                }
                else if (inSingleQuotedString || inDoubleQuotedString)
                {
                    if (currentSymbol == '\\')
                    {
                        i++;
                        continue;
                    }
                }

                if (currentSymbol == '\'') inSingleQuotedString = true;
                else if (currentSymbol == '"') inDoubleQuotedString = true;
                else if (currentSymbol == '$') inVariable = true;

                
            }
            return variables;
        }

        public static void PrintResult(HashSet<string> result)
        {
            Console.WriteLine(result.Count);

            foreach (var variable in result)
            {
                Console.WriteLine(variable);
            }
        }

        static void Main()
        {
            string inputCode = ReadInput();
            var result = ExtractWords(inputCode);
            PrintResult(result);

        }

        
    }

