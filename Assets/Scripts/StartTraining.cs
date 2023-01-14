using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartTraining : MonoBehaviour
{
    public GameObject messageObj;
    private string alreadyDoneTrainingMessage = "You have already trained!";
    private string trainingScene = "Training";

    public void LoadScene()
    {
        if(Click.done)
        {
            messageObj.GetComponent<TextMeshProUGUI>().text = alreadyDoneTrainingMessage;
        }
        else
        {
            SceneManager.LoadScene(trainingScene);
        }
    }
}
