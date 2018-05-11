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
* Filename: CubeGamees
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CubeGamees : MonoBehaviour
{
    public int cubes = 25;
    public GameObject cube;
    private GameObject g;
	void Start () {
  
	    for (int i = 0; i < cubes; i++)
	    {
	        for (int j = 0; j < cubes; j++)
	        {
	            GameObject g = Instantiate(cube, new Vector3(i, 0, j), Quaternion.identity);
	            g.transform.parent = transform;
	           // StartCoroutine(waitEnumerator(j % cubes + i, g));
	        }
	    }
	}

    void Update()
    {
        if (Input .GetKeyDown(KeyCode.Q))
        {
            PlayAnimWave();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            DaoPlayAnimWave();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            DaoxuPlayAnimWave();
        }

    }
    public void FinishAnim()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform. GetChild(i).gameObject.GetComponent<testcubeScript>().Finish();
        }
    }

    private void DaoxuPlayAnimWave()
    {
        for (int i = transform.childCount -1 ; i >=  0 ; i--)
        {
            StartCoroutine(DaoxuwaitEnumerator(i % cubes + i / cubes, transform.GetChild(i).gameObject));
        }
    }

    IEnumerator DaoxuwaitEnumerator(int num, GameObject gameObject)
    {
        yield return new WaitForSeconds(num);
        gameObject.GetComponent<Animator>().SetBool("cube9", true);
    }



    private void DaoPlayAnimWave()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            StartCoroutine(DaowaitEnumerator(i % cubes + i / cubes, transform.GetChild(i).gameObject));
        }
    }

    IEnumerator DaowaitEnumerator(int num, GameObject gameObject)
    {
        yield return new WaitForSeconds(num);
        gameObject.GetComponent<Animator>().SetBool("cube9", false);
    }

    private void PlayAnimWave()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            StartCoroutine(waitEnumerator(i % cubes + i / cubes, transform .GetChild(i).gameObject));
        }
    }


    IEnumerator waitEnumerator(int num,GameObject gameObject)
    {
        float a =(float) num / 10;
        yield return new WaitForSeconds(a);
        gameObject.GetComponent<Animator>().SetBool("cube9", true);
    }

}
