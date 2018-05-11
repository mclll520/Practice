using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : MonoBehaviour {

    public  Transform target;
    public float speed = 1;


    public Vector3 vector = Vector3.forward;
    private Animation anim;
    public float animRandom = 2;
    IEnumerator Start () {
        target = GameObject.Find("target").transform;

        anim = GetComponentInChildren<Animation>();
        yield return new WaitForSeconds(Random.Range(0, animRandom));
        anim.Play();
    }
	
	
	void Update () {
        //transform.Translate(vector * Time.deltaTime, Space.World);

        transform.LookAt(target.position);
        transform.Translate(vector * Time.deltaTime);
	}
}
