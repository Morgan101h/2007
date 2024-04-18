using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    // Adds/Removes an interaction event component to gameobject
    public bool useEvents;
   [SerializeField]
   // message displayed to player when looking at an interactable
    public string promptMessage;

   public virtual string OnLook()
    { 
          return promptMessage;
    }



    //this function will be called from our player
    public void BaseInteract()
    {
        if (useEvents)
        GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }
    
   

    protected virtual void Interact()
    {
        
       //template function to be overidden by the subclasses


    }
}
