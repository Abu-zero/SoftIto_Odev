using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEditor;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;
using TMPro;

public class UIController : MonoBehaviour
{
    
    public GameObject Scene1,Scene2,PotionItemSelected,ItemFrame,PotionFrame,FrameImage,ItemFrame2,Slot1,Slot2,Slot3,ItemFrame2In1,
    ItemFrame2In2,ItemFrame2In3,ItemFrame2In4,Ember1,Ember2,Ember3,CraftButton,CraftImage,EmberMain,MainPotion;
    public CanvasGroup Scene1Canvas,Scene2Canvas,Scene3Canvas;
    public RectTransform Scene1Header,Scene1Footer,Scene1BodyRight,Scene1BodyLeft,Scene2Header,Scene2Body,
    Scene2Footer,PotionItemSelectedRect,PotionItemRect,Ember1Rect,Ember2Rect,Ember3Rect;
    public TextMeshProUGUI ItemFrameText,ItemFrameText2,ItemFrameText3,CraftText,CraftText2,EnoughText;
    public Sprite ButtonSprite,CraftSprite;
    public bool CounterButton,CounterPotion,CounterClose,CounterQuest,CounterInventory;

    void Awake(){
        Scene1Canvas.alpha=1;
        Scene2Canvas.alpha=0;
        Scene3Canvas.alpha=0;
        PotionItemSelected.active=false;
        PotionFrame.active=false;
        Ember1.active=false;
        Ember2.active=false;
        Ember3.active=false;
        ItemFrameText3.enabled=false;
        ItemFrameText2.enabled=false;
    }
    void Start()
    {
        Scene2Header.DOAnchorPosY(Scene2Header.anchoredPosition.y+10, 0.1f);
        Scene2Body.DOAnchorPosY(Scene2Body.anchoredPosition.y+10, 0.1f);
        Scene2Footer.DOAnchorPosY(Scene2Header.anchoredPosition.y-10, 0.1f);
        PotionItemRect.DOAnchorPosY(Scene2Header.anchoredPosition.y+10, 0.1f);
        Ember1Rect.DOAnchorPosY(Scene2Header.anchoredPosition.y+10, 0.1f);
        Ember2Rect.DOAnchorPosY(Scene2Header.anchoredPosition.y+10, 0.1f);
        Ember3Rect.DOAnchorPosY(Scene2Header.anchoredPosition.y+10, 0.1f);
    }
    void Update()
    {
        
    }
    public void InventoryClick(){
        if(CounterInventory==false){
        Scene1Header.DOAnchorPosY(10, 0.5f);
        Scene1Footer.DOAnchorPosY(-10, 0.5f);
        Scene1BodyRight.DOAnchorPosX(10, 0.5f);
        Scene1BodyLeft.DOAnchorPosX(-10, 0.5f);
        DOTween.To(()=>Scene1Canvas.alpha,x=>Scene1Canvas.alpha=x,0,1).OnComplete(()=>{Scene1.active=false;});
        Scene2Header.DOAnchorPosY(0, 0.5f);
        Scene2Body.DOAnchorPosY(0, 0.5f);
        Scene2Footer.DOAnchorPosY(0, 0.5f);
        DOTween.To(()=>Scene2Canvas.alpha,x=>Scene2Canvas.alpha=x,1,1);
        }
    }
    public void ItemPotionClick(){
        if(CounterPotion==false){
        PotionItemSelected.active=true;
        PotionItemSelectedRect.DOScale(1.1f, 0.5f).SetLoops(-1,LoopType.Yoyo);
        ItemFrame.GetComponent<Image>().color = new Color32(243,229,162,255);
        ItemFrame2.GetComponent<Image>().color = new Color32(243,229,162,255);
        Slot1.GetComponent<Image>().color = new Color32(243,229,162,255);
        Slot2.GetComponent<Image>().color = new Color32(243,229,162,255);
        Slot3.GetComponent<Image>().color = new Color32(243,229,162,255);
        ItemFrame2In1.GetComponent<Image>().color = new Color32(243,229,162,255);
        ItemFrame2In2.GetComponent<Image>().color = new Color32(243,229,162,255);
        ItemFrame2In3.GetComponent<Image>().color = new Color32(243,229,162,255);
        ItemFrame2In4.GetComponent<Image>().color = new Color32(243,229,162,255);
        FrameImage.active=false;
        PotionFrame.active=true;
        Ember1.active=true;
        Ember2.active=true;
        Ember3.active=true;
        PotionItemRect.DOAnchorPosY(0, 0.5f);
        Ember1Rect.DOAnchorPosY(0, 0.5f);
        Ember2Rect.DOAnchorPosY(0, 0.5f);
        Ember3Rect.DOAnchorPosY(0, 0.5f);
        ItemFrameText.enabled=false;
        ItemFrameText2.enabled=true;
        ItemFrameText3.enabled=true;
        ItemFrameText2.text="";
        CraftButton.GetComponent<Image>().sprite=ButtonSprite;
        DOTween.To(() => ItemFrameText2.text, (yazi) => ItemFrameText2.text = yazi, "Lorem ipsum dolor sit amet consectetur. Platea elit morbi nullam quisque orci turpis massa amet.", 1f).SetOptions(true, ScrambleMode.None);
        CounterPotion=true;
        CounterButton=true;
        }
    }
    public void CraftButtonClick(){
        if(CounterButton==true){
        CraftImage.GetComponent<Image>().DOFillAmount(1, 3).OnComplete(()=>{
            CraftImage.GetComponent<Image>().enabled=false;
            CraftText2.text="";
            DOTween.To(() => CraftText.text, (yazi) => CraftText.text = yazi, "Craft", 0.5f).SetOptions(true, ScrambleMode.None);
            EnoughText.enabled=true;
            EmberMain.active=false;
            Ember1.GetComponent<Image>().color = new Color32(255,255,255,127);
            Ember2.GetComponent<Image>().color = new Color32(255,255,255,127);
            Ember3.GetComponent<Image>().color = new Color32(255,255,255,127);
            Slot1.GetComponent<Image>().color = new Color32(175,175,175,255);
            Slot2.GetComponent<Image>().color = new Color32(175,175,175,255);
            Slot3.GetComponent<Image>().color = new Color32(175,175,175,255);
            CounterClose=true;
        });
        CraftButton.GetComponent<Image>().sprite=CraftSprite;
        CraftText.text="";
        DOTween.To(() => CraftText2.text, (yazi) => CraftText2.text = yazi, "In crafting", 0.5f).SetOptions(true, ScrambleMode.None);
        CounterButton=false;
        }
    }
    public void CloseButton(){
        if(CounterClose==true){
        Scene2Header.DOAnchorPosY(10, 0.5f);
        Scene2Body.DOAnchorPosY(10, 0.5f);
        Scene2Footer.DOAnchorPosY(-10, 0.5f);
        DOTween.To(()=>Scene2Canvas.alpha,x=>Scene2Canvas.alpha=x,0,1).OnComplete(()=>{
            Scene2.active=false;
            
        });
        Scene1.active=true;
        Scene1Header.DOAnchorPosY(0, 0.5f);
        Scene1Footer.DOAnchorPosY(0, 0.5f);
        Scene1BodyRight.DOAnchorPosX(0, 0.5f);
        Scene1BodyLeft.DOAnchorPosX(0, 0.5f);
        DOTween.To(()=>Scene1Canvas.alpha,x=>Scene1Canvas.alpha=x,1,1);
        MainPotion.active=true;
        CounterClose=false;
        CounterQuest=true;
        CounterInventory=true;
        }
    }
    public void PotionClick(){
        if(CounterQuest==true){
        DOTween.To(()=>Scene1Canvas.alpha,x=>Scene1Canvas.alpha=x,0,1).OnComplete(()=>{Scene1.active=false;});
        DOTween.To(()=>Scene3Canvas.alpha,x=>Scene3Canvas.alpha=x,1,1);
        }
    }
}
