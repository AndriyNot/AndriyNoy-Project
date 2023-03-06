using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SnapScollingMAP : MonoBehaviour
{
    [Range(1, 50)]
    [Header("Controlles")]
    public int panCount;
    [Range(0, 500)]
    public int panOffset;
    [Range(0f, 20f)]
    public float snapSpeed;
    [Range(0f, 5f)]
    public float ScaleOffset;
    [Range(1f, 20f)]
    public float scaleSpeed;
    [Header("Other Objects")]
    //public GameObject panPrefab;
    public GameObject panPrefab;
    public GameObject pan;
    public GameObject pan1;
    public GameObject pan2;
    public GameObject pan3;
    public GameObject pan4;
    public GameObject pan5;

    public ScrollRect scrollRect;

    private GameObject[] instPans;
    public Image[] images;

    private Vector2[] pansPos;
    private Vector2[] pansScale;

    private RectTransform contentRect;

    private Vector2 contentVector;

    public int selectedPanID;
    public int selectedPanindex;
    private bool isScrolling;

    public int block1;
    public int block2;
    public int block3;
    public int block4;
    public int block5;
    public int block6;

    private void Start()
    {
        contentRect = GetComponent<RectTransform>();

        instPans = new GameObject[panCount];
        pansPos = new Vector2[panCount];
        pansScale = new Vector2[panCount];
        for (int i = 0; i < panCount; i++)
        {
            if (i == 0)
            {
                instPans[i] = Instantiate(pan, transform, false);
            }
            if (i == 1)
            {
                instPans[i] = Instantiate(pan1, transform, false);
            }
            else if (i == 2)
            {
                instPans[i] = Instantiate(pan2, transform, false);
            }
            else if (i == 3)
            {
                instPans[i] = Instantiate(pan3, transform, false);
            }
            else if (i == 4)
            {
                instPans[i] = Instantiate(pan4, transform, false);
            }
            else if (i == 5)
            {
                instPans[i] = Instantiate(pan5, transform, false);
            }
            if (i == 0) continue;

            instPans[i].transform.localPosition = new Vector2(instPans[i - 1].transform.localPosition.x + pan.GetComponent<RectTransform>().sizeDelta.x + panOffset,
                instPans[i].transform.localPosition.y);
            pansPos[i] = -instPans[i].transform.localPosition;



        }


    }

    private void Update()
    {
        

        if (contentRect.anchoredPosition.x >= pansPos[0].x && !isScrolling || contentRect.anchoredPosition.x <= pansPos[pansPos.Length - 1].x && !isScrolling)
        {
            scrollRect.inertia = false;
        }
        float nearstPos = float.MaxValue;
        for (int i = 0; i < panCount; i++)
        {
            float distance = Mathf.Abs(contentRect.anchoredPosition.x - pansPos[i].x);
            if (distance < nearstPos)
            {
                nearstPos = distance;
                selectedPanID = i;
            }
            float scale = Mathf.Clamp(1 / (distance / panOffset) * ScaleOffset, 2.0f, 2.5f);
            pansScale[i].x = Mathf.SmoothStep(instPans[i].transform.localScale.x, scale + 0.3f, scaleSpeed * Time.fixedDeltaTime);
            pansScale[i].y = Mathf.SmoothStep(instPans[i].transform.localScale.y, scale + 0.3f, scaleSpeed * Time.fixedDeltaTime);
            instPans[i].transform.localScale = pansScale[i];
        }
        float scrolVelocity = Mathf.Abs(scrollRect.velocity.x);
        if (scrolVelocity < 400 && !isScrolling)
        {
            scrollRect.inertia = false;
        }
        if (isScrolling || scrolVelocity > 400) return;

        contentVector.x = Mathf.SmoothStep(contentRect.anchoredPosition.x, pansPos[selectedPanID].x, snapSpeed * Time.fixedDeltaTime);
        contentRect.anchoredPosition = contentVector;

        Check();

        block1 = PlayerPrefs.GetInt("blockmap1");
        block2 = PlayerPrefs.GetInt("blockmap2");
        block3 = PlayerPrefs.GetInt("blockmap3");
    }

    public void Scrolling(bool scroll)
    {
        isScrolling = scroll;
        if (scroll)
        {
            scrollRect.inertia = true;
        }
    }

    public void Check()
    {
        if (selectedPanID == 1)
        {
            selectedPanindex = 1;
            PlayerPrefs.SetInt("indexMap", selectedPanindex);
        }

        if (selectedPanID == 2 && block1 != 1)
        {

            selectedPanindex = 1;
            PlayerPrefs.SetInt("indexMap", selectedPanindex);
        }
        if (selectedPanID == 2 && block1 == 1)
        {
            selectedPanindex = 2;
            PlayerPrefs.SetInt("indexMap", selectedPanindex);
        }

        if (selectedPanID == 3 && block2 != 1)
        {

            selectedPanindex = 1;
            PlayerPrefs.SetInt("indexMap", selectedPanindex);
        }
        if (selectedPanID == 3 && block2 == 1)
        {
            selectedPanindex = 3;
            PlayerPrefs.SetInt("indexCharacter", selectedPanindex);
        }

        if (selectedPanID == 4 && block3 != 1)
        {

            selectedPanindex = 1;
            PlayerPrefs.SetInt("indexMap", selectedPanindex);
        }
        if (selectedPanID == 4 && block3 == 1)
        {
            selectedPanindex = 4;
            PlayerPrefs.SetInt("indexMap", selectedPanindex);
        }



    }

}


