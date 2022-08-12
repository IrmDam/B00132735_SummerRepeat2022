using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public PlayerController playerController;
    public CollisionManager collisionManager;
    private bool ykeyStatus;
    private bool bkeyStatus;
    private bool rkeyStatus;
    private bool isWarningActive;
    private string ykeyStatusString;
    private string bkeyStatusString;
    private string rkeyStatusString;
    private GameObject exitDoor;
    public TextMeshProUGUI YellowKeyStatus;
    public TextMeshProUGUI BlueKeyStatus;
    public TextMeshProUGUI RedKeyStatus;
    public TextMeshProUGUI Objective;
    public TextMeshProUGUI reminder;
    public TextMeshProUGUI Timer;
    public bool startTimer;
    public bool timeOut;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {

        //Level 1 Timer is 150 seconds
        //Level 2 Timer is 75 seconds
        if (SceneManager.GetActiveScene().name.Equals("Level1"))
        {
            timer = 150;
        }

        if (SceneManager.GetActiveScene().name.Equals("Level2"))
        {
            timer = 75;
        }

        isWarningActive = false;
       ykeyStatus = false;
       rkeyStatus = false;
       bkeyStatus = false;
       UpdateScoreYellow(ykeyStatus);
       UpdateScoreRed(rkeyStatus);
       UpdateScoreBlue(bkeyStatus);
         if(!timeOut)
         {
            StartCoroutine(countDownTimer());
            startTimer = true;
         }
       StartCoroutine(showWarning());
    }

    // Update is called once per frame
    void Update()
    {
      
      WinCheck();
      if(startTimer && !timeOut)
      {
         timer -= Time.deltaTime;
         Timer.text = System.Math.Round(timer) + " seconds left";
      }
      timeOut = timer < 0f;
    }

    //If key is not picked up (ykeyStatus = false), the HUD shows it as an X
    //On pickup, change X to Found!
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

    //If all keys have been picked up, change objective text and destroy the door blocking the exit.
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

   public void StartLevel2()
   {
      SceneManager.LoadScene("Level2", LoadSceneMode.Single);
   }
   
    public void StartMenu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void WinScreen()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
        
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game Over", LoadSceneMode.Single);

    }

    //Called when colliding with door.
    public void DoorBump()
   {
      isWarningActive = true;
      
      
   }

    //When bumping the door, display reminder to get the keys. Reminder disappears after 4 seconds.
   IEnumerator showWarning()
   {
      while(true)
      {
         if(isWarningActive)
         {
         reminder.text = "You need to find all of the keys first!";
         isWarningActive = false;
         }
         yield return new WaitForSeconds(4.0f);
         reminder.text = " ";
      }
   }
   
    //Level timer. When timer runs out, lose the game.
      public IEnumerator countDownTimer()
      {
         yield return new WaitForSecondsRealtime(timer);
        GameOver();
      }



}
