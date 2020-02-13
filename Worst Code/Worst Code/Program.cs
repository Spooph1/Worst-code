using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worst_Code
{
    class Program
    {
        static int varibIeoftypeInt;static int varibleoftypeInt;
        public void Enteryourintegersorsomething(){Console.Write("\nEnter Int #1:\t");varibIeoftypeInt=Convert.ToInt32(Console.ReadLine());Console.Write("\nEnter Int #2:\t");varibleoftypeInt=Convert.ToInt32(Console.ReadLine());}
        public int Bigmathofsomesortwhichismadetobeasincomprehensibleaspossible(int varibleoftypelnt,int variableoftypeInt){int variableOftypeInt;if(varibleoftypelnt==variableoftypeInt){variableOftypeInt=(varibleoftypelnt+variableoftypeInt)*3;return variableOftypeInt;}else{variableOftypeInt=varibleoftypelnt+variableoftypeInt;return variableOftypeInt;}}
        static void Main(string[] args){Program p=new Program();p.Enteryourintegersorsomething();Console.Write(p.Bigmathofsomesortwhichismadetobeasincomprehensibleaspossible(varibIeoftypeInt,varibleoftypeInt));Console.ReadLine();}
    }
}
