using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public CanvasGroup Scene1Canvas;
    public RectTransform Scene1Header,Scene1Footer,Scene1BodyRight,Scene1BodyLeft;
    void Awake(){
        Scene1Canvas.alpha=1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InventoryClick(){
        Scene1Header.DOAnchorPosY(10, 0.5f);
        Scene1Footer.DOAnchorPosY(-10, 0.5f);
        Scene1BodyRight.DOAnchorPosX(10, 0.5f);
        Scene1BodyLeft.DOAnchorPosX(-10, 0.5f);
        DOTween.To(()=>Scene1Canvas.alpha,x=>Scene1Canvas.alpha=x,0,1);
        //Scene1Header.DOAnchorPosY(Scene1Header.offsetMax.y,Scene1Header.offsetMax.y-100).SetRelative(true);
        
    }
}
