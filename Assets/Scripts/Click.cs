using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    float posYNew; // After we clicked, the stack will move up by its thickness(localScale.y)
    float xPrevious = 0; // The last position of the stack just before our click
    float diff; // Difference between posX and xPrevious
    float diffAbs; // It is for the new length of the stack. It should be positive
    public GameObject stackPrefab; // The new stack will be instantiated exactly the same position as the stack
    float newStackLength; // The stackPrefab should instantiate the length of the stack minus diffAbs
    float newStackPosX; // This is for the side where we want to instantiate the new stack

    private void Update()
    {
        if (!GameManager.gameOver)
        {
            InstantiateStationaryStack();
        }
    }

    void InstantiateStationaryStack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posYNew = transform.position.y + transform.localScale.y;

            diff = transform.position.x - xPrevious;
            diffAbs = Mathf.Abs(diff);
            newStackLength = transform.localScale.x - diffAbs;
            Debug.Log(newStackLength);

            if (newStackLength <= 0)
            {
                GameManager.gameOver = true;
            }

            newStackPosX = transform.position.x - diff / 2;

            GameObject newPrefab = Instantiate(stackPrefab, new Vector3(newStackPosX, transform.position.y, transform.position.z), Quaternion.identity);

            newPrefab.transform.localScale = new Vector3(newStackLength, transform.localScale.y, transform.localScale.z);

            transform.position = new Vector3(StackMovement.stackStartPosX, posYNew, transform.position.z);
            transform.localScale = new Vector3(newStackLength, transform.localScale.y, transform.localScale.z);

            xPrevious = newStackPosX;
        }
    }
}
