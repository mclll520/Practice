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
* Filename: Text09
* Created:  $time$
* Author:   WYC
* Purpose:  抽象类
* ==============================================================================
*/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text09 : MonoBehaviour {

	
	void Start () {
        //Animal cat = new Cat(2);
        //cat.Bark();
        //Animal dog = new Dog(1);
        //dog.Bark();
        //dog.TestSbell();

        //Shape ci = new Circle(5);
        //Debug.Log(ci.getPeri());
        //Debug.Log(ci.getArea());
        //Shape cr = new Square(4,8);
        //Debug.Log(cr.getPeri());
        //Debug.Log(cr.getArea());

        MobileDisk md = new MobileDisk();
        UDisk ud = new UDisk();
        MP3 mP3 = new MP3();
        Computer cpu = new Computer();
        cpu.CpuRead(md);
        cpu.CpuWrite(ud);
	    cpu.CpuWrite(mP3);
    }
	
}
public abstract class Animal
{
    private int _age;

    public int Age
    {
        get
        {
            return _age;
        }

        set
        {
            _age = value;
        }
    }
    public Animal(int age) {
        this.Age = age;
    }
    public abstract void Bark();

    public virtual void TestSbell() {
        Debug.Log("我是大坏比");
    }
}
public class Dog:Animal
{
    public Dog(int age) : base(age)
    {
    }

    public override void Bark()
    {
        Debug.Log("小狗汪汪叫"+Age);
    }
    public override void TestSbell()
    {
        Debug.Log("你真帅");
    }
}
public class Cat : Animal
{
    public Cat(int age) : base(age)
    {
    }

    public override void Bark()
    {
        Debug.Log("小猫汪汪叫" + Age);
    }
}

public abstract class Shape
{
    public abstract double getArea();
    public abstract double getPeri();
}
public class Circle : Shape
{
    private double _r;

    public Circle(double r)
    {
        R = r;
    }

    public double R
    {
        get
        {
            return _r;
        }

        set
        {
            _r = value;
        }
    }

    public override double getArea()
    {
        return Math.PI * R * R;
    }

    public override double getPeri()
    {
        return Math.PI * R * 2;
    }
}
public class Square : Shape
{
    private double _height;
    private double _width;

    public double Height
    {
        get
        {
            return _height;
        }

        set
        {
            _height = value;
        }
    }

    public double Width
    {
        get
        {
            return _width;
        }

        set
        {
            _width = value;
        }
    }

    public Square(double height, double width) {
        Height = height;
        Width = width;
    }

    public override double getArea()
    {
        return Height * Width;
    }

    public override double getPeri()
    {
        return (Height + Width) * 2;
    }
}

public abstract class MobileStorage
{
    public abstract void Read();
    public abstract void Write();
}
public class MobileDisk : MobileStorage
{
    public override void Read()
    {
        Debug.Log("移动硬盘在读取数据");
    }

    public override void Write()
    {
        Debug.Log("移动硬盘在写入数据");
    }
}
public class UDisk : MobileStorage
{
    public override void Read()
    {
        Debug.Log("U盘在读取数据");
    }

    public override void Write()
    {
        Debug.Log("U盘在写入数据");
    }
}
public class MP3 : MobileStorage
{
    public override void Read()
    {
        Debug.Log("MP3在读取数据");
    }

    public override void Write()
    {
        Debug.Log("MP3在写入数据");
    }
}
public class Computer
{
    public void CpuRead(MobileStorage ms) {
        ms.Read();
    }
    public void CpuWrite(MobileStorage ms) {
        ms.Write();
    }
}

