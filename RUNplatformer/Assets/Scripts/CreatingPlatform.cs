using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CreatingPlatform : MonoBehaviour
{
    public PlatformMovement platformMovement;
    public GameObject objectsPlatform;
    public GameObject[] objectsPastka;
    public GameObject objectsPastkaTwo;
    public GameObject[] objectsPoints;
    public GameObject[] objectsPointsKust;
    public GameObject ObjectsCoins;
    public GameObject ObjectsBonus;
    public GameObject deletPlatform;
    public GameObject deletPoints;

    public TextMeshProUGUI textpoint;
    public TextMeshProUGUI textResult;
    public TextMeshProUGUI textNewRecord;
    public float randomsVectorx;
    public float randomsVectorxs;
    
    public int index;
    public int result;
    public int result1;
    public int indexer;
    public int indexer1;
    public Vector2 vector;
    public float vectorYObjects;
    public float vectorYPastka;
    public float vectorYOkust;
    public float vectorYcoins;
   

    private void Awake()
    {

        
    }

    private void Update()
    {
       
        result = PlayerPrefs.GetInt("result", result);

        
           
       

        if (index > result)
        {
            
            result += index - result;
            PlayerPrefs.SetInt("result", result);
            textNewRecord.gameObject.SetActive(true);
        }

        textResult.text = "" + result;
        textpoint.text = "" + index;
        

        if (index == 20)
        {
            Time.timeScale = 1.3f;
        }
        if (index == 40)
        {
            Time.timeScale = 1.5f;
        }
        if (index == 80)
        {
            Time.timeScale = 1.7f;
        }
        if (index == 160)
        {
            Time.timeScale = 1.9f;
        }
        if (index == 220)
        {
            Time.timeScale = 2.1f;
        }
        if (index == 400)
        {
            Time.timeScale = 2.4f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(objectsPlatform, vector, Quaternion.Euler(0, 0, 0));
            creatingObjects();
            creatingKust();
            creatingCoins();
            creatingBonus();

            index += 2;
            //result += 2;

            //PlayerPrefs.SetInt("result", result);
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(deletPlatform);
            Destroy(deletPoints);


            index += 2;
            //result += 2;

            //PlayerPrefs.SetInt("result", result);
        }
    }

    public void creatingKust()
    {
        int randomobjects = Random.Range(0, objectsPointsKust.Length);
        int randomobjectsTwo = Random.Range(0, objectsPointsKust.Length);
        int randomKust = Random.Range(10, 26);
        int randomKustTwo = Random.Range(10, 26);
        Instantiate(objectsPointsKust[randomobjects], new Vector3(randomKust, vectorYOkust, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(objectsPointsKust[randomobjectsTwo], new Vector3(randomKustTwo, vectorYOkust, 0), Quaternion.Euler(0, 0, 0));
    }
    public void creatingObjects()
    {
        int rand1 = Random.Range(0, objectsPoints.Length);
        int rand = Random.Range(0, objectsPoints.Length);
        int rand2 = Random.Range(0, objectsPastka.Length);
       
        int randomsVectorx1 = Random.Range(11, 31);
        int randomsVectorx2 = Random.Range(11, 31);
        int randomsVectorx3 = Random.Range(11, 31);
        int randomsVectorx4 = Random.Range(11, 31);

        if (index <= 100)
        {
            Instantiate(objectsPoints[rand2], new Vector3(randomsVectorx3, vectorYObjects, 0), Quaternion.Euler(0, 0, 0));
        }
        if (index >= 102 && randomsVectorx3 != randomsVectorx1 && randomsVectorx3 != randomsVectorx2 && randomsVectorx3 != randomsVectorx4)
        {
            Instantiate(objectsPastka[rand2], new Vector3(randomsVectorx3, vectorYPastka, 0), Quaternion.Euler(0, 0, 0));
        }
        if (index >= 202 && randomsVectorx4 != randomsVectorx1 && randomsVectorx4 != randomsVectorx2 && randomsVectorx4 != randomsVectorx3)
        {
            Instantiate(objectsPastkaTwo, new Vector3(randomsVectorx4, vectorYObjects, 0), Quaternion.Euler(0, 0, 0));
        }
        Instantiate(objectsPoints[rand], new Vector3(randomsVectorx1, vectorYObjects, 0), Quaternion.Euler(0, 0, 0));
        Instantiate(objectsPoints[rand1], new Vector3(randomsVectorx2, vectorYObjects, 0), Quaternion.Euler(0, 0, 0));
        
    }
    public void creatingCoins()
    {
        int rand1 = Random.Range(0, 50);
        int rand = Random.Range(11, 2);
        if (rand1 == 1)
        {
            Instantiate(ObjectsCoins, new Vector3(rand, vectorYcoins, 0), Quaternion.Euler(0, 0, 0));
        }
        else
        {

        }
    }

    public void creatingBonus()
    {
        int rand1 = Random.Range(0, 100);
        int rand = Random.Range(11, 25);
        if (rand1 == 5)
        {
            Instantiate(ObjectsBonus, new Vector3(rand, vectorYcoins, 0), Quaternion.Euler(0, 0, 0));
        }
        else
        {

        }
    }
}
