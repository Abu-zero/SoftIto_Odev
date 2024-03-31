using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public CanvasGroup Scene1Canvas;
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
        DOTween.To(()=>Scene1Canvas.alpha,x=>Scene1Canvas.alpha=x,0,1);
    }
}
