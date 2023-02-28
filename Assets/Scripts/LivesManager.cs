using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class LivesManager : MonoBehaviour
{
    public static LivesManager instance;
    private int liveCounter = 5;
    private GameObject[] livesImageUI;
    private Color UIImageColor;
    private GameObject panelLives;


    void Awake()
    {
        instance = this;
        UIImageColor = new Color(1,0.5f,0.5f,0.5f);
    }

    private void Start()
    {
        panelLives = GameObject.Find("PanelLives");
        livesImageUI = new GameObject[panelLives.transform.childCount];
        for (int i = 0; i < panelLives.transform.childCount; i++)
        {
            livesImageUI[i] = GameObject.Find("Live" + (i = 1));
        }
    }

    public void RemoveLive()
        {
            if (liveCounter > 0)
            {
                liveCounter--;
                SetLiveImageUI();
            }

            if (liveCounter <= 0)
                GameManager.Instance.GameOver();
                print(liveCounter);
        }

        private void SetLiveImageUI()
        {
            //livesImageUI[liveCounter].GetComponent<Image>().color = UIImageColor;
        }
}
