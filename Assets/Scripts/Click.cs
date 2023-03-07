using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    float xPrevious = 0;
    float posYNew;
    float posX; //tıkladığım yer
    float diff;
    float diffAbs;
    public GameObject stackPrefab;
    float newStackLength;

    StackMovement stackMovement;


    private void Update()
    {
        InstantiateStationaryStack();
    }

    void InstantiateStationaryStack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            posYNew = transform.position.y + transform.localScale.y;

            posX = transform.position.x;

            diff = posX - xPrevious;
            diffAbs = Mathf.Abs(diff);
            newStackLength = transform.localScale.x - diffAbs;
            Debug.Log(newStackLength);

            GameObject newPrefab = Instantiate(stackPrefab, new Vector3(posX - diff / 2, transform.position.y, transform.position.z), Quaternion.identity);

            newPrefab.transform.localScale = new Vector3(newStackLength, transform.localScale.y, transform.localScale.z);

            transform.position = new Vector3(-100, posYNew, transform.position.z);
            transform.localScale = new Vector3(newStackLength, transform.localScale.y, transform.localScale.z);


            xPrevious = posX - diff / 2;
        }
    }

}
