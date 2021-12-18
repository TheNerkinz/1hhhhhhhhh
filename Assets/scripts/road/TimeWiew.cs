using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeWiew : MonoBehaviour {

   private float currentTime = 0f;

    private void Update()
    {
        currentTime += Time.deltaTime;

    }
    public int GetMinutes()
    {
        return (int)currentTime;
    }

}
