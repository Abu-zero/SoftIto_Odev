using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public CanvasGroup Scene1Canvas,Scene2Canvas;
    public RectTransform Scene1Header,Scene1Footer,Scene1BodyRight,Scene1BodyLeft,Scene2Header,Scene2Body,Scene2Footer;
    void Awake(){
        Scene1Canvas.alpha=1;
        Scene2Canvas.alpha=0;
    }
    void Start()
    {
        Scene2Header.DOAnchorPosY(Scene2Header.anchoredPosition.y+10, 0.1f);
        Scene2Body.DOAnchorPosY(Scene2Body.anchoredPosition.y+10, 0.1f);
        Scene2Footer.DOAnchorPosY(Scene2Header.anchoredPosition.y-10, 0.1f);
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
        Scene2Header.DOAnchorPosY(0, 0.5f);
        Scene2Body.DOAnchorPosY(0, 0.5f);
        Scene2Footer.DOAnchorPosY(0, 0.5f);
        DOTween.To(()=>Scene2Canvas.alpha,x=>Scene2Canvas.alpha=x,1,1);

        //Scene1Header.DOAnchorPosY(Scene1Header.offsetMax.y,Scene1Header.offsetMax.y-100).SetRelative(true);
        
    }
}
