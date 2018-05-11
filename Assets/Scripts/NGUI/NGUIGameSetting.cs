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
* Filename: NGUIGameSetting
* Created:  $time$
* Author:   WYC
* Purpose:  
* ==============================================================================
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameGrade
{
    EASY,
    NORMAL,
    DIFFCULTY
}
public enum ControlType
{
    Keyboard,
    Touch,
    Mouse
}
public class NGUIGameSetting : MonoBehaviour {

    public  float volunme = 1;
    public  GameGrade grade = GameGrade.NORMAL;
    public  ControlType controlType = ControlType.Mouse;
    public  bool IsFullscreen = false;

    public TweenPosition startPos;
    public TweenPosition EndPos;

    public void OnVolumeChanged() {
        volunme = UIProgressBar.current.value;

    }


    public void OnGameGradeChanged()
    {
        switch (UIPopupList.current.value.Trim())
        {
            case "简单":
                grade = GameGrade.EASY;
                break;
            case "一般":
                grade = GameGrade.NORMAL;
                break;
            case "困难":
                grade = GameGrade.DIFFCULTY;
                break;
            default:
                break;
        }
    }

    public void OnControlTypeChanged()
    {
        print(UIPopupList.current.value);
        switch (UIPopupList.current.value.Trim())
        {
            case "键盘":
                controlType = ControlType.Keyboard;
                break;
            case "鼠标":
                controlType = ControlType.Mouse;
                break;
            case "触摸":
                controlType = ControlType.Touch;
                break;
            default:
                break;
        }

    }

    public void OnIsFullscreenChanged()
    {
        IsFullscreen = UIToggle.current.value;
        print(IsFullscreen);
    }

    public void OnOptionChanged()
    {
        startPos.PlayForward();
        EndPos.PlayForward();
    }

    public void OnCompleteChanged()
    {
        startPos.PlayReverse();
        EndPos.PlayReverse();
    }

    void Start () {
     

    }
	
	
	void Update () {
		
	}
}
