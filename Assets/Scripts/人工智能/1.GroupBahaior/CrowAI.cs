using System.Collections.Generic;
using UnityEngine;

public class CrowAI : MonoBehaviour {
    //当前速度 
    public float speed = 10;
    public Vector3 velocity = Vector3.forward;
    private Vector3 startVelocity;//初始化当前速度
    public Transform target;//目标点
    //总力
    public Vector3 sumForce = Vector3.zero;
    //质量
    public float m = 3;

    //分离的力
    public float sparationDistance = 3;   //分离的距离
    public List<GameObject> sparationNeighbors = new List<GameObject>();
    public float sparationWeight = 1; //权重
    public Vector3 sparationForce = Vector3.zero;

    //队列的力
    public float alignmentDistance = 4;
    public List<GameObject> alignmentNeighbors = new List<GameObject>();
    public float alignmentWeight = 1; //权重
    public Vector3 alignmentForce = Vector3.zero;

    //聚集的力
    public float cohesionWeight = 3;//权重
    public Vector3 cohesionForce = Vector3.zero;
    //间隔几秒检测一次
    public float checkInterval = 0.2f;

    private Animation anim;
    public float animRandom = 2;
    void Start()
    {
        target = GameObject.Find("target").transform;
        startVelocity = velocity;
        //0 秒后调用 CalcForce() 方法，并且之后每隔 checkInterval 秒调用一次 CalcForce() 方法
        InvokeRepeating("CalcForce", 0, checkInterval);
        anim = GetComponentInChildren<Animation>();
        Invoke("Playanim", Random.Range(0, animRandom));
    }
    void Playanim() {
        anim.Play();
    }

    void CalcForce() {
        //计算之前先归零
        sumForce = Vector3.zero;
        sparationForce = Vector3.zero;
        alignmentForce = Vector3.zero;
        cohesionForce = Vector3.zero;

        //先清空集合
        sparationNeighbors.Clear();
        Collider[] colliders = Physics.OverlapSphere(transform.position, sparationDistance);
        foreach (Collider c in colliders)
        {
            //判断该物体近的邻居
            if (c!=null && c.gameObject!=this.gameObject)
            {
                sparationNeighbors.Add(c.gameObject);
            }
        }

        //1.计算分离的力
        foreach (GameObject neighbor in sparationNeighbors)
        {
            Vector3 dir = transform.position - neighbor.transform.position;
            sparationForce += dir.normalized / dir.magnitude;
        }
        //如果附近有物体
        if (sparationNeighbors.Count > 0)
        {
            //得到分离的力
            sparationForce *= sparationWeight;
            //得到的力赋值给总力
            sumForce += sparationForce;
        }

        //2.计算队列的力(整体一个前进的力)
        alignmentNeighbors.Clear();
        colliders = Physics.OverlapSphere(transform.position, alignmentDistance);
        foreach (Collider c in colliders)
        {
            if (c!=null &&c.gameObject !=this.gameObject)
            {
                alignmentNeighbors.Add(c.gameObject);
            }
        }
        //计算邻居的平均朝向
        Vector3 avgDir = Vector3.zero;
        //朝向的总和
        foreach (GameObject n in alignmentNeighbors)
        {
            avgDir += n.transform.forward;
        }
        if (alignmentNeighbors.Count >0)
        {
            //得到平均数
            avgDir /= alignmentNeighbors.Count;
            //得到相对方向
            alignmentForce = avgDir = transform.forward;
            alignmentForce *= alignmentWeight;
            //得到的力赋值给总力
            sumForce += alignmentForce;
        }

        //3.聚集的力
        if (alignmentNeighbors.Count > 0)
        {
            Vector3 center = Vector3.zero;
            foreach (GameObject n in alignmentNeighbors)
            {
                center += n.transform.position;
            }
            center /= alignmentNeighbors.Count;
            Vector3 dirToCenter = center - transform.position;
            cohesionForce += dirToCenter.normalized * velocity.magnitude;
            cohesionForce *= cohesionWeight;
            sumForce += cohesionForce;
        }

        //4.保持恒定飞行速度的力
        Vector3 enginForce = velocity.normalized * startVelocity.magnitude;
        sumForce += enginForce * 0.1f;
        //4.保持恒定目标飞行的效果
        Vector3 targetDir = target.position - transform.position;
        sumForce += (targetDir.normalized - transform.forward)*speed;
    }


    void Update () {
        //加速度（根据牛顿第二定律）
        Vector3 a = sumForce / m;
        //计算出速度
        velocity += a * Time.deltaTime;
        //物体运行
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(velocity), Time.deltaTime*3);
        transform.Translate(transform.forward * Time.deltaTime * velocity .magnitude, Space.World);
	}
}
