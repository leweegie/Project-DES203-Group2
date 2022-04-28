using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas Canvas;
    CanvasGroup canvasGroup;

    private RectTransform rectTranform;

    void Awake()
    {
        rectTranform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        SetCanvas();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnbeginDrag");
        canvasGroup.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTranform.anchoredPosition += eventData.delta / Canvas.scaleFactor;
    }

    public void SetCanvas()
    {
        Canvas = GetComponentInParent<Canvas>();
        Debug.Log("SetParent");
    }

}

