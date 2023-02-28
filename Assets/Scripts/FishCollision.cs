using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            ScoreManager.instance.AddScore();
        }

        if (collision.gameObject.tag == "FishDestroyer")
        {
            Destroy(gameObject);
            LivesManager.instance.RemoveLive();
        }
    }
}
