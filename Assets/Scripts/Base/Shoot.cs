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
* Filename: Shoot
* Created:  $time$
* Author:   WYC
* Purpose:  资源池-Object Pool技术
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;

    public int bullrtCount = 30;

    private List<GameObject> bulletList = new List<GameObject>();
	
	void Start ()
	{
	    InitButtet();

	}


    void InitButtet()
    {
        for (int i = 0; i < bullrtCount; i++)
        {
            GameObject go = Instantiate(bulletPrefab);
            bulletList.Add(go);
            go.transform.parent = transform;
            go.SetActive(false);
        }
    }

    GameObject FireBullet()
    {
        foreach (GameObject o in bulletList)
        {
            if (o.activeInHierarchy ==false)
            {
                o.SetActive(true);
                return o;
            }
        }
        return null;
    }

    void Update () {

	    if (Input.GetMouseButtonDown(0))
	    {
	       // GameObject go = GameObject.Instantiate(bulletPrefab,transform.position,transform .rotation);
	        GameObject go = FireBullet();
	        go.transform.position = transform.position;
	        go.GetComponent<Rigidbody>().velocity = transform.forward * 25;
          //  Destroy(go,3);
	        StartCoroutine(Destroys(go));
	    }
	}

    IEnumerator Destroys(GameObject obj) {
        yield return new WaitForSeconds(3);
        obj.SetActive(false);
    }
}
