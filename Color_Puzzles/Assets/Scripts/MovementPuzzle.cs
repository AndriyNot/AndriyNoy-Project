using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class MovementPuzzle : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    public GameObject form;
    public int IndexRotation;
    public int index;
    public int indexpuzzles;
    
    public bool finish = false;
    private Vector3 lastPosition;

    private Color _color;

    private Renderer _renderer;
    private Vector3 _offset;
    private float timer;
    private bool timerindex = true;
    public bool indexers = true;


  


    private void Start()
    {
        _renderer = GetComponent<Renderer>();
       
        
    }
    private void OnMouseDown()
    {
        Vector3 mousePosition = Input.mousePosition;
        _offset = transform.localPosition - Camera.main.ScreenToWorldPoint(new Vector2(mousePosition.x, mousePosition.y));

        //IndexRotation += 1;
        //Vector3 startposition = transform.position;
        //if (IndexRotation == 2 && transform.position == startposition && transform.position != form.transform.position)
        //{
        //    index += 90;
        //    transform.Rotate(0, 0, index);
        //    IndexRotation = 0;
        //}

        if (transform.localPosition != form.transform.localPosition)
        {
            offset = gameObject.transform.position - GetMouseWorldPos();
           
        }
        isDragging = true;


    }

    private void OnMouseDrag()
    {
        Vector3 mousePosition = Input.mousePosition;
        transform.localPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10.0f)) + _offset;

        if (isDragging)
        {
            gameObject.transform.position = GetMouseWorldPos() + offset;

        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
        if (transform.position != form.transform.position)
        {
            if (Mathf.Abs(transform.localPosition.x - form.transform.localPosition.x) <= 15f &&
            Mathf.Abs(transform.localPosition.y - form.transform.localPosition.y) <= 15f && transform.localRotation == form.transform.localRotation)
            {
                    transform.localPosition = new Vector3(form.transform.localPosition.x, form.transform.localPosition.y, form.transform.localPosition.z);
                    finish = true;

                    if (indexers == true)
                    {
                        WinnerManager.AddElement();
                        indexers = false;
                    }
             
            }
        }
        

    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = Camera.main.nearClipPlane;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void Update()
    {
       
        if (finish == true)
        {
            transform.localPosition = new Vector3(form.transform.localPosition.x, form.transform.localPosition.y, form.transform.localPosition.z);
            if (transform.localPosition == form.transform.localPosition)
            {
                if (timerindex == true)
                {
                    timer += Time.deltaTime;
                    _color = _renderer.material.color;
                    _color.a = 0.5f;
                    _renderer.material.color = _color;
                }
                
                
                
                if (timer >= 1)
                {
                    _color.a = 1f;
                    _renderer.material.color = _color;
                    timer = 0;
                    timerindex = false;
                }
            }
        }
       
    }
}
