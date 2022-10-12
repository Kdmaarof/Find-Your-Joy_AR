using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseButton_UI : MonoBehaviour
{
    public GameObject BoxGift;
    private void ExecuteTrigger(string trigger)
    {
        if(BoxGift != null)
        {
            var animator = BoxGift.GetComponent<Animator>();
            if(animator != null)
            {
                animator.SetTrigger(trigger);
            }
        }
    }
    // Start is called before the first frame update
    public void onOpenButtonClick()
    {
        ExecuteTrigger("TrOpen");
    
    }


    // Update is called once per frame
    public void onCloseButtonClick()
    {
        ExecuteTrigger("TrClose");
    }

}

