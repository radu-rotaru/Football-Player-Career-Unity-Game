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
    public GameObject goalScoredAudio;
    public GameObject missedChanceAudio;
    public static int goalsPlayerTeam = 0;
    public static int goalsOpponentTeam = 0;
    public static int playerScenes = 1;
    public static int playerTeamScenes = 5 - playerScenes;
    public static int computerScenes = 5;
    public static int matchCount = 0;
    public int quarter = 0;
    public int semiFinals = 0;
    public int finals = 0;
    private bool started = false;
    private int isPlayerTeamSceneNext = 0;
    private float timeElapsed = 0f;
    private float delayBeforeLoading = 5.0f;
    private float waitBeforeTakingActiion = 3.0f;
    private string sceneToLoad;

    private string endScene = "PlayScene";

    private string[] goalMessages = {
    "The team has just put the ball in the back of the net with a well-placed shot, a great finish that showcases their attacking prowess. The player cut through the defense and placed it perfectly in the corner.",
    "A goal has been scored, the team putting in a great effort to make it happen. The players showed great coordination and skill on the play, with a quick one-two passing play that opened up the defense.",
    "The team has struck with a quick counter-attack, leaving the defense scrambling. The player received the ball on the breakaway and calmly finished past the goalkeeper",
    "A beautiful goal from the team, they have certainly shown their attacking prowess with this one. The opposing team's defense was left in shambles as the player dribbled past several defenders before scoring.",
    "The team has capitalized on a set-piece opportunity and scored a crucial goal. The player rose highest to head the ball into the back of the net from the corner.",
    "A well-executed team goal, the players showing great coordination and skill as they worked the ball into the back of the net with a series of crisp passes, before the final shot was taken.",
    "The team has found the back of the net with a clinical finish, a great move that showcases the team's attacking prowess. The player received the ball in the box and took a quick shot to beat the goalkeeper.",
    "The team has just scored a goal with a perfectly placed header, leaving the goalkeeper with no chance of making the save. The player rose highest to meet the cross and sent the ball into the back of the net.",
    "A fantastic goal from the team, showing their determination and grit as they fought for the score. The player picked up the loose ball in the box and took a quick shot, beating the goalkeeper.",
    "The team has scored, putting in a great effort to make it happen. The player received the ball on the edge of the box and took a well-placed shot that found its way into the back of the net."
    };

    private string[] missMessages = {
    "The team had a great chance to score but missed it, the player took a shot wide of the goal. The keeper was well beaten, but the player was unlucky on that one",
    "A golden opportunity for the team goes begging, the player was through on goal but failed to hit the target. The keeper had no chance, but the shot was off target",
    "The team had a clear opening but couldn't capitalize, the player's shot hit the post and rebounded out. It was a great effort but unluckily it didn't go in",
    "A chance goes begging for the team, the player had a free header but couldn't direct it on target. The keeper had it covered, but the player will be disappointed with that miss",
    "The team had a great opportunity to score but failed to convert, the player missed the target with his shot. The crowd groan in disappointment",
    "A good chance for the team goes begging, the player took a shot that was blocked by the defender. The team will regret not making more of that opportunity",
    "The team had a clear cut chance but failed to take it, the player's shot went over the bar. The keeper had no chance, but the player will be disappointed with that miss",
    "A great chance for the team goes begging, the player's shot is saved by the keeper. The crowd holds their breath but the ball stays out",
    "The team had a good opening but couldn't convert, the player's shot was blocked by a defender. The team will be disappointed not to have made more of that chance",
    "A golden opportunity for the team goes begging, the player fails to connect properly with the ball and it goes wide. The crowd sighs in disappointment"
    };


    private (string, string)[] playerSceneMessages = new[] {
        ("You are through on goal on the right side!", "ShootingFromActionRight"),
        ("You are through on goal on the left side!", "ShootingFromActionLeft"),
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
        if (!started)
        {
            started = true;

            // no more scenes, the match is over
            if (playerScenes + playerTeamScenes + computerScenes == 0)
            {
                if (goalsPlayerTeam != goalsOpponentTeam)
                {
                    matchMessage.GetComponent<TextMeshProUGUI>().text = $"The referee blows the whistle! The result is {goalsPlayerTeam} - {goalsOpponentTeam}";
                    if (goalsPlayerTeam - goalsOpponentTeam > 0)
                    {
                        if (matchCount == 0)
                        {
                            quarter = 1;
                            matchCount++;
                        }
                        else if (matchCount == 1)
                        {
                            matchCount++;
                            semiFinals = 1;
                        }
                        else if (matchCount == 2)
                        {
                            matchCount++;
                            finals = 1;
                        }
                        else if(matchCount == 3)
                        {
                            finals = 2;
                            //WIN SCENE
                        }
                    }
                    else if (goalsOpponentTeam - goalsPlayerTeam > 0)
                    {
                        goalsPlayerTeam = 0;
                        goalsOpponentTeam = 0;
                        playerScenes = 1;
                        playerTeamScenes = 5 - playerScenes;
                        computerScenes = 5;
                        matchCount = 0;
                        quarter = 0;
                        semiFinals = 0;
                        finals = 0;
                    }
                    
                    
                    Click.done = false;
                    goalsPlayerTeam = 0;
                    goalsOpponentTeam = 0;
                    computerScenes = 5;

                    sceneToLoad = endScene;
                }
                else
                {
                    playerTeamScenes = 1;
                    computerScenes = 1;
                    started = false;
                }
            }
            else
            {
                var random = new System.Random(Guid.NewGuid().GetHashCode());
                // no more scenes for the opponent
                if (computerScenes == 0)
                {
                    isPlayerTeamSceneNext = 1;
                }
                else
                {
                    // no more scenes for the player's team
                    if (playerScenes + playerTeamScenes == 0)
                    {
                        isPlayerTeamSceneNext = 0;
                    }
                    // choose at random otherwise
                    else
                    {
                        isPlayerTeamSceneNext = random.Next(0, 2);
                    }
                }

                // choosen one scene at random, for the player's team
                if (isPlayerTeamSceneNext == 1)
                {
                    var isPlayerAction = 0;

                    if (playerScenes == 0)
                    {
                        isPlayerAction = 0;
                    }
                    else if (playerTeamScenes == 0)
                    {
                        isPlayerAction = 1;
                    }
                    else
                    {
                        isPlayerAction = random.Next(0, 2);
                    }

                    // chose one scene at random for the player
                    if (isPlayerAction == 1)
                    {
                        playerScenes -= 1;

                        var chosenScene = random.Next(0, playerSceneMessages.Length);
                        matchMessage.GetComponent<TextMeshProUGUI>().text = playerSceneMessages[chosenScene].Item1;

                        sceneToLoad = playerSceneMessages[chosenScene].Item2;
                    }
                    else
                    {
                        playerTeamScenes -= 1;
                        // check if the team's action is goal or miss
                        var isGoal = random.Next(0, 2);

                        if (isGoal == 1)
                        {
                            AudioPlayer.playAudio(goalScoredAudio.GetComponent<AudioSource>(), 11.0f);
                            var chosenMessage = random.Next(0, goalMessages.Length);
                            matchMessage.GetComponent<TextMeshProUGUI>().text = $"Your team: \n {goalMessages[chosenMessage]}";
                            goalsPlayerTeam += 1;
                        }
                        else
                        {
                            AudioPlayer.playAudio(missedChanceAudio.GetComponent<AudioSource>(), 5.0f);
                            var chosenMessage = random.Next(0, missMessages.Length);
                            matchMessage.GetComponent<TextMeshProUGUI>().text = $"Your team: \n {missMessages[chosenMessage]}";
                        }

                        sceneToLoad = SceneManager.GetActiveScene().name;
                    }
                }
                else
                {
                    computerScenes -= 1;

                    // check if the team's opponent is goal or miss
                    var isGoal = random.Next(0, 2);

                    if (isGoal == 1)
                    {
                        AudioPlayer.playAudio(goalScoredAudio.GetComponent<AudioSource>(), 11.0f);
                        var chosenMessage = random.Next(0, goalMessages.Length);
                        matchMessage.GetComponent<TextMeshProUGUI>().text = $"Opponent Team: \n {goalMessages[chosenMessage]}";
                        goalsOpponentTeam += 1;
                    }
                    else
                    {
                        AudioPlayer.playAudio(missedChanceAudio.GetComponent<AudioSource>(), 5.0f);
                        var chosenMessage = random.Next(0, missMessages.Length);
                        matchMessage.GetComponent<TextMeshProUGUI>().text = $"Opponent Team: \n {missMessages[chosenMessage]}";
                    }

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
