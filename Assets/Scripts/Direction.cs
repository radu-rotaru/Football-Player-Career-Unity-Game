using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Direction : MonoBehaviour
{
    [SerializeField]
    private Button directionBarButton;
    [SerializeField]
    private Image directionBarImage;

    private float barSpeed = 100.0f;
    private bool isMovingRight;
    private bool isNotClickedYet;
    private float halfOfBarWidth;
    private float maxPosX;
    private float minPosX;
    private Vector3 maxDirection;
    private Vector3 minDirection;
    private float leftRangeAngle = -75.0f;
    private float rightRangeAngle = 75.0f;

    void Start()
    {
        isMovingRight = true;
        isNotClickedYet = true;
        halfOfBarWidth = directionBarButton.GetComponent<RectTransform>().sizeDelta.x / 2;
        minPosX = directionBarButton.GetComponent<RectTransform>().anchoredPosition.x - halfOfBarWidth;
        maxPosX = directionBarButton.GetComponent<RectTransform>().anchoredPosition.x + halfOfBarWidth;
        minDirection = new Vector2(minPosX, 0.0f);
        maxDirection = new Vector2(maxPosX, 0.0f);
    }

    void Update()
    {
        if (isNotClickedYet)
        {
            DirectionBarMovement();
        }
    }

    public void EndDirectionBar()
    {
        isNotClickedYet = false;
        float posX = directionBarImage.GetComponent<RectTransform>().anchoredPosition.x;

        float directionAngle = (rightRangeAngle - leftRangeAngle) * (posX - minPosX) / (maxPosX - minPosX) + leftRangeAngle;
        Shooting.direction = Quaternion.AngleAxis(directionAngle, Vector3.up) * Vector3.right;
    }

    public void DirectionBarMovement()
    {
        if(isMovingRight)
        {
            directionBarImage.GetComponent<RectTransform>().anchoredPosition += new Vector2(Time.deltaTime * barSpeed, 0.0f);

            if (directionBarImage.GetComponent<RectTransform>().anchoredPosition.x >= maxPosX)
            {
                isMovingRight = false;
                directionBarImage.GetComponent<RectTransform>().anchoredPosition = new Vector2(maxPosX, directionBarImage.GetComponent<RectTransform>().anchoredPosition.y);
            }
        }
        else
        {
            directionBarImage.GetComponent<RectTransform>().anchoredPosition -= new Vector2(Time.deltaTime * barSpeed, 0.0f);

            if (directionBarImage.GetComponent<RectTransform>().anchoredPosition.x <= minPosX)
            {
                isMovingRight = true;
                directionBarImage.GetComponent<RectTransform>().anchoredPosition = new Vector2(minPosX, directionBarImage.GetComponent<RectTransform>().anchoredPosition.y);
            }
        }
    }
}
