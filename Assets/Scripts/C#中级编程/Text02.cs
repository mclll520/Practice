using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 多态方法运用
/// </summary>
public class Text02 : MonoBehaviour {

	void Start () {
        //Person person = new Student();
        //person.StandUp();
        //Person person1 = new Tescher();
        //person1.StandUp();
        //Person person2 = new HwadMaster();
        //person2.StandUp();



    }
	
	void Update () {
		
	}
}
/// <summary>
/// 抽象类
/// </summary>
public abstract class Person{
    public abstract void StandUp();
}

public class Student : Person {
    public override void StandUp()
    {
        Debug.Log("学生起立");
    }
}
public class Tescher : Person
{
    public override void StandUp()
    {
        Debug.Log("老师起立");
    }
}
public class HwadMaster : Person
{
    public override void StandUp()
    {
        Debug.Log("校长起立");
    }
}