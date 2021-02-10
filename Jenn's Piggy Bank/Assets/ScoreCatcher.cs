using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCatcher : MonoBehaviour
{
    [SerializeField] Text scoreMesh;
    [SerializeField] AudioClip coinSound;
    [SerializeField] AudioSource coinSoundPlayer;
    private void OnCollisionEnter(Collision collision)
    {
        var scroreStr = scoreMesh.text.Split(' ')[1];
        int scoreVal = 0;
        int.TryParse(scroreStr, out scoreVal);
        scoreVal++;
        scoreMesh.text = "Score: " + scoreVal;
        coinSoundPlayer.PlayOneShot(coinSound);
        Destroy(collision.gameObject);
    }
}
