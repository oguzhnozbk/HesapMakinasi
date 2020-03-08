using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinasi
{
    interface IFileOperations
    {
        void AddToHistoryFile(string value);
        string ReadHistoryFile();
        void DeleteHistory();
    }

    class FileOperations : IFileOperations
    {
        string _path;
        public FileOperations(string path)
        {
            _path = path;
        }
        public void AddToHistoryFile(string value)
        {
            if (!File.Exists(_path))
                File.Create(_path).Close();
            string history = File.ReadAllText(_path);
            history = value + "\n" + history;
            File.WriteAllText(_path, history);
        }

        public void DeleteHistory()
        {
            File.WriteAllText(_path,"");
        }

        public string ReadHistoryFile()
        {
            return File.ReadAllText(_path);
        }
    }
    
    class Operations
    {
        public double Addition(double number1,double number2)
        {
            return number1 + number2;
        }
        public double Subtraction(double number1,double number2)
        {
            return number1 - number2;
        }
        public double Multiplication(double n1,double n2)
        {
            return n1 * n2;
        }
        public double Division(double n1,double n2)
        {
            if (n2 == 0)
                return double.NaN;
            else
                return n1 / n2;
        }
        public double Factorial(double n)
        {
            if (n < 0) return double.NaN;
            else if (n == 0) return 1;
            else if (n == 1) return 1;
            else return n * (Factorial(n - 1));
        }
        public double Absolute(double n)
        {
            return Math.Abs(n);
        }
        public double OneDivided(double n)
        {
            if (n == 0) return double.NaN;
            else return 1 / n;
        }
        public double Mod(double n1,double n2)
        {
            return n1 % n2;
        }
        public double Enumber()
        {
            return Math.E;
        }
        public double PI()
        {
            return Math.PI;
        }
        public double X2(double n)
        {
            return n * n;
        }
        public double X3(double n)
        {
            return n * n * n;
        }
        public double XusY(double x, int y)
        {
            double value = 1;
            if (y < 0)
            {
                int a = -1 * y;
                for (int i = 1; i <= a; i++)
                {
                    value *= x;
                }
                return 1 / value;
            }
            else if (y == 0) return value;
            else
            {
                for (int i = 1; i <= y; i++)
                {
                    value *= x;
                }
                return value;
            }
            
        }
        public double OnUsX(int n)
        {
            double value = 1;
            if (n < 0)
            {
                int a = -1 * n;
                for (int i = 1; i <= a; i++)
                {
                    value *= 10;
                }
                return 1 / value;
            }
            else if (n == 0) return value;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    value *= 10;
                }
                return value;
            }
        }
        public double Log(double n)
        {
            return Math.Log10(n);
        }
        public double Ln(double n)
        {
            return Math.Log(n);
        }
        public double SquareRoot(double n)
        {
            return Math.Sqrt(n);
        }
        public double CubeRoot(double n)
        {
            return Math.Pow(n, OneDivided(3));
            
        }
        public double YRoot(double x,double y)
        {
            return Math.Pow(x, OneDivided(y));
        }
        public double IkiUsX(int n)
        {
            double value = 1;
            if (n < 0)
            {
                int a = -1 * n;
                for (int i = 1; i <= a; i++)
                {
                    value *= 10;
                }
                return 1 / value;
            }
            else if (n == 0) return value;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    value *= 10;
                }
                return value;
            }
        }
        public double EusX(int n)
        {
            double value = 1;
            double e = Math.E;
            if (n < 0)
            {
                int a = -1 * n;
                for (int i = 1; i <= a; i++)
                {
                    value *= e;
                }
                return 1 / value;
            }
            else if (n == 0) return value;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    value *= e;
                }
                return value;
            }
        }
        public double Yuzde(double x,double y)
        {
            return x * y / 100;
        }
    }
}
