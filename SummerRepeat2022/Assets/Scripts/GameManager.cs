using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public PlayerController playerController;
   public KeyCollide keyCollide;
    private bool ykeyStatus;
    private bool bkeyStatus;
    private bool rkeyStatus;
    private string ykeyStatusString;
    private string bkeyStatusString;
    private string rkeyStatusString;
    private GameObject exitDoor;
    public TextMeshProUGUI YellowKeyStatus;
    public TextMeshProUGUI BlueKeyStatus;
    public TextMeshProUGUI RedKeyStatus;
    public TextMeshProUGUI Objective;
    public TextMeshProUGUI reminder;
    // Start is called before the first frame update
    void Start()
    {
       ykeyStatus = false;
       rkeyStatus = false;
       bkeyStatus = false;
       UpdateScoreYellow(ykeyStatus);
       UpdateScoreRed(rkeyStatus);
       UpdateScoreBlue(bkeyStatus);
       
    }

    // Update is called once per frame
    void Update()
    {
      WinCheck();
    }

    public void UpdateScoreYellow(bool ykeyStatus)
    {
       this.ykeyStatus = ykeyStatus;
       if(this.ykeyStatus == false)
       {
        ykeyStatusString= " X ";
        YellowKeyStatus.text = "Yellow Key: " + ykeyStatusString;
       }
       else
       {
        ykeyStatusString= " Found! ";
        YellowKeyStatus.text = "Yellow Key: " + ykeyStatusString;
        
       }
       
       
    }


    public void UpdateScoreRed(bool rkeyStatus)
    {
     
      this.rkeyStatus = rkeyStatus;
       if(this.rkeyStatus == false)
       {
        rkeyStatusString= " X ";
       }
        else
       {
        rkeyStatusString= " Found! ";
        
       }

      RedKeyStatus.text = "Red Key: " + rkeyStatusString;
      
    }

    public void UpdateScoreBlue(bool bkeyStatus)
    {
      this.bkeyStatus = bkeyStatus;   
       if(this.bkeyStatus == false)
       {
        bkeyStatusString= " X ";
        BlueKeyStatus.text = "Red Key: " + bkeyStatusString;
       }
       else
       {
        bkeyStatusString= " Found! ";
        BlueKeyStatus.text = "Red Key: " + bkeyStatusString;
        
       }
      
    }
    public void WinCheck()
   {
      if(bkeyStatus == true && ykeyStatus == true && rkeyStatus == true)
      {
         Objective.text = "Head for the exit!";
         exitDoor = GameObject.FindWithTag("KeyDoor");
         Destroy(exitDoor);
         
      }

   }

   public void StartLevel1()
   {
      SceneManager.LoadScene("Level1", LoadSceneMode.Single);
   }

   
   public void DoorBump()
   {
      reminder.text = "You need to find all of the keys first!";
      playerController.doorAudio.PlayOneShot(playerController.deniedSound, 0.32f);
      
   }

}
