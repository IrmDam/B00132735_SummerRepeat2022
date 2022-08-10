using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    private bool ykeyStatus;
    private bool bkeyStatus;
    private bool rkeyStatus;
    private string ykeyStatusString;
    private string bkeyStatusString;
    private string rkeyStatusString;
    public TextMeshProUGUI YellowKeyStatus;
    public TextMeshProUGUI BlueKeyStatus;
    public TextMeshProUGUI RedKeyStatus;
    // Start is called before the first frame update
    void Start()
    {
       bkeyStatusString= " X ";
       rkeyStatusString= " X ";
       ykeyStatusString = " X "; 
       YellowKeyStatus.text = "Yellow Key: " + ykeyStatusString;
       BlueKeyStatus.text = "Blue Key: " + bkeyStatusString;
       YellowKeyStatus.text = "Red Key: " + rkeyStatusString;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
