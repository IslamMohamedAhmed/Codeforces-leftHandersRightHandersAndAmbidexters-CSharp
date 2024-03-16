using static System.Console;
using static System.Convert;
using static System.Math;

int l, r, a,res=0;

string str = ReadLine();
var arr = str.Split(" ");
l = ToInt32(arr[0]);
r = ToInt32(arr[1]);
a = ToInt32(arr[2]);

if (l == r)
{
    if (a % 2 == 0)
    {
        res = l + r + a;
       
    }
    else
    {
        res = l + r + a - 1;
        

    }
}
else
{
    int mx = Max(l,r);
    int mn = Min(r,l);
    if (a + mn <= mx)
    {
        res = (a + mn) * 2;
       
    }
    else
    {
        int x = a + mn - mx;
        if(x%2 == 0)
        {
            res = mx * 2 + x; 
        }
        else
        {
            res = mx * 2 + x - 1;
        }
    }
}

WriteLine(res);

