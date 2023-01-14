using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class MatchMessage : MonoBehaviour
{
    public GameObject matchMessage;
    public static int goalsPlayerTeam = 0;
    public static int goalsOpponentTeam = 0;
    public static int sceneIteration = 0;
    public static int playerScenes = 2;
    public static int computerScenes = 3;

    private bool started = false;
    private int isPlayerSceneNext = 0;
    private float timeElapsed = 0f;
    private float delayBeforeLoading = 5.0f;
    private float waitBeforeTakingActiion = 3.0f;
    private string sceneToLoad;

    private string[] opponentGoalMessages = { 
        "The defender makes a clumsy challenge and the striker has captured the ball... AND HE SCORES!",
        "Great string of passes on the left side...the ball is crossed to the near post...AND THE STRIKER DELIVERS! WHAT A HIT!"
    };

    private (string, string)[] playerSceneMessages = new[] {
        ("You are through on goal on the righ side!", "ShootingFromAction"),
        ("Your team has received a penalty and you are going to execute it!", "Penalty")
    };

    void Start()
    {
        matchMessage.GetComponent<TextMeshProUGUI>().text = $"The score is {goalsPlayerTeam} - {goalsOpponentTeam}";
    }
    // Update is called once per frame
    void Update()
    {
        if (waitBeforeTakingActiion > 0.0f)
        {
            waitBeforeTakingActiion -= Time.deltaTime;
            return;
        }

        // check if the match action was chosen or not
        if(!started)
        {
            started = true;

            var random = new System.Random(Guid.NewGuid().GetHashCode());

            if (playerScenes + computerScenes == 0)
            {
                matchMessage.GetComponent<TextMeshProUGUI>().text = $"The referee blows the whistle! The result is {goalsPlayerTeam} - {goalsOpponentTeam}";
            }
            else
            {

                if (computerScenes == 0)
                {
                    isPlayerSceneNext = 1;
                }
                else
                {
                    if (playerScenes == 0)
                    {
                        isPlayerSceneNext = 0;
                    }
                    else
                    {
                        isPlayerSceneNext = random.Next(0, 2);
                    }
                }

                // choosen one scene at random, for either the player or the opponent
                if (isPlayerSceneNext == 1)
                {
                    playerScenes -= 1;
                    var chosenScene = random.Next(0, playerSceneMessages.Length);
                    matchMessage.GetComponent<TextMeshProUGUI>().text = playerSceneMessages[chosenScene].Item1;

                    sceneToLoad = playerSceneMessages[chosenScene].Item2;
                }
                else
                {
                    computerScenes -= 1;
                    var chosenMessage = random.Next(0, opponentGoalMessages.Length);
                    matchMessage.GetComponent<TextMeshProUGUI>().text = opponentGoalMessages[chosenMessage];

                    goalsOpponentTeam += 1;
                    sceneToLoad = SceneManager.GetActiveScene().name;
                }
            }
        }
        // wait some time before actually loading the new scene
        else
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed > delayBeforeLoading)
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
