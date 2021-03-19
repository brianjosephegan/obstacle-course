using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            FindObjectOfType<LevelLoader>().LoadNextLevel();
        }
    }
}
