/*              #########                       
              ############                     
              #############                    
             ##  ###########                   
            ###  ###### #####                  
            ### #######   ####                 
           ###  ########## ####                
          ####  ########### ####               
         ####   ###########  #####             
        #####   ### ########   #####           
       #####   ###   ########   ######         
      ######   ###  ###########   ######       
     ######   #### ##############  ######      
    #######  #####################  ######     
    #######  ######################  ######    
   #######  ###### #################  ######   
   #######  ###### ###### #########   ######   
   #######    ##  ######   ######     ######   
   #######        ######    #####     #####    
    ######        #####     #####     ####     
     #####        ####      #####     ###      
      #####       ###        ###      #        
        ###       ###        ###              
         ##       ###        ###               
__________#_______####_______####______________
    身是菩提树，心如明镜台，时时勤拂拭，勿使惹尘埃。
                我们的未来没有BUG              
* ==============================================================================
* Filename: Text_003
* Created:  $time$
* Author:   WYC
* Purpose:  委托
* ==============================================================================
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text_003 : MonoBehaviour
{

    private delegate string GetString();
	void Start ()
	{
	    int x = 40;
		GetString _get = new GetString(x.ToString);
	    print(_get());
	    GetString a = x.ToString;
	    print(a.Invoke());

	    PrintString print1 = MesHod1;
	    PrintStr(print1);
	    PrintString print2 = MesHod2;
	    PrintStr(print2);

	    //Action a1 = PrintStrin;

	    Func<int> a11 = Tex1;
	    print(a11());

	    Func<string, int> a12 = Tex2;
        print(a12("www"));

	    Func<int, string, int> a13 = Tex4;
	    print(a13(5,"eee"));

	    int[] sorInts = new[] {451, 2345, 1851, 784, 15, 2, 85, 46};
        Sort(sorInts);
	    foreach (int sorInt in sorInts)
	    {
	        print(sorInt);
	    }

        Employee[] employees=new Employee[]
        {
            new Employee("danfsd",23),
            new Employee("da45sd",233),
            new Employee("das45d",243),
            new Employee("9dagsd",2563),
            new Employee("daymsd",273),
            new Employee("dasrhd",283),
        };
        CommonSort<Employee>(employees,Employee.Cimpare);
	    foreach (Employee employee in employees)
	    {
	        print(employee.ToString());
	    }

	    Action aa = Te1;
	    aa += Te2;
	   // aa();
	   Delegate [] _delegates = aa.GetInvocationList();
	    for (int i = 0; i < _delegates.Length; i++)
	    {
	        _delegates[i].DynamicInvoke();
	    }
	}
    /// <summary>
    /// 数组排序
    /// </summary>
    /// <param name="sortInts"></param>
    public void Sort(int[] sortInts)
    {
        bool wapped = true;
        do
        {
            wapped = false;
            for (int i = 0; i < sortInts.Length - 1; i++)
            {
                if (sortInts[i] > sortInts[i + 1])
                {
                    int temp = sortInts[i];
                    sortInts[i] = sortInts[i + 1];
                    sortInts[i + 1] = temp;
                    wapped = true;
                }
            }
        } while (wapped);
    }
    /// <summary>
    /// 通用的冒泡排序
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sortInts"></param>
    /// <param name="comFunc"></param>
    public static void CommonSort<T>(T[] sortInts,Func<T,T,bool> comFunc)
    {
        bool wapped = true;
        do
        {
            wapped = false;
            for (int i = 0; i < sortInts.Length - 1; i++)
            {
                if (comFunc(sortInts[i],sortInts[i+1]))
                {
                    T temp = sortInts[i];
                    sortInts[i] = sortInts[i + 1];
                    sortInts[i + 1] = temp;
                    wapped = true;
                }
            }
        } while (wapped);
    }

    static void Te1()
    {
    
        Debug.Log("Text1");
    }
    static void Te2()
    {
        Debug.Log("Text2");
    }

    private int Tex4(int arg1, string arg2)
    {
        print(arg1);
        print(arg2);
        return 234;
    }

    private int Tex2(string arg1)
    {
        print(arg1);
        return 100;
    }

    static int Tex1()
    {
        return 1;
    }

    private void PrintStrin()
    {
        print("Hello World");
    }

    private delegate void PrintString();

    void PrintStr(PrintString print)
    {
        print();
    }

    void MesHod1()
    {
        print("老大");
    }
    void MesHod2()
    {
        print("老二");
    }

}

class Employee
{
    public string Name { get; private set; }
    public int Salary { get; private set; }

    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public static bool Cimpare(Employee e1, Employee e2)
    {
        if (e1.Salary>e2.Salary)
        {
            return true;
        }
        return false;
    }

    public override String ToString()
    {
        return Name + ": " + Salary;
    }
}
