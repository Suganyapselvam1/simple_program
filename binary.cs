using System.IO;
using System;

class Program
{
    static void Main()
    {
        binary_num("1000");
    }
    static void binary_num(string m){
        int n=0;
        //Console.WriteLine(m.Length);
        int a=0;
        for(int i=m.Length-1;i>=0;i--){
            int x=(int)Math.Pow(2,a);
            n=n+int.Parse((m[i].ToString()))*x;
            a++;
        }
        Console.WriteLine(n);
    }
    
    static string  binary_num(int n){
        if(n==1){
            return n.ToString();
        }
        string str=" ";
       int m=n%2;
       n=n/2;
       str=str+m.ToString();
       return str+binary_num(n);
    }
    static int Factorial(int n){
        if(n==1){
            return 1;
        }
        return n*Factorial(n-1);
    }
    static void factors(int n){
        string str=" ";
        for(int i=1;i<n;i++){
            if(n%i==0){
                str=str+" "+i.ToString();
            }
        }
         Console.WriteLine(str);
    }
}
